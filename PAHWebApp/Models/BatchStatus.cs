using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class BatchStatus
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public byte BatchStatusId { get; set; }
        [Required]
        public string BatchStatusName { get; set; }
        public string BatchStatusDesc { get; set; }
        public bool IsActive { get; set; }
    }
}
