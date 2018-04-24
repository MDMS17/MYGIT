using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAHWebApp.Data;
using PAHWebApp.Models;

namespace PAHWebApp.Component
{
    public class NavScheduleViewComponent:ViewComponent
    {
        private IPah_Repository repository;
        public NavScheduleViewComponent(IPah_Repository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.ScheduleStatuses.Select(x => x.ScheduleStatusName).OrderBy(x => x));
        }

    }
}
