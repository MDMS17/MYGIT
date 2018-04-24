using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAHWebApp.Models.PAHViewModels
{
    public class ReportViewModel
    {
        public IEnumerable<PharmScrubLog> Reports { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentReportType { get; set; }
    }
}
