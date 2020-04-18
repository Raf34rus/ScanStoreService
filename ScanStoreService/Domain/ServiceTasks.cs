using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ServiceTasks
    {
        public ServiceTasks()
        {
            LogInsContractScans = new HashSet<LogInsContractScans>();
            LogInsContracts = new HashSet<LogInsContracts>();
            LogInsRequests = new HashSet<LogInsRequests>();
            LogUpdContractAssign = new HashSet<LogUpdContractAssign>();
            LogUpdContractScansLocations = new HashSet<LogUpdContractScansLocations>();
            LogUpdRequests = new HashSet<LogUpdRequests>();
        }

        public int Id { get; set; }
        public int TypeTask { get; set; }
        public int? TypeInFile { get; set; }
        public int? TypeOutFile { get; set; }
        public string PathInFile { get; set; }
        public string PathOutFile { get; set; }
        public int? TypeStatus { get; set; }
        public string ResponceMessage { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
        public string UserFileName { get; set; }
        public string ParamTask { get; set; }

        public virtual ServiceTasksStatusesTask TypeStatusNavigation { get; set; }
        public virtual ServiceTasksTypesTask TypeTaskNavigation { get; set; }
        public virtual ICollection<LogInsContractScans> LogInsContractScans { get; set; }
        public virtual ICollection<LogInsContracts> LogInsContracts { get; set; }
        public virtual ICollection<LogInsRequests> LogInsRequests { get; set; }
        public virtual ICollection<LogUpdContractAssign> LogUpdContractAssign { get; set; }
        public virtual ICollection<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
        public virtual ICollection<LogUpdRequests> LogUpdRequests { get; set; }
    }
}
