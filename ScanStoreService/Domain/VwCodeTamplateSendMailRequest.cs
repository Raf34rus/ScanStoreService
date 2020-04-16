using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwCodeTamplateSendMailRequest
    {
        public int Id { get; set; }
        public int ContractRequessId { get; set; }
        public int OutsideRequessId { get; set; }
        public string ArchivistComment { get; set; }
        public string RequestComment { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestType { get; set; }
        public string Status { get; set; }
        public int IdHkd { get; set; }
        public string LocationAddress { get; set; }
        public string DebtorFio { get; set; }
        public string DebtNumber { get; set; }
        public DateTime CessionDate { get; set; }
        public string CessionNum { get; set; }
        public string PartnerName { get; set; }
        public string Location { get; set; }
        public string RequestUser { get; set; }
        public string RequestUserFio { get; set; }
        public string LawyerAddress { get; set; }
        public string DocketAddress { get; set; }
        public string OriginalIlAdress { get; set; }
        public string PtsAddress { get; set; }
        public string IsCopy { get; set; }
    }
}
