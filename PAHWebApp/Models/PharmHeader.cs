﻿namespace PAHWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PharmHeader
    {
        [Key]
        public int FileID { get; set; }
        public string RecordType { get; set; }
        public string VersionReleaseNumber { get; set; }
        public string SenderID { get; set; }
        public string BatchNumber { get; set; }
        public string CreationDate { get; set; }
        public string CreationTime { get; set; }
        public string ReceiverID { get; set; }
        public string ReportStartDate { get; set; }
        public string ReportEndDate { get; set; }
        public string FileType { get; set; }
        public string TransmissionAction { get; set; }
        public string SubmissionNumber { get; set; }
        public string FilePath { get; set; }
        public string Total_Record_Count { get; set; }
        public string Total_Net_Amount_Due { get; set; }
        public string Total_Gross_Amount_Due { get; set; }
        public string Total_Patient_Pay_Amount { get; set; }
        public long BatchId { get; set; }
        public byte SourceId { get; set; }
        public Nullable<System.DateTime> AddedDate { get; set; }

        public virtual ICollection<PharmDE> PharmDEs { get; set; }
    }
}

