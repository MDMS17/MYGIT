using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PAHWebApp.Data;
using PAHWebApp.Models;
using PAHWebApp.Models.PAHViewModels;

namespace PAHWebApp.Controllers
{
    public class PharmReportsController : Controller
    {
        private readonly IPah_Repository repository;

        public PharmReportsController(IPah_Repository repo)
        {
            repository = repo;
        }

        // GET: PharmReports
        public async Task<IActionResult> Index()
        {
            var reportList = await repository.ListAsync();
            var model = reportList.Select(x=>new ReportViewModel()
            {
                Reports = reportList,
                CurrentReportType = "Scrub",
                PagingInfo = new PagingInfo { CurrentPage = 1, ItemsPerPage = 3, TotalItems = 5 }
            });

            return View(model);

        }


    }
}
