﻿using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractRequess
    {
        public ContractRequess()
        {
            ContractRequestBitSendLog = new HashSet<ContractRequestBitSendLog>();
            ContractsInRequest = new HashSet<ContractsInRequest>();
            FastRequess = new HashSet<FastRequess>();
        }

        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestComment { get; set; }
        public string RequestUser { get; set; }
        public DateTime? FinishDate { get; set; }
        public string FinishedUser { get; set; }
        public string WorkoutUser { get; set; }
        public DateTime? WorkoutDate { get; set; }
        public string ArchivistComment { get; set; }
        public bool IsUrgent { get; set; }
        public int? ContractId { get; set; }
        public string Category { get; set; }
        public string IdBit { get; set; }
        public string RequestUserFio { get; set; }
        public int ReqType { get; set; }
        public int ReqComment { get; set; }
        public int ReqStatus { get; set; }
        public int? AddressToIl { get; set; }
        public int? UserFinished { get; set; }
        public int? UserCreate { get; set; }
        public bool SetPasport { get; set; }
        public bool SetForm { get; set; }
        public bool SetGraph { get; set; }

        public virtual OfficeAddress AddressToIlNavigation { get; set; }
        public virtual Contracts Contract { get; set; }
        public virtual ContractRequestCommentType ReqCommentNavigation { get; set; }
        public virtual ContractRequestStatuses ReqStatusNavigation { get; set; }
        public virtual ContractRequestTypes ReqTypeNavigation { get; set; }
        public virtual ICollection<ContractRequestBitSendLog> ContractRequestBitSendLog { get; set; }
        public virtual ICollection<ContractsInRequest> ContractsInRequest { get; set; }
        public virtual ICollection<FastRequess> FastRequess { get; set; }
    }
}
