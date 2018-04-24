using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PAHWebApp.Models
{
    public class SystemConfiguration
    {
        [Required]
        public string ModifiedUserId { get; set; }
        [Required]
        public DateTime ModifiedDateTime { get; set; }
        [Key]
        public int ConfigurationId { get; set; }
        [Required]
        public int ConfigurationTypeId { get; set; }
        [Required]
        public string ConfigurationName { get; set; }
        [Required]
        public string ConfigurationValue { get; set; }
        [Required]
        public string ConfigurationText { get; set; }
    }
}
