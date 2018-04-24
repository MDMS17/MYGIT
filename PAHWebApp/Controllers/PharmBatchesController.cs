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
    public class PharmBatchesController : Controller
    {
        private IPah_Repository repository;

        public PharmBatchesController(IPah_Repository  repo)
        {
            repository = repo;
        }

        // GET: PharmBatches
        public async Task<IActionResult> Index(string batchStatus, int batchPage)
        {
            ViewBag.SelectedBatchStatus = batchStatus;
            DateTime endTime = DateTime.Today;
            DateTime startTime = endTime.AddMonths(-6);
            byte batchStatusId = await repository.BatchStatuses.Where(x => x.BatchStatusName == batchStatus).Select(x => x.BatchStatusId).FirstOrDefaultAsync();
            List<PharmBatch> batches = await repository.ListBatchesAsync();
            BatchViewModel batchViewModel = new BatchViewModel
            {
                Batches = batches.Where(x => x.StartDate >= startTime && x.StartDate <= endTime && x.BatchStatusId == batchStatusId),
                PagingInfo = new PagingInfo { CurrentPage = 1, ItemsPerPage = 10, TotalItems =string.IsNullOrEmpty(batchStatus)?repository.AllBatches.Count():repository.AllBatches.Where(x=>x.StartDate>=startTime&&x.StartDate<=endTime&&x.BatchStatusId==batchStatusId ).Count()},
                CurrentBatchStatus = batchStatus
            };
            return View(batchViewModel);
        }
        // GET: PharmBatches/Details/5
        //public async Task<IActionResult> Details(long? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var pharmBatch = await _context.PharmBatch
        //        .SingleOrDefaultAsync(m => m.BatchId == id);
        //    if (pharmBatch == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pharmBatch);
        //}

        // GET: PharmBatches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PharmBatches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModifiedUserId,ModifiedDateTime,BatchId,MarketId,ScheduleId,BatchStatusId,FileName,FilePath,RangeStartDOS,RangeEndDOS,StartDate,EndDate,StagingStartDate,StagingEndDate,BusinessUpdateStartDate,BusinessUpdateEndDate,ScrubStartDate,ScrubEndDate,StagingClaimCount,ProcessedClaimCount,ScrubClaimCount,SubmittedClaimCount,StagingErrorCount,BusinessUpdateErrorCount,ScrubErrorCount,FileGenerationErrorCount,IsPreAdjudicated,IsScrubEnabled,PurgeDate,BatchMessage,IsFailed,IsExportComplete,StagingPartitionKey,CachePartitionKey,IsParsed,ClmChargeAmt,ClmPatPaidAmt,ScrubbedClmChargeAmt,ScrubbedClmPatPaidAmt,BatchProcessTime")] PharmBatch pharmBatch)
        {
            if (ModelState.IsValid)
            {
                await repository.SaveBatch (pharmBatch);
                return RedirectToAction(nameof(Index));
            }
            return View(pharmBatch);
        }

        // GET: PharmBatches/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmBatch = await repository.AllBatches.SingleOrDefaultAsync(m => m.BatchId == id);
            if (pharmBatch == null)
            {
                return NotFound();
            }
            return View(pharmBatch);
        }

        // POST: PharmBatches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("ModifiedUserId,ModifiedDateTime,BatchId,MarketId,ScheduleId,BatchStatusId,FileName,FilePath,RangeStartDOS,RangeEndDOS,StartDate,EndDate,StagingStartDate,StagingEndDate,BusinessUpdateStartDate,BusinessUpdateEndDate,ScrubStartDate,ScrubEndDate,StagingClaimCount,ProcessedClaimCount,ScrubClaimCount,SubmittedClaimCount,StagingErrorCount,BusinessUpdateErrorCount,ScrubErrorCount,FileGenerationErrorCount,IsPreAdjudicated,IsScrubEnabled,PurgeDate,BatchMessage,IsFailed,IsExportComplete,StagingPartitionKey,CachePartitionKey,IsParsed,ClmChargeAmt,ClmPatPaidAmt,ScrubbedClmChargeAmt,ScrubbedClmPatPaidAmt,BatchProcessTime")] PharmBatch pharmBatch)
        {
            if (id != pharmBatch.BatchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await repository.SaveBatch (pharmBatch);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PharmBatchExists(pharmBatch.BatchId))
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
            return View(pharmBatch);
        }

        // GET: PharmBatches/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmBatch = await repository.AllBatches
                .SingleOrDefaultAsync(m => m.BatchId == id);
            if (pharmBatch == null)
            {
                return NotFound();
            }

            return View(pharmBatch);
        }

        // POST: PharmBatches/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(long id)
        //{
        //    var pharmBatch = await repository.AllBatches.SingleOrDefaultAsync(m => m.BatchId == id);
            //_context.PharmBatch.Remove(pharmBatch);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
        //}

        private bool PharmBatchExists(long id)
        {
            return repository.AllBatches.Any(e => e.BatchId == id);
        }
    }
}
