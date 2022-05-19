using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using webRGE.Context;
using webRGE.Entities.Reports;
using webRGE.ViewModels;

namespace webRGE.Controllers
{
    public class ReportController : Controller
    {
        private readonly RgeDb _db;

        public ReportController(RgeDb db)
        {
            _db = db;
        }
        public IActionResult Index(int? RegNum)
        {
            return View(RegNum);
        }

        public async Task<IActionResult> HistoryStatus(int? ngr)
        {
            if (ngr == null)  return RedirectToAction("Index","Report");
            
            var model = new HistoryStatusViewModel();
            model.Report = await _db.HistoryStatusReport.FromSqlRaw("exec HistoryType @ngr={0}", ngr).ToListAsync();


            return View(model);
        }

        public async Task<IActionResult> HistoryName(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new HistoryNameViewModel();
            model.Report = await _db.HistoryNameReport.FromSqlRaw("exec HistoryName @ngr={0}", ngr).ToListAsync();


            return View(model);
        }
    }
}
