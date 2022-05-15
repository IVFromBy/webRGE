using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using webRGE.Context;
using webRGE.Entities.Enum;
using webRGE.Services;
using webRGE.ViewModels;

namespace webRGE.Controllers
{
    public class HomeController : Controller
    {
        private readonly RgeDb _db;
        private readonly ParcerService _parcerService;
        private readonly CommonService _commonService;

        public HomeController(RgeDb db, ParcerService parcerService, CommonService commonService)
        {
            _db = db;
            _parcerService = parcerService;
            _commonService = commonService;
        }
        public async Task<IActionResult> Index(int? RegNum, string SearchName)
        {
            var model = new Egr01NameViewModel();

            if (RegNum != default && !string.IsNullOrEmpty(SearchName))
            {

                model.RegisterdUsers = await _db.MainSearchs.FromSqlRaw("exec mainSearch @ngr={0}, @nm={1}", RegNum, SearchName).ToListAsync();
            }
            else
            if (RegNum != default)
            {

                model.RegisterdUsers = await _db.MainSearchs.FromSqlRaw("exec mainSearch @ngr={0}", RegNum).ToListAsync();
            }
            else
            if (!string.IsNullOrEmpty(SearchName))
            {

                model.RegisterdUsers = await _db.MainSearchs.FromSqlRaw("exec mainSearch @nm={0}", SearchName).ToListAsync();
            }


            return View(model);
        }
        public IActionResult Import() => View();


        [HttpPost]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> Load(IFormFileCollection tn)
        {
            int readRowCount = 300000;

            var Lines = new string[readRowCount];

            if (tn != null)
            {

                foreach (var file in tn)
                {

                    var dictionary = _commonService.GetFileTypeDictionaty();

                    string fname = Path.GetFileNameWithoutExtension(file.FileName);


                    if (dictionary.ContainsValue(fname))
                    {
                        var TabelNames = (TabelNames)dictionary.FirstOrDefault(d => d.Value == fname).Key;

                        using (StreamReader r = new StreamReader(new BufferedStream(file.OpenReadStream(), 1024 * 1024)))
                        {
                            int count = 0;
                            int columnCount = r.ReadLine().Split('\t').Count();//считываем шапку
                            await _parcerService.ClearSelector(TabelNames);

                            while (r.EndOfStream != true)
                            {
                                Lines[count] = await r.ReadLineAsync();
                                if (TabelNames == TabelNames.EGR0302) // отдельная обрабока, из-за кривого файла
                                {
                                    int currentColumnCount = Lines[count].Split('\t').Count();
                                    if (currentColumnCount < columnCount)
                                    {
                                        while (currentColumnCount < columnCount)
                                        {
                                            Lines[count] += await r.ReadLineAsync();
                                            currentColumnCount = Lines[count].Split('\t').Count();
                                        }
                                    }
                                }
                                count++;
                                if (count == readRowCount)
                                {
                                    count = 0;
                                    await _parcerService.ParserSelector(TabelNames, Lines);
                                    Array.Clear(Lines, 0, readRowCount);

                                }

                            }
                            if (count > 0 && count <= readRowCount)
                            {
                                count = 0;
                                await _parcerService.ParserSelector(TabelNames, Lines);
                                Array.Clear(Lines, 0, readRowCount);
                            }

                            ViewBag.Message += string.Format(" Файл <b>{0}</b> загружен. <br />", file.FileName);
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("",
                            string.Format(" Файл {0} не обрабатывается! Список доступных, для обработки файлов смотрите выше! ", Path.GetFileNameWithoutExtension(file.FileName)));
                    }


                }
            }
            return View("Import");
        }

    }
}
