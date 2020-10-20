using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Features.ContractScans
{
    public class ContractScansEnvelope
    {
        public List<ContractScan> ContractScans { get; set; }

        public int ContractScansCount { get; set; }
    }
}
