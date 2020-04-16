using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class HkdScansIlExists
    {
        public Guid? ScanId { get; set; }
        public int IdHkd { get; set; }
        public long IdPkb { get; set; }
        public int? CsType { get; set; }
        public int? IdPristav { get; set; }
        public string Hash { get; set; }
        public string Path { get; set; }
        public string ExistDoc { get; set; }
        public string Status { get; set; }
    }
}
