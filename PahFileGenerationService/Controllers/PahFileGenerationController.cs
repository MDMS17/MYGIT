using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PAHWebApp.Data;
using PAHWebApp.Models;

namespace PahFileGenerationService.Controllers
{
    [Produces("application/json")]
    [Route("api/PahFileGeneration")]
    public class PahFileGenerationController : Controller
    {
        private readonly PAHDbContext _context;

        public PahFileGenerationController(PAHDbContext context)
        {
            _context = context;
        }
        [HttpGet("GenerateFile/{id}")]
        public async Task<IEnumerable<string>> GenerateFiles([FromRoute] int scheduleId)
        {
            List<PharmBatch> batches = await _context.PharmBatch.Where(x => x.ScheduleId == scheduleId).ToListAsync();
            foreach (PharmBatch batch in batches)
            {
                PharmHeader header = await _context.PharmHeader.FirstOrDefaultAsync(x => x.BatchId == batch.BatchId);
                if (header == null) continue;
                ExportHeader(ref header);
                List<PharmDE> details = await _context.PharmDE.Where(x => x.BatchId == batch.BatchId).ToListAsync();
                if (details.Count() == 0) continue;

                foreach (PharmDE detail in details)
                {
                    PharmDE refDetail = detail;
                    ExportDetail(ref refDetail);
                    PharmCD1 compound1 = await _context.PharmCD1.FirstOrDefaultAsync(x => x.DetailID == detail.DetailID);
                    if (compound1 != null)
                    {
                        ExportCompound1(ref compound1);
                        PharmCD2 compound2 = await _context.PharmCD2.FirstOrDefaultAsync(x => x.DetailID == detail.DetailID);
                        if (compound2 != null)
                        {
                            ExportCompound2(ref compound2);
                        }
                    }
                }
                ExportTrailer(ref header);

            }
            return new string[] { "pharmacy", "file generation complete" };

        }
        // GET: api/PahFileGeneration
        [HttpGet]
        public IEnumerable<PharmDE> GetPharmDE()
        {
            return _context.PharmDE;
        }

        // GET: api/PahFileGeneration/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPharmDE([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pharmDE = await _context.PharmDE.SingleOrDefaultAsync(m => m.DetailID == id);

            if (pharmDE == null)
            {
                return NotFound();
            }

            return Ok(pharmDE);
        }

        // PUT: api/PahFileGeneration/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPharmDE([FromRoute] int id, [FromBody] PharmDE pharmDE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pharmDE.DetailID)
            {
                return BadRequest();
            }

            _context.Entry(pharmDE).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PharmDEExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PahFileGeneration
        [HttpPost]
        public async Task<IActionResult> PostPharmDE([FromBody] PharmDE pharmDE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PharmDE.Add(pharmDE);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPharmDE", new { id = pharmDE.DetailID }, pharmDE);
        }

        // DELETE: api/PahFileGeneration/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePharmDE([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pharmDE = await _context.PharmDE.SingleOrDefaultAsync(m => m.DetailID == id);
            if (pharmDE == null)
            {
                return NotFound();
            }

            _context.PharmDE.Remove(pharmDE);
            await _context.SaveChangesAsync();

            return Ok(pharmDE);
        }

        private bool PharmDEExists(int id)
        {
            return _context.PharmDE.Any(e => e.DetailID == id);
        }
        private void ExportHeader(ref PharmHeader header)
        {

        }
        private void ExportDetail(ref PharmDE detail)
        {
        }
        private void ExportCompound1(ref PharmCD1 compound1)
        {
        }
        private void ExportCompound2(ref PharmCD2 compound2)
        {
        }
        private void ExportTrailer(ref PharmHeader header)
        {
        }
    }
}