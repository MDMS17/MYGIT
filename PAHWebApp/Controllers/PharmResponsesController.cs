using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PAHWebApp.Data;
using PAHWebApp.Models;
using PAHWebApp.Services;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace PAHWebApp.Controllers
{
    public class PharmResponsesController : Controller
    {
        private readonly PAHDbContext _context;
        private readonly IOptions<ServiceUrl> _config;

        public PharmResponsesController(PAHDbContext context, IOptions<ServiceUrl> config)
        {
            _context = context;
            _config = config;
        }

        // GET: PharmResponses
        public async Task<IActionResult> Index()
        {
            return View(await _context.PharmResponse.ToListAsync());
        }

        // GET: PharmResponses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmResponse = await _context.PharmResponse
                .SingleOrDefaultAsync(m => m.BatchFileId == id);
            if (pharmResponse == null)
            {
                return NotFound();
            }

            return View(pharmResponse);
        }

        // GET: PharmResponses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PharmResponses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ModifiedUserId,ModifiedDateTime,BatchFileId,BatchId,BatchFileStatusId,FileCode,FileName,FilePath,FileCreateDate,FormTypeId,ClaimCount,TotalCharge,TotalPaid,FileSubmissionMode,ResponseFileId,ResponseFileTypeId,ResponseFileLoadStatus,ResponseFileLoadDate,MarketId,ResponseFilePath,ResponseFileName,ResponseFileStatusId,InterchangeSenderId,InterchangeDate,ErrorFilePath,ErrorMessage,ResponseFileSizeInMB,IsDeleted,IsPurge,ResponseMessage")] PharmResponse pharmResponse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pharmResponse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pharmResponse);
        }

        // GET: PharmResponses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmResponse = await _context.PharmResponse.SingleOrDefaultAsync(m => m.BatchFileId == id);
            if (pharmResponse == null)
            {
                return NotFound();
            }
            return View(pharmResponse);
        }

        // POST: PharmResponses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ModifiedUserId,ModifiedDateTime,BatchFileId,BatchId,BatchFileStatusId,FileCode,FileName,FilePath,FileCreateDate,FormTypeId,ClaimCount,TotalCharge,TotalPaid,FileSubmissionMode,ResponseFileId,ResponseFileTypeId,ResponseFileLoadStatus,ResponseFileLoadDate,MarketId,ResponseFilePath,ResponseFileName,ResponseFileStatusId,InterchangeSenderId,InterchangeDate,ErrorFilePath,ErrorMessage,ResponseFileSizeInMB,IsDeleted,IsPurge,ResponseMessage")] PharmResponse pharmResponse)
        {
            if (id != pharmResponse.BatchFileId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pharmResponse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PharmResponseExists(pharmResponse.BatchFileId))
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
            return View(pharmResponse);
        }

        // GET: PharmResponses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pharmResponse = await _context.PharmResponse
                .SingleOrDefaultAsync(m => m.BatchFileId == id);
            if (pharmResponse == null)
            {
                return NotFound();
            }

            return View(pharmResponse);
        }

        // POST: PharmResponses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pharmResponse = await _context.PharmResponse.SingleOrDefaultAsync(m => m.BatchFileId == id);
            _context.PharmResponse.Remove(pharmResponse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PharmResponseExists(int id)
        {
            return _context.PharmResponse.Any(e => e.BatchFileId == id);
        }
        [HttpPost, ActionName("Load")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Load(int? id)
        {
            HttpClient client = new HttpClient();
            ServiceUrl urls = _config.Value;
            client.BaseAddress = new Uri(urls.ResponseLoadServiceUrl);
            string apiUrl = "api/PahResponseLoad/ResponseLoad/" + id.ToString();
            await client.GetAsync(apiUrl);
            return RedirectToAction(nameof(Index));
        }

    }
}
