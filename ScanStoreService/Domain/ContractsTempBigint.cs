using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractsTempBigint
    {
        public int Id { get; set; }
        public Guid? IdSess { get; set; }
        public long? IdHkd { get; set; }
    }
}
