using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractRequestBitSendLog
    {
        public long Id { get; set; }
        public int RequestId { get; set; }
        public DateTime DateSend { get; set; }
        public bool StatusSend { get; set; }
        public int HtmlCode { get; set; }
        public string Responce { get; set; }

        public virtual ContractRequess Request { get; set; }
    }
}
