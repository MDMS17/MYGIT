using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PAHWebApp.Models;

namespace PAHWebApp.Data
{
    public class Pah_Repository : IPah_Repository 
    {
        private PAHDbContext context;
        public Pah_Repository(PAHDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<PharmSchedule> AllSchedules => context.PharmSchedule;
        public async Task SaveSchedule(PharmSchedule schedule)
        {
            PharmSchedule sch = await context.PharmSchedule.FirstOrDefaultAsync(x => x.ScheduleId == schedule.ScheduleId);
            if (sch == null)
            {
                context.PharmSchedule.Add(schedule);
            }
            else
            {
                sch.ScheduleStatusId = schedule.ScheduleStatusId;
            }
            await context.SaveChangesAsync();
        }
        public IQueryable<ScheduleStatus> ScheduleStatuses => context.ScheduleStatus;
        public IQueryable<PharmBatch> AllBatches => context.PharmBatch;
        public async Task SaveBatch(PharmBatch batch)
        {
            PharmBatch bch = await context.PharmBatch.FirstOrDefaultAsync(x => x.BatchId == batch.BatchId);
            if (bch == null)
            {
                context.PharmBatch.Add(bch);
            }
            else
            {
                bch.BatchStatusId = batch.BatchStatusId;
            }
            await context.SaveChangesAsync();
        }
        public IQueryable<BatchStatus> BatchStatuses => context.BatchStatus;
        public async Task<List<PharmBatch>> ListBatchesAsync()
        {
            return await context.PharmBatch.ToListAsync();
        }
        public async Task<List<PharmScrubLog>> ListAsync()
        {
            return await context.PharmScrubLog.ToListAsync();
        }
    }
}
