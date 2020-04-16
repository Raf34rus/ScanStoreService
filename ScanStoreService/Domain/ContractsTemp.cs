using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractsTemp
    {
        public int Id { get; set; }
        public Guid? IdSess { get; set; }
        public int? IdHkd { get; set; }
    }
}
