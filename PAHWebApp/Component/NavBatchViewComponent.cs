using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAHWebApp.Models;
using PAHWebApp.Data;

namespace PAHWebApp.Component
{
    public class NavBatchViewComponent:ViewComponent 
    {
        IPah_Repository repository;
        public NavBatchViewComponent(IPah_Repository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            //ViewBag.SelectedBatchStatus = RouteData?.Values["batchStatus"];
            return View(repository.BatchStatuses.Select(x => x.BatchStatusName).OrderBy(x => x));
        }
    }
}
