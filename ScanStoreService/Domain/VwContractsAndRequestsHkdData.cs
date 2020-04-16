using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwContractsAndRequestsHkdData
    {
        public long? RowId { get; set; }
        public string PartnerName { get; set; }
        public string CessName { get; set; }
        public DateTime? DateCess { get; set; }
        public int? VsegoKupleno { get; set; }
        public int? VsegoPeredano { get; set; }
        public int? SkanVHkd { get; set; }
        public int? NeZalitHkd { get; set; }
        public int? VsegoNePeredano { get; set; }
        public int? DosUPartn { get; set; }
        public int? Otsutstv { get; set; }
        public int? Prodaja { get; set; }
        public int? KolichZaprosOjid { get; set; }
        public int? DosPredost { get; set; }
        public int? DosUPart { get; set; }
        public int? SumFtp { get; set; }
        public int? ReqFtp { get; set; }
        public int? SumIronmountan { get; set; }
        public int? ReqIronMountain { get; set; }
        public int? SumOrb { get; set; }
        public int? ReqOrb { get; set; }
        public int? SumInfolog { get; set; }
        public int? ReqInfolog { get; set; }
        public int? SumDigitscan { get; set; }
        public int? ReqDigitscan { get; set; }
        public int? SumRaiswolf { get; set; }
        public int? ReqRaiswolf { get; set; }
        public int? SumPkb { get; set; }
        public int? ReqPkb { get; set; }
        public int? InRoud { get; set; }
        public int? ReqInRoad { get; set; }
    }
}
