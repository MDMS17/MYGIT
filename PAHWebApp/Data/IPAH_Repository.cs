using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAHWebApp.Models;

namespace PAHWebApp.Data
{
    public interface IPah_Repository
    {
        IQueryable<PharmSchedule> AllSchedules { get; }
        Task SaveSchedule(PharmSchedule schedule);
        IQueryable<ScheduleStatus> ScheduleStatuses { get; }
        IQueryable<PharmBatch> AllBatches { get; }
        Task SaveBatch(PharmBatch batch);
        IQueryable<BatchStatus> BatchStatuses { get; }
        Task<List<PharmBatch>> ListBatchesAsync();
        Task<List<PharmScrubLog>> ListAsync();
    }
}
