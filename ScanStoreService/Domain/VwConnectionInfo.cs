using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwConnectionInfo
    {
        public int? Spid { get; set; }
        public string IpКлиента { get; set; }
        public string ИмяPcКлиента { get; set; }
        public string IpПодключенияКСерверу { get; set; }
        public string ПротоколПодключения { get; set; }
        public int? Порт { get; set; }
        public string ИмяПрограммы { get; set; }
        public string Loginame { get; set; }
    }
}
