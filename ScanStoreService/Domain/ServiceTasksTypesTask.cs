using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ServiceTasksTypesTask
    {
        public ServiceTasksTypesTask()
        {
            ServiceTasks = new HashSet<ServiceTasks>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ServiceTasks> ServiceTasks { get; set; }
    }
}
