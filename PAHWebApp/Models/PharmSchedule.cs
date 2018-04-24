using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class PharmSchedule
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public int ScheduleId { get; set;}
        [Required]
        public byte MarketId { get; set; }
        [Required]
        public byte ScheduleTypeId { get; set; }
        [Required]
        public string ScheduleName { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public bool IsPreAdjudicated { get; set; }
        public bool IsScrubEnabled { get; set; }
        public int ScheduleStatusId { get; set; }
        public int? Count { get; set; }
        [Required]
        public int SourceTypeId { get; set; }
        [Required]
        public bool IsResubmit { get; set; }
        [Required]
        public bool IsForceVoid { get; set; }
        [Required]
        public bool IsAutoGenerateFile { get; set; }
        public string ScheduleError { get; set; }
    }
}
