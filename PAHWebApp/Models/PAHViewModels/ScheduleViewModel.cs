using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAHWebApp.Models.PAHViewModels
{
    public class ScheduleViewModel
    {
        public IEnumerable<PharmSchedule> Schedules { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentScheduleStatus { get; set; }
    }
}
