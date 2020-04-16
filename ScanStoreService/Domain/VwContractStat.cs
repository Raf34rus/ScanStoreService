using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwContractStat
    {
        public DateTime DataRequest { get; set; }
        public int IdRequest { get; set; }
        public string Partner { get; set; }
        public string Cession { get; set; }
        public DateTime DataCession { get; set; }
        public string FioDoljnika { get; set; }
        public string NumderContract { get; set; }
        public int IdHkd { get; set; }
        public long IdPkb { get; set; }
        public int? IdPristav { get; set; }
        public DateTime? DataContract { get; set; }
        public string Userfio { get; set; }
        public string StatusRequest { get; set; }
        public string Comment { get; set; }
        public DateTime? DataEnd { get; set; }
        public string Ispolnitel { get; set; }
        public string CommentArhiv { get; set; }
        public string Keeper { get; set; }
        public string Mestopolojenie { get; set; }
        public string RequestLawers { get; set; }
        public int? CountScanContracts { get; set; }
        public int? CountScanSud { get; set; }
        public int? CountScanPts { get; set; }
        public int? CountScanVipiska { get; set; }
        public int? CountScanIl { get; set; }
        public string TypeRequest { get; set; }
        public double? Summ { get; set; }
        public string Prosujen { get; set; }
        public string Avtokredit { get; set; }
        public string Pereustup { get; set; }
        public int ReqType { get; set; }
        public int ReqStatus { get; set; }
        public string WorkoutUser { get; set; }
        public DateTime? WorkoutDate { get; set; }
        public string LocationAddress { get; set; }
        public string LawyerAddress { get; set; }
        public string PtsAddress { get; set; }
        public string OriginalIlAdress { get; set; }
        public string IsBit { get; set; }
    }
}
