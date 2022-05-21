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
        public async Task<IActionResult> HistoryManager(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new HistoryManagerViewModel();
            model.Report = await _db.HistoryManagerReport.FromSqlRaw("exec HistoryManager @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        
        public async Task<IActionResult> ActivityType(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new ActivityTypeViewModel();
            model.Report = await _db.ActivityTypeReport.FromSqlRaw("exec ActivityType @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> ActivityTypeExt(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new ActivityTypeExtViewModel();
            model.Report = await _db.ActivityTypeExtReport.FromSqlRaw("exec ActivityTypeExt @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> ActivityTypeExt2(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new ActivityTypeExt2ViewModel();
            model.Report = await _db.ActivityTypeExt2Report.FromSqlRaw("exec ActivityTypeExt2 @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> ActivityTypeExt3(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new ActivityTypeExt3ViewModel();
            model.Report = await _db.ActivityTypeExt3Report.FromSqlRaw("exec ActivityTypeExt3 @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> ActivityTypeMain(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new ActivityTypeMainViewModel();
            model.Report = await _db.ActivityTypeMainReport.FromSqlRaw("exec ActivityTypeMain @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> q0313(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new q0313ViewModel();
            model.Report = await _db.q0313Report.FromSqlRaw("exec q0313 @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        
        public async Task<IActionResult> SocNum(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new SocNumViewModel();
            model.Report = await _db.SocNumReport.FromSqlRaw("exec Egr0359SocNum @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> q0355(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new q0355ViewModel();
            model.Report = await _db.q0355Report.FromSqlRaw("exec q0355 @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
        public async Task<IActionResult> q0331(int? ngr)
        {
            if (ngr == null) return RedirectToAction("Index", "Report");

            var model = new q0331ViewModel();
            model.Report = await _db.q0331Report.FromSqlRaw("exec q0331 @ngr={0}", ngr).ToListAsync();

            return View(model);
        }
    }
}
