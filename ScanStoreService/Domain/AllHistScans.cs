using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class AllHistScans
    {
        public DateTime Time { get; set; }
        public string ScanAndContract { get; set; }
        public string Username { get; set; }
        public string Filename { get; set; }
        public string Docnumber { get; set; }
    }
}
