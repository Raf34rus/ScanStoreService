using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class CBit
    {
        public int? Number { get; set; }
        public DateTime? Date { get; set; }
        public int? NumberRow { get; set; }
        public string Object { get; set; }
        public string Path { get; set; }
        public long? IdPkb { get; set; }
        public int? ReqType { get; set; }
    }
}
