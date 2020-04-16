using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class HkdScans
    {
        public string Path { get; set; }
        public string Keeper { get; set; }
        public string City { get; set; }
        public string Party { get; set; }
        public string Box { get; set; }
        public string Folder { get; set; }
        public string FileName { get; set; }
        public int? IdNrs { get; set; }
        public int? IdPristav { get; set; }
        public int? IdPartInfo { get; set; }
        public string ScanType { get; set; }
        public int ScanTypeId { get; set; }
        public string Id { get; set; }
        public DateTime DateLastUpdate { get; set; }
    }
}
