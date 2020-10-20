using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ScanStoreService.Features.BitRequests
{
    class BitFiles
    {
        public string id_scan { get; }
        public int id_hkd { get; }
        public string path { get; }
        public int csType { get; }
        public BitFiles()
        {
            id_scan = String.Empty;
            id_hkd = 0;
            path = String.Empty;
            csType = 0;
        }
        public BitFiles(Domain.ContractScans contractScans)
        {
            id_scan = contractScans.Id.ToString();
            id_hkd = (int)contractScans.ContractId;
            path = contractScans.Path;
            csType = contractScans.CsType;
        }
    }


    public class ResponceBit
    {
        public HttpStatusCode code;
        public string body;
        public ResponceBit()
        {
            code = HttpStatusCode.Unused;
            body = "";
        }
    }
}
