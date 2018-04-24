using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PAHWebApp.Data;
using PAHWebApp.Models;

namespace PAHWebApp.Services
{
    public class PahOptionsService
    {
        private IPah_Repository repository;
        public PahOptionsService(IPah_Repository repo)
        {
            repository = repo;
        }
        public List<ScheduleStatus> ListScheduleStatuses()
        {
            ScheduleStatus emptyScheduleStatus = new ScheduleStatus();
            emptyScheduleStatus.ScheduleStatusId = 0;
            emptyScheduleStatus.ScheduleStatusName = "Select Schedule Status";
            List<ScheduleStatus> listScheduleStatus = repository.ScheduleStatuses.OrderBy(x => x.ScheduleStatusName).ToList();
            listScheduleStatus.Insert(0, emptyScheduleStatus);
            return listScheduleStatus;
        }
        public List<BatchStatus> ListBatchStatuses()
        {
            BatchStatus emptyBatchStatus = new BatchStatus();
            emptyBatchStatus.BatchStatusId = 0;
            emptyBatchStatus.BatchStatusName = "Select Batch Status";
            List<BatchStatus> listBatchStatus = repository.BatchStatuses.OrderBy(x => x.BatchStatusName).ToList();
            listBatchStatus.Insert(0, emptyBatchStatus);
            return listBatchStatus;
        }
    }
}
