using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class PharmResponse
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public int BatchFileId { get; set; }
        [Required]
        public long BatchId { get; set; }
        public Int16 BatchFileStatusId { get; set; }
        public string FileCode { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime FileCreateDate { get; set; }
        public Int16 FormTypeId { get; set; }
        public int ClaimCount { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal TotalPaid { get; set; }
        public string FileSubmissionMode { get; set; }
        [Required]
        public long ResponseFileId { get; set; }
        [Required]
        public Int16 ResponseFileTypeId { get; set; }
        [Required]
        public bool ResponseFileLoadStatus { get; set; }
        [Required]
        public DateTime ResponseFileLoadDate { get; set; }
        [Required]
        public Int16 MarketId { get; set; }
        public string ResponseFilePath { get; set; }
        public string ResponseFileName { get; set; }
        public int ResponseFileStatusId { get; set; }
        public string InterchangeSenderId { get; set; }
        public DateTime InterchangeDate { get; set; }
        public string ErrorFilePath { get; set; }
        public string ErrorMessage { get; set; }
        public decimal ResponseFileSizeInMB { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public bool IsPurge { get; set; }
        public string ResponseMessage { get; set; }
        public virtual ICollection<PharmResponseDetail> PharmResponseDetails { get; set; }
    }
}
