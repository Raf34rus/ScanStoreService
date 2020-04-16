﻿using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class OutsideRequess
    {
        public OutsideRequess()
        {
            ContractsInRequest = new HashSet<ContractsInRequest>();
        }

        public int Id { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ReportName { get; set; }
        public string Path { get; set; }
        public int? TemplateId { get; set; }
        public string UserSend { get; set; }
        public DateTime? SendDate { get; set; }
        public string SubjectMsg { get; set; }
        public string SendTo { get; set; }
        public string MsgBody { get; set; }
        public int StatusId { get; set; }

        public virtual Templates Template { get; set; }
        public virtual ICollection<ContractsInRequest> ContractsInRequest { get; set; }
    }
}
