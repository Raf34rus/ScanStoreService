using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class AdUsers
    {
        public int Id { get; set; }
        public string Pristav { get; set; }
        public string Fio { get; set; }
        public string Email { get; set; }
    }
}
