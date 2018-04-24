using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class PharmScrubLog
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public long ScrubLogId { get; set; }
        [Required]
        public long BatchId { get; set; }
        [Required]
        public Int16 SourceId { get; set; }
        [Required]
        public string ClaimId { get; set; }
        public Int16 ClaimLineSeq { get; set; }
        [Required]
        public int ScrubConfigId { get; set; }
    }
}
