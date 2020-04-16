using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwContractsLocations
    {
        public int? IdPristav { get; set; }
        public string Location { get; set; }
        public string LocationAddress { get; set; }
        public string LawyerAddress { get; set; }
        public string DocketAddress { get; set; }
        public string OriginalIlAdress { get; set; }
        public string PtsAddress { get; set; }
    }
}
