using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class ScheduleStatus
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public int ScheduleStatusId { get; set; }
        public string ScheduleStatusName { get; set; }
        public string ScheduleStatusDescription { get; set; }
    }
}
