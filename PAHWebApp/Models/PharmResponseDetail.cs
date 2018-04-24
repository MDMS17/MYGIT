using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class PharmResponseDetail
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public int BatchFileResponseDetailId { get; set; }
        [Required]
        public int BatchFileId { get; set; }
        public string TsnNbr { get; set; }
        public string TsnSts { get; set; }
        public string PatAcct { get; set; }
        public Int16 SubmitTypeId { get; set; }
        public string ClaimId { get; set; }
        public Int16 ClaimLineSeq { get; set; }
        public virtual PharmResponse PharmResponse { get; set; }
    }
}
