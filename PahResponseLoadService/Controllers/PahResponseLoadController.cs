using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PAHWebApp.Data;
using PAHWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace PahResponseLoadService.Controllers
{
    [Produces("application/json")]
    [Route("api/PahResponseLoad")]
    public class  PahResponseLoadService : Controller 
    {
        private readonly PAHDbContext _context;
        public PahResponseLoadService(PAHDbContext ctx)
        {
            _context = ctx;
        }
        [HttpGet("ResponseLoad/{id}")]
        public async Task<IEnumerable<string>> LoadResponse([FromRoute] int batchFileId)
        {
            PharmResponse response = await _context.PharmResponse.FirstOrDefaultAsync(x => x.BatchFileId == batchFileId);
            ProcessResponseFile(response);
            return new string[] { "pharmacy", "response load complete" };
        }

        private void ProcessResponseFile(PharmResponse response)
        {
        }
    }
}
