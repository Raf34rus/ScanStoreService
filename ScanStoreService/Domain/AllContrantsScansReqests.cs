using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class AllContrantsScansReqests
    {
        public int Id { get; set; }
        public string DebtNumber { get; set; }
        public string DebtorFio { get; set; }
        public DateTime? DebtDate { get; set; }
        public string Location { get; set; }
        public int? CessionId { get; set; }
        public Guid? ScanId { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }
        public string FileName { get; set; }
        public long? Size { get; set; }
        public int? RequestDate { get; set; }
        public string RequestComment { get; set; }
        public string RequestUser { get; set; }
        public DateTime? FinishDate { get; set; }
        public string FinishedUser { get; set; }
        public int? ReqStatus { get; set; }
        public string WorkoutUser { get; set; }
        public DateTime? WorkoutDate { get; set; }
        public string ArchivistComment { get; set; }
        public bool? IsUrgent { get; set; }
        public string CessionName { get; set; }
        public DateTime? CessionDate { get; set; }
        public int? PartnerId { get; set; }
    }
}
