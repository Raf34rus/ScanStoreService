using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Domain
{
    public partial class ContractRequess
    {
        public ContractRequess(BitRequest bitRequest, int contractId, int reqType) :base()
        {
            RequestUser = "From1cBIT";
            RequestUserFio = bitRequest.Fio;
            RequestDate = DateTime.Now;
            IsUrgent = true;
            ReqStatus = 3; //генерирование статуса основываясь на её местоположении
            IdBit = bitRequest.IdBit;
            RequestComment = "";
            ReqType = reqType; 
            ReqComment = 1;
            ContractId = contractId;
            ArchivistComment = "";
        }
    }
}