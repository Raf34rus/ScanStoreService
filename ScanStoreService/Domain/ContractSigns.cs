using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class ContractSigns
    {
        public ContractSigns()
        {
            ContractsAuditingNavigation = new HashSet<Contracts>();
            ContractsAvtocreditNavigation = new HashSet<Contracts>();
            ContractsIsAssigmentNavigation = new HashSet<Contracts>();
        }

        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Contracts> ContractsAuditingNavigation { get; set; }
        public virtual ICollection<Contracts> ContractsAvtocreditNavigation { get; set; }
        public virtual ICollection<Contracts> ContractsIsAssigmentNavigation { get; set; }
    }
}
