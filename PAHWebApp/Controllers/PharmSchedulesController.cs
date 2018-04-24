using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PAHWebApp.Data;
using PAHWebApp.Models;
using PAHWebApp.Models.PAHViewModels;
using System.IO;
using PAHWebApp.Services;
using Microsoft.Extensions.Options;

namespace PAHWebApp.Controllers
{
    public class PharmSchedulesController : Controller
    {
        public readonly IOptions<ServiceUrl> Config;
        private readonly IPah_Repository repository;
        public int pageSize = 10;
        public PharmSchedulesController(IPah_Repository repo,IOptions<ServiceUrl> config)
        {
            repository = repo;
            Config = config;
        }

        // GET: PharmSchedules
        public async Task<IActionResult> Index(string scheduleStatus, int schedulePage)
        {
            ViewBag.SelectedScheduleStatus = scheduleStatus;
            DateTime endTime = DateTime.Today;
            DateTime startTime = endTime.AddMonths(-6);
            int scheduleStatusId = await repository.ScheduleStatuses.Where(x => x.ScheduleStatusName == scheduleStatus).Select(x => x.ScheduleStatusId).FirstOrDefaultAsync();
            ScheduleViewModel scheduleViewModel = new ScheduleViewModel
            {
                Schedules = await repository.AllSchedules.Where(x => x.ScheduleStartDate >= startTime && x.ScheduleStartDate <= endTime && x.ScheduleStatusId == scheduleStatusId).ToListAsync(),
                PagingInfo = new PagingInfo { CurrentPage = 1, ItemsPerPage = pageSize, TotalItems = string.IsNullOrEmpty(scheduleStatus) ? repository.AllSchedules.Count() : repository.AllSchedules.Where(x => x.ScheduleStartDate >= startTime && x.ScheduleStartDate <= endTime && x.ScheduleStatusId == scheduleStatusId).Count() },
                CurrentScheduleStatus = scheduleStatus
            };
            return View(scheduleViewModel);
        }

        // GET: PharmSchedules/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pharmSchedule = await _context.PharmSchedule
        //        .SingleOrDefaultAsync(m => m.ScheduleId == id);
        //    if (pharmSchedule == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pharmSchedule);
        //}

        // GET: PharmSchedules/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PharmSchedules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModifiedUserId,ModifiedDateTime,ScheduleId,MarketId,ScheduleTypeId,ScheduleName,ScheduleStartDate,ScheduleEndDate,FileName,FilePath,IsPreAdjudicated,IsScrubEnabled,ScheduleStatusId,Count,SourceTypeId,IsResubmit,IsForceVoid,IsAutoGenerateFile,ScheduleError")] PharmSchedule pharmSchedule)
        {
            if (ModelState.IsValid)
            {
                await repository.SaveSchedule (pharmSchedule);
                return RedirectToAction(nameof(Index));
            }
            return View(pharmSchedule);
        }

        // GET: PharmSchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmSchedule = await repository .AllSchedules.SingleOrDefaultAsync(m => m.ScheduleId == id);
            if (pharmSchedule == null)
            {
                return NotFound();
            }
            return View(pharmSchedule);
        }

        // POST: PharmSchedules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModifiedUserId,ModifiedDateTime,ScheduleId,MarketId,ScheduleTypeId,ScheduleName,ScheduleStartDate,ScheduleEndDate,FileName,FilePath,IsPreAdjudicated,IsScrubEnabled,ScheduleStatusId,Count,SourceTypeId,IsResubmit,IsForceVoid,IsAutoGenerateFile,ScheduleError")] PharmSchedule pharmSchedule)
        {
            if (id != pharmSchedule.ScheduleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await repository.SaveSchedule (pharmSchedule);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PharmScheduleExists(pharmSchedule.ScheduleId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pharmSchedule);
        }

        // GET: PharmSchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmSchedule = await repository.AllSchedules
                .SingleOrDefaultAsync(m => m.ScheduleId == id);
            if (pharmSchedule == null)
            {
                return NotFound();
            }

            return View(pharmSchedule);
        }

        // POST: PharmSchedules/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var pharmSchedule = await repository.AllSchedules.SingleOrDefaultAsync(m => m.ScheduleId == id);
        //    _context.PharmSchedule.Remove(pharmSchedule);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost, ActionName("Export")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Export(int? id)
        {
            HttpClient client = new HttpClient();
            ServiceUrl urls = Config.Value;
            client.BaseAddress = new Uri(urls.FileGenerationServiceUrl);
            string apiUrl = "api/pahFileGeneration/GenerateFile/" + id.ToString();
            await client.GetAsync(apiUrl);
            return RedirectToAction(nameof(Index));
        }

        private bool PharmScheduleExists(int id)
        {
            return repository.AllSchedules.Any(e => e.ScheduleId == id);
        }
    }
}
