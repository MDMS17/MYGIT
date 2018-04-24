using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class PharmBatch
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public long BatchId { get; set; }
        [Required]
        public byte MarketId { get; set; }
        [Required]
        public int ScheduleId { get; set; }
        public byte BatchStatusId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime RangeStartDOS { get; set; }
        public DateTime RangeEndDOS { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StagingStartDate { get; set; }
        public DateTime StagingEndDate { get; set; }
        public DateTime BusinessUpdateStartDate { get; set; }
        public DateTime BusinessUpdateEndDate { get; set; }
        public DateTime ScrubStartDate { get; set; }
        public DateTime ScrubEndDate { get; set; }
        public int StagingClaimCount { get; set; }
        public int ProcessedClaimCount { get; set; }
        public int ScrubClaimCount { get; set; }
        public int SubmittedClaimCount { get; set; }
        public int StagingErrorCount { get; set; }
        public int BusinessUpdateErrorCount { get; set; }
        public int ScrubErrorCount { get; set; }
        public int FileGenerationErrorCount { get; set; }
        public bool IsPreAdjudicated { get; set; }
        public bool IsScrubEnabled { get; set; }
        public DateTime PurgeDate { get; set; }
        public string BatchMessage { get; set; }
        [Required ]
        public bool IsFailed { get; set; }
        [Required ]
        public string IsExportComplete { get; set; }
        [Required ]
        public int StagingPartitionKey { get; set; }
        [Required ]
        public int CachePartitionKey { get; set; }
        [Required]
        public bool IsParsed { get; set; }
        public decimal ClmChargeAmt { get; set; }
        public decimal ClmPatPaidAmt { get; set; }
        public decimal ScrubbedClmChargeAmt { get; set; }
        public decimal ScrubbedClmPatPaidAmt { get; set; }
        public string BatchProcessTime { get; set; }
}
}
