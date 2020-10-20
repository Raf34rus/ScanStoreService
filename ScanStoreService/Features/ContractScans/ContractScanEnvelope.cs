using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScanStoreService.Domain;

namespace ScanStoreService.Features.ContractScans
{
    public class ContractScan
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public long? Size { get; set; }
        public int? ContractId { get; set; }
        public DateTime? InsertDate { get; set; }
        public int CsType { get; set; }
        public string HashFile { get; set; }
        public DateTime DateLastUpdate { get; set; }
        public byte ExistDocument { get; set; }
        public DateTime? InsertDateScan { get; set; }
        public string Address { get; set; }
        public string Keeper { get; set; }
        public string City { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
    }

    public class ContractScanEnvelope
    {
        public ContractScanEnvelope(ContractScan contractScan)
        {
            ContractScan = contractScan;
        }

        public ContractScan ContractScan;
    }
}
