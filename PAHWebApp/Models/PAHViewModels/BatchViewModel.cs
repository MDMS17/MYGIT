using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAHWebApp.Models.PAHViewModels
{
    public class BatchViewModel
    {
        public IEnumerable<PharmBatch> Batches { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentBatchStatus { get; set; }
    }
}
