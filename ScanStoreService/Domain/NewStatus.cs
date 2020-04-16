using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class NewStatus
    {
        public int? IdPristav { get; set; }
        public int? IdNrs { get; set; }
        public string IdPkb { get; set; }
        public short? IdStatus { get; set; }
        public double? Balance { get; set; }
    }
}
