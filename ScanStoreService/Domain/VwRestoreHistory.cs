using System;
using System.Collections.Generic;

namespace ScanStoreService.Domain
{
    public partial class VwRestoreHistory
    {
        public DateTime? RestoreDate { get; set; }
        public string RestoreType { get; set; }
        public string DestinationDb { get; set; }
        public string RestoredBy { get; set; }
        public string BackupDevice { get; set; }
        public string DeviceType { get; set; }
        public string BackupsetName { get; set; }
        public string BackupsetDesc { get; set; }
        public string BackupType { get; set; }
        public decimal? BackupSizeMb { get; set; }
        public decimal? BackupSizeCompressedMb { get; set; }
        public decimal? Compression { get; set; }
        public string SourceSql { get; set; }
        public string SqlVersion { get; set; }
        public string SourceDbSdb { get; set; }
        public DateTime? SdbCreated { get; set; }
        public byte? SdbCompLevel { get; set; }
        public string SdbCollation { get; set; }
        public string SdbRecovery { get; set; }
        public string BackupMadeBy { get; set; }
        public DateTime? BackupStarted { get; set; }
        public DateTime? BackupFinished { get; set; }
        public decimal? DatabaseBackupLsn { get; set; }
        public decimal? FirstLsn { get; set; }
        public decimal? LastLsn { get; set; }
        public decimal? CheckpointLsn { get; set; }
        public bool? WithReplace { get; set; }
        public bool? WithRecovery { get; set; }
        public DateTime? StopAt { get; set; }
        public string StopAtMarkName { get; set; }
        public bool? StopBefore { get; set; }
    }
}
