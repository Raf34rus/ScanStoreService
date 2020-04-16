using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class LoadedContractWithScans
    {
        public string НаименованиеПартнера { get; set; }
        public string НомерДоговораЦессии { get; set; }
        public DateTime ДатаДоговораЦессии { get; set; }
        public int? КоличествоКдВнесенныхВХкд { get; set; }
        public int? КоличествоСканКопийВХкд { get; set; }
    }
}
