using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ScanStoreService.Domain
{
    public partial class ScanStoreContext : DbContext
    {
        public ScanStoreContext()
        {

        }
        public ScanStoreContext(DbContextOptions<ScanStoreContext> options)
            : base(options)
        {
           
        }
        #region NewEntity
        //public virtual DbSet<BitRequestDetail> BitRequestDetails { get; set; }
        public virtual DbSet<BitRequest> BitRequests { get; set; }
        #endregion NewEntity

        #region OldEntity
        public virtual DbSet<Access> Access { get; set; }
        public virtual DbSet<Accs> Accs { get; set; }
        public virtual DbSet<AdUsers> AdUsers { get; set; }
        public virtual DbSet<AllCessions> AllCessions { get; set; }
        public virtual DbSet<AllContrantsScansReqests> AllContrantsScansReqests { get; set; }
        public virtual DbSet<AllHistScans> AllHistScans { get; set; }
        public virtual DbSet<BossCollector> BossCollector { get; set; }
        public virtual DbSet<C0nrsIds> C0nrsIds { get; set; }
        public virtual DbSet<CBit> CBit { get; set; }
        public virtual DbSet<CessionScans> CessionScans { get; set; }
        public virtual DbSet<Cessions> Cessions { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ContractLocations> ContractLocations { get; set; }
        public virtual DbSet<ContractRequess> ContractRequess { get; set; }
        public virtual DbSet<ContractRequestBitSendLog> ContractRequestBitSendLog { get; set; }
        public virtual DbSet<ContractRequestCommentType> ContractRequestCommentType { get; set; }
        public virtual DbSet<ContractRequestStatuses> ContractRequestStatuses { get; set; }
        public virtual DbSet<ContractRequestTypes> ContractRequestTypes { get; set; }
        public virtual DbSet<ContractRequestTypesStatusVisible> ContractRequestTypesStatusVisible { get; set; }
        public virtual DbSet<ContractScanExists> ContractScanExists { get; set; }
        public virtual DbSet<ContractScans> ContractScans { get; set; }
        public virtual DbSet<ContractScansDelete> ContractScansDelete { get; set; }
        public virtual DbSet<ContractScansOld> ContractScansOld { get; set; }
        public virtual DbSet<ContractSigns> ContractSigns { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<ContractsInRequest> ContractsInRequest { get; set; }
        public virtual DbSet<ContractsLocations> ContractsLocations { get; set; }
        public virtual DbSet<ContractsTemp> ContractsTemp { get; set; }
        public virtual DbSet<DebtWithHkdScans> DebtWithHkdScans { get; set; }
        public virtual DbSet<DelScans> DelScans { get; set; }
        public virtual DbSet<DocLinkFromNrs> DocLinkFromNrs { get; set; }
        public virtual DbSet<FastRequess> FastRequess { get; set; }
        public virtual DbSet<HkdScans> HkdScans { get; set; }
        public virtual DbSet<HkdScansIlExists> HkdScansIlExists { get; set; }
        public virtual DbSet<IdHkd> IdHkd { get; set; }
        public virtual DbSet<Kuznecova> Kuznecova { get; set; }
        public virtual DbSet<LoadedContractWithScans> LoadedContractWithScans { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogConverter> LogConverter { get; set; }
        public virtual DbSet<LogInsContractScans> LogInsContractScans { get; set; }
        public virtual DbSet<LogInsContractScansStatuses> LogInsContractScansStatuses { get; set; }
        public virtual DbSet<LogInsContracts> LogInsContracts { get; set; }
        public virtual DbSet<LogInsRequests> LogInsRequests { get; set; }
        public virtual DbSet<LogUpdContractAssign> LogUpdContractAssign { get; set; }
        public virtual DbSet<LogUpdContractScansLocations> LogUpdContractScansLocations { get; set; }
        public virtual DbSet<LogUpdRequests> LogUpdRequests { get; set; }
        public virtual DbSet<Migr2dwhDocsLoad> Migr2dwhDocsLoad { get; set; }
        public virtual DbSet<NewStatus> NewStatus { get; set; }
        public virtual DbSet<NrsIds> NrsIds { get; set; }
        public virtual DbSet<OfficeAddress> OfficeAddress { get; set; }
        public virtual DbSet<OfficeCity> OfficeCity { get; set; }
        public virtual DbSet<OldPathContractScans> OldPathContractScans { get; set; }
        public virtual DbSet<OutsideRequess> OutsideRequess { get; set; }
        public virtual DbSet<PartnerTemplates> PartnerTemplates { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<ReqArchComment> ReqArchComment { get; set; }
        public virtual DbSet<RequessReson> RequessReson { get; set; }
        public virtual DbSet<RequestOutParam> RequestOutParam { get; set; }
        public virtual DbSet<ScanCount> ScanCount { get; set; }
        public virtual DbSet<ScanList> ScanList { get; set; }
        public virtual DbSet<ServiceTasks> ServiceTasks { get; set; }
        public virtual DbSet<ServiceTasksStatusesTask> ServiceTasksStatusesTask { get; set; }
        public virtual DbSet<ServiceTasksTypesTask> ServiceTasksTypesTask { get; set; }
        public virtual DbSet<Status1cDescription> Status1cDescription { get; set; }
        public virtual DbSet<StatusesCopy> StatusesCopy { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        public virtual DbSet<VwCessionTree> VwCessionTree { get; set; }
        public virtual DbSet<VwCodeTamplateSendMailRequest> VwCodeTamplateSendMailRequest { get; set; }
        public virtual DbSet<VwConnectionInfo> VwConnectionInfo { get; set; }
        public virtual DbSet<VwContractFromCessions> VwContractFromCessions { get; set; }
        public virtual DbSet<VwContractScanFromContracts> VwContractScanFromContracts { get; set; }
        public virtual DbSet<VwContractStat> VwContractStat { get; set; }
        public virtual DbSet<VwContractsAndRequestsHkdData> VwContractsAndRequestsHkdData { get; set; }
        public virtual DbSet<VwContractsAndRequestsHkdDescr> VwContractsAndRequestsHkdDescr { get; set; }
        public virtual DbSet<VwContractsLocations> VwContractsLocations { get; set; }
        public virtual DbSet<VwRequestsExecutiveDocsSelect> VwRequestsExecutiveDocsSelect { get; set; }
        public virtual DbSet<VwRestoreHistory> VwRestoreHistory { get; set; }
        public virtual DbSet<VwScanStat> VwScanStat { get; set; }
        public virtual DbSet<VwStatisticRequest> VwStatisticRequest { get; set; }
        public virtual DbSet<ZdEaSubType> ZdEaSubType { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
#if DEBUG
                var connect = config["ConnectionStrings:DefaultConnectionTest"];
#else
                var connect = config["ConnectionStrings:DefaultConnectionWork"];
#endif
                optionsBuilder.UseSqlServer(connect); //("Server=Priserv8074;Database=ScanStoreRaf;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BitRequestsConfiguration());
            //modelBuilder.ApplyConfiguration(new BitRequestDetailsConfiguration());
            #region OldEntityConfiguration
            modelBuilder.Entity<Access>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lastaccess)
                    .HasColumnName("lastaccess")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Accs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("accs");

                entity.Property(e => e.FioAccount)
                    .HasColumnName("fio_account")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdUsers>(entity =>
            {
                entity.ToTable("AD_Users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(256);

                entity.Property(e => e.Pristav)
                    .IsRequired()
                    .HasColumnName("pristav")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<AllCessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all_cessions");

                entity.Property(e => e.CessionDate).HasColumnType("datetime");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.CessionName).IsRequired();

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.Property(e => e.PartnerName).IsRequired();
            });

            modelBuilder.Entity<AllContrantsScansReqests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all_Contrants_scans_reqests");

                entity.Property(e => e.ArchivistComment).HasColumnName("archivistComment");

                entity.Property(e => e.CessionDate)
                    .HasColumnName("cession_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.CessionName)
                    .HasColumnName("cession_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DebtDate)
                    .HasColumnName("debt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DebtNumber)
                    .HasColumnName("debt_number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.FinishDate)
                    .HasColumnName("finishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishedUser).HasColumnName("finishedUser");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsUrgent).HasColumnName("isUrgent");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.ReqStatus).HasColumnName("req_status");

                entity.Property(e => e.RequestComment).HasColumnName("requestComment");

                entity.Property(e => e.RequestDate).HasColumnName("requestDate");

                entity.Property(e => e.RequestUser).HasColumnName("requestUser");

                entity.Property(e => e.ScanId).HasColumnName("scan_id");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkoutDate)
                    .HasColumnName("workoutDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkoutUser).HasColumnName("workoutUser");
            });

            modelBuilder.Entity<AllHistScans>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("allHistScans");

                entity.HasIndex(e => e.Filename)
                    .HasName("NonClusteredIndex-20180703-022431");

                entity.Property(e => e.Docnumber)
                    .HasColumnName("docnumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScanAndContract)
                    .HasColumnName("scan_and_contract")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BossCollector>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BossName)
                    .HasColumnName("bossName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pristav)
                    .HasColumnName("pristav")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<C0nrsIds>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C$_0NRS_IDS", "exchange");

                entity.Property(e => e.C10CessionNumberDtIns)
                    .HasColumnName("C10_CESSION_NUMBER_DT_INS")
                    .HasColumnType("datetime");

                entity.Property(e => e.C11CessionContractDate)
                    .HasColumnName("C11_CESSION_CONTRACT_DATE")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.C12Status)
                    .HasColumnName("C12_STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.C13PortfolioName)
                    .HasColumnName("C13_PORTFOLIO_NAME")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.C1IdNrs).HasColumnName("C1_ID_NRS");

                entity.Property(e => e.C2IdPristav).HasColumnName("C2_ID_PRISTAV");

                entity.Property(e => e.C3Contract)
                    .HasColumnName("C3_CONTRACT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.C4CreditDate)
                    .HasColumnName("C4_CREDIT_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.C5IdPkb)
                    .HasColumnName("C5_ID_PKB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.C6Partner)
                    .HasColumnName("C6_PARTNER")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.C7Cession)
                    .HasColumnName("C7_CESSION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.C8IdClient).HasColumnName("C8_ID_CLIENT");

                entity.Property(e => e.C9PartnerDtIns)
                    .HasColumnName("C9_PARTNER_DT_INS")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CBit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("C_bit");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.NumberRow).HasColumnName("number_row");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.ReqType).HasColumnName("req_type");
            });

            modelBuilder.Entity<CessionScans>(entity =>
            {
                entity.ToTable("Cession_scans");

                entity.HasIndex(e => e.CessionId)
                    .HasName("IX_FK_Cession_scanCession");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasColumnName("access");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("fileName");

                entity.Property(e => e.Giantguid)
                    .HasColumnName("GIANTGUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.OldPath).HasColumnName("oldPath");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status1c).HasColumnName("status_1c");

                entity.Property(e => e.StatusCopy)
                    .HasColumnName("status_copy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Cession)
                    .WithMany(p => p.CessionScans)
                    .HasForeignKey(d => d.CessionId)
                    .HasConstraintName("FK_Cession_scanCession");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany(p => p.CessionScans)
                    .HasForeignKey(d => d.StatusCopy)
                    .HasConstraintName("FK_Cession_scans_status_copy");
            });

            modelBuilder.Entity<Cessions>(entity =>
            {
                entity.HasIndex(e => e.Date)
                    .HasName("IX_FK_dateCession");

                entity.HasIndex(e => e.PartnerId)
                    .HasName("IX_FK_PartnerCession");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AssignmentCess).HasColumnName("assignment_cess");

                entity.Property(e => e.CommitDate)
                    .HasColumnName("commit_date")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.NewPrefix)
                    .HasColumnName("new_prefix")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.Cessions)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerCession");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Client", "exchange");

                entity.HasIndex(e => e.IdClient)
                    .HasName("UQ__Client__6EC2B6C15AE0AC67")
                    .IsUnique();

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");
            });

            modelBuilder.Entity<ContractLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Contract_locations");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractRequess>(entity =>
            {
                entity.ToTable("Contract_requess");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_FK_ContractContract_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressToIl).HasColumnName("address_to_il");

                entity.Property(e => e.ArchivistComment)
                    .IsRequired()
                    .HasColumnName("archivistComment")
                    .HasMaxLength(500);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.FinishDate)
                    .HasColumnName("finishDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishedUser)
                    .HasColumnName("finishedUser")
                    .HasMaxLength(100);

                entity.Property(e => e.IdBit)
                    .HasColumnName("idBit")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsUrgent).HasColumnName("isUrgent");

                entity.Property(e => e.ReqComment)
                    .HasColumnName("reqComment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReqStatus).HasColumnName("req_status");

                entity.Property(e => e.ReqType).HasColumnName("reqType");

                entity.Property(e => e.RequestComment)
                    .IsRequired()
                    .HasColumnName("requestComment")
                    .HasMaxLength(1000);

                entity.Property(e => e.RequestDate)
                    .HasColumnName("requestDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestUser)
                    .IsRequired()
                    .HasColumnName("requestUser")
                    .HasMaxLength(100);

                entity.Property(e => e.RequestUserFio)
                    .HasColumnName("requestUserFIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SetForm).HasColumnName("setForm");

                entity.Property(e => e.SetGraph).HasColumnName("setGraph");

                entity.Property(e => e.SetPasport).HasColumnName("setPasport");

                entity.Property(e => e.UserCreate).HasColumnName("userCreate");

                entity.Property(e => e.UserFinished).HasColumnName("userFinished");

                entity.Property(e => e.WorkoutDate)
                    .HasColumnName("workoutDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkoutUser)
                    .HasColumnName("workoutUser")
                    .HasMaxLength(100);

                entity.HasOne(d => d.AddressToIlNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.AddressToIl)
                    .HasConstraintName("FK_Contract_Requess_Office_Address");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Contract_requess_Contracts");

                entity.HasOne(d => d.ReqCommentNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ReqComment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request_Comment");

                entity.HasOne(d => d.ReqStatusNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ReqStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_request_status");

                entity.HasOne(d => d.ReqTypeNavigation)
                    .WithMany(p => p.ContractRequess)
                    .HasForeignKey(d => d.ReqType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request_types");
            });

            modelBuilder.Entity<ContractRequestBitSendLog>(entity =>
            {
                entity.ToTable("Contract_Request_BIT_Send_Log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateSend)
                    .HasColumnName("date_send")
                    .HasColumnType("datetime");

                entity.Property(e => e.HtmlCode).HasColumnName("html_code");

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Responce)
                    .HasColumnName("responce")
                    .IsUnicode(false);

                entity.Property(e => e.StatusSend).HasColumnName("status_send");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.ContractRequestBitSendLog)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request");
            });

            modelBuilder.Entity<ContractRequestCommentType>(entity =>
            {
                entity.ToTable("Contract_request_comment_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractRequestStatuses>(entity =>
            {
                entity.ToTable("Contract_request_statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractRequestTypes>(entity =>
            {
                entity.ToTable("Contract_Request_types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisibleStatus)
                    .HasColumnName("visible_status")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.VisibleStatusNavigation)
                    .WithMany(p => p.ContractRequestTypes)
                    .HasForeignKey(d => d.VisibleStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Request_Visible_status");
            });

            modelBuilder.Entity<ContractRequestTypesStatusVisible>(entity =>
            {
                entity.ToTable("Contract_request_types_status_visible");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discript)
                    .IsRequired()
                    .HasColumnName("discript")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractScanExists>(entity =>
            {
                entity.ToTable("Contract_scan_exists");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContractScans>(entity =>
            {
                entity.ToTable("Contract_scans");

                entity.HasIndex(e => e.ContractId)
                    .HasName("IX_FK_ContractContract_scan");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.Converted).HasColumnName("converted");

                entity.Property(e => e.CsType)
                    .HasColumnName("csType")
                    .HasDefaultValueSql("((7))");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeffectDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ExistDocument).HasDefaultValueSql("((1))");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HashFile)
                    .HasColumnName("hash_file")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InsertDateScan).HasColumnType("datetime");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEx).HasColumnName("isEx");

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status1c).HasColumnName("status_1c");

                entity.Property(e => e.StatusCopy)
                    .HasColumnName("statusCopy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_ContractContract_scan");

                entity.HasOne(d => d.CsTypeNavigation)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.CsType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Scans_Type");

                entity.HasOne(d => d.ExistDocumentNavigation)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.ExistDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_scansExistDocument");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany(p => p.ContractScans)
                    .HasForeignKey(d => d.StatusCopy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractScansStatusesCopy");
            });

            modelBuilder.Entity<ContractScansDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contract_scans_Delete");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.Converted).HasColumnName("converted");

                entity.Property(e => e.CsType).HasColumnName("csType");

                entity.Property(e => e.DateInsdel)
                    .HasColumnName("dateInsdel")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeffectDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.Folder)
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HashFile)
                    .HasColumnName("hash_file")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDateScan).HasColumnType("datetime");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEx).HasColumnName("isEx");

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OldPath)
                    .HasColumnName("old_path")
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.ScanType)
                    .HasColumnName("scanType")
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status1c).HasColumnName("status_1c");

                entity.Property(e => e.StatusCopy).HasColumnName("statusCopy");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ContractScansOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contract_scans_Old");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.Converted).HasColumnName("converted");

                entity.Property(e => e.CsType).HasColumnName("csType");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeffectDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HashFile)
                    .HasColumnName("hash_file")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.InsertDateScan).HasColumnType("datetime");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsEx).HasColumnName("isEx");

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Status1c).HasColumnName("status_1c");

                entity.Property(e => e.StatusCopy).HasColumnName("statusCopy");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ContractSigns>(entity =>
            {
                entity.ToTable("Contract_signs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.HasIndex(e => e.CessionId)
                    .HasName("IX_FK_CessionContract");

                entity.HasIndex(e => e.DebtNumber)
                    .HasName("NonClusteredIndex-20170201-183430");

                entity.HasIndex(e => e.DebtorFio)
                    .HasName("IX_debitor_fio");

                entity.HasIndex(e => e.IdPkb)
                    .HasName("IX_FK_ID_PKB");

                entity.HasIndex(e => e.IdPristav)
                    .HasName("NonClusteredIndex-20170201-184004");

                entity.HasIndex(e => e.Location)
                    .HasName("IX_Location");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auditing).HasColumnName("auditing");

                entity.Property(e => e.Avtocredit).HasColumnName("avtocredit");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DebtDate)
                    .HasColumnName("debt_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocketAddress)
                    .HasColumnName("docket_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("Адресс выписки");

                entity.Property(e => e.DocketAddressUpdate)
                    .HasColumnName("docket_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtcAddress)
                    .HasColumnName("etc_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EtcAddressUpdate)
                    .HasColumnName("etc_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdNrs).HasColumnName("id_nrs");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IsAssigment)
                    .HasColumnName("isAssigment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LawyerAddress)
                    .HasColumnName("lawyer_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LawyerAddressUpdate)
                    .HasColumnName("lawyer_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationAddressUpdate)
                    .HasColumnName("location_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriginalIlAdress)
                    .HasColumnName("original_il_adress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIlAdressUpdate)
                    .HasColumnName("original_il_adress_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.PtsAddress)
                    .HasColumnName("pts_address")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PtsAddressUpdate)
                    .HasColumnName("pts_address_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.UploadDate)
                    .HasColumnName("upload_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AuditingNavigation)
                    .WithMany(p => p.ContractsAuditingNavigation)
                    .HasForeignKey(d => d.Auditing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractsAuditing");

                entity.HasOne(d => d.AvtocreditNavigation)
                    .WithMany(p => p.ContractsAvtocreditNavigation)
                    .HasForeignKey(d => d.Avtocredit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractsAvtocredit");

                entity.HasOne(d => d.Cession)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.CessionId)
                    .HasConstraintName("FK_Contracts_Cession_id");

                entity.HasOne(d => d.IsAssigmentNavigation)
                    .WithMany(p => p.ContractsIsAssigmentNavigation)
                    .HasForeignKey(d => d.IsAssigment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_isAssigment");
            });

            modelBuilder.Entity<ContractsInRequest>(entity =>
            {
                entity.ToTable("Contracts_in_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContractRequessId).HasColumnName("Contract_requess_id");

                entity.Property(e => e.OutsideRequessId).HasColumnName("Outside_requess_id");

                entity.HasOne(d => d.ContractRequess)
                    .WithMany(p => p.ContractsInRequest)
                    .HasForeignKey(d => d.ContractRequessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_in_request_Contract_requess");

                entity.HasOne(d => d.OutsideRequess)
                    .WithMany(p => p.ContractsInRequest)
                    .HasForeignKey(d => d.OutsideRequessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_in_request_Outside_requess");
            });

            modelBuilder.Entity<ContractsLocations>(entity =>
            {
                entity.ToTable("Contracts_locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CsType).HasColumnName("cs_type");

                entity.Property(e => e.Folder)
                    .HasColumnName("folder")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdContractScan)
                    .HasColumnName("id_contract_scan")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScanExist).HasColumnName("scan_exist");

                entity.Property(e => e.Сity)
                    .HasColumnName("сity")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.CsTypeNavigation)
                    .WithMany(p => p.ContractsLocations)
                    .HasForeignKey(d => d.CsType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_locations_cs_type");

                entity.HasOne(d => d.IdHkdNavigation)
                    .WithMany(p => p.ContractsLocations)
                    .HasForeignKey(d => d.IdHkd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contracts_locations_id_hkd");
            });

            modelBuilder.Entity<ContractsTemp>(entity =>
            {
                entity.ToTable("Contracts_temp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdSess).HasColumnName("id_sess");
            });

            modelBuilder.Entity<DebtWithHkdScans>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Debt_with_HKD_Scans");

                entity.Property(e => e.CessionDate)
                    .HasColumnName("Cession_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CessionName)
                    .IsRequired()
                    .HasColumnName("Cession_name");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasColumnName("Partner_name");

                entity.Property(e => e.ScanCount).HasColumnName("Scan_count");

                entity.Property(e => e.ScanCountDoc).HasColumnName("Scan_count_DOC");

                entity.Property(e => e.ScanCountDot).HasColumnName("Scan_count_DOT");

                entity.Property(e => e.ScanCountLaw).HasColumnName("Scan_count_LAW");

                entity.Property(e => e.ScanCountPts).HasColumnName("Scan_count_PTS");
            });

            modelBuilder.Entity<DelScans>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.Path).HasColumnName("path");
            });

            modelBuilder.Entity<DocLinkFromNrs>(entity =>
            {
                entity.HasKey(e => e.IdDocNrs);

                entity.ToTable("doc_link_from_nrs", "exchange");

                entity.Property(e => e.IdDocNrs)
                    .HasColumnName("id_doc_nrs")
                    .ValueGeneratedNever();

                entity.Property(e => e.DtIns)
                    .HasColumnName("dt_ins")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUpd)
                    .HasColumnName("dt_upd")
                    .HasColumnType("datetime");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdDEaSubType).HasColumnName("id_d_ea_sub_type");

                entity.Property(e => e.IdNrs).HasColumnName("id_nrs");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.RefinAgreementNumber).HasColumnName("refin_agreement_number");
            });

            modelBuilder.Entity<FastRequess>(entity =>
            {
                entity.ToTable("Fast_requess");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BossEmail)
                    .HasColumnName("Boss_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollectorFio)
                    .HasColumnName("Collector_FIO")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ContractRequessId).HasColumnName("Contract_requess_id");

                entity.Property(e => e.DeadlineDate)
                    .HasColumnName("Deadline_date")
                    .HasColumnType("date");

                entity.Property(e => e.Descr)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequessResonId).HasColumnName("Requess_reson_id");

                entity.HasOne(d => d.ContractRequess)
                    .WithMany(p => p.FastRequess)
                    .HasForeignKey(d => d.ContractRequessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fast_requess_Contract_requess");

                entity.HasOne(d => d.RequessReson)
                    .WithMany(p => p.FastRequess)
                    .HasForeignKey(d => d.RequessResonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fast_requess_Requess_reson");
            });

            modelBuilder.Entity<HkdScans>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HKD_Scans");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastUpdate)
                    .HasColumnName("date_last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.Folder)
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdNrs).HasColumnName("id_nrs");

                entity.Property(e => e.IdPartInfo).HasColumnName("ID_Part_Info");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.ScanType)
                    .IsRequired()
                    .HasColumnName("scanType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScanTypeId).HasColumnName("scanTypeId");
            });

            modelBuilder.Entity<HkdScansIlExists>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HKD_Scans_IL_Exists");

                entity.Property(e => e.CsType).HasColumnName("csType");

                entity.Property(e => e.ExistDoc)
                    .HasColumnName("exist_doc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.Path).HasColumnName("path");

                entity.Property(e => e.ScanId).HasColumnName("scan_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IdHkd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("id_hkd", "podlevsky");

                entity.Property(e => e.IdHkd1).HasColumnName("id_hkd");
            });

            modelBuilder.Entity<Kuznecova>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Filename).HasColumnName("filename");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.NewBox)
                    .HasColumnName("new_box")
                    .HasMaxLength(200);

                entity.Property(e => e.NewCity)
                    .HasColumnName("new_city")
                    .HasMaxLength(200);

                entity.Property(e => e.NewExist).HasColumnName("new_exist");

                entity.Property(e => e.NewFolder)
                    .HasColumnName("new_folder")
                    .HasMaxLength(200);

                entity.Property(e => e.NewKeeper)
                    .HasColumnName("new_keeper")
                    .HasMaxLength(200);

                entity.Property(e => e.NewParty)
                    .HasColumnName("new_party")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<LoadedContractWithScans>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("loaded_Contract_with_Scans");

                entity.Property(e => e.ДатаДоговораЦессии)
                    .HasColumnName("Дата договора цессии")
                    .HasColumnType("datetime");

                entity.Property(e => e.КоличествоКдВнесенныхВХкд).HasColumnName("количество КД (внесенных в ХКД)");

                entity.Property(e => e.КоличествоСканКопийВХкд).HasColumnName("количество скан-копий в ХКД");

                entity.Property(e => e.НаименованиеПартнера)
                    .IsRequired()
                    .HasColumnName("Наименование партнера");

                entity.Property(e => e.НомерДоговораЦессии)
                    .IsRequired()
                    .HasColumnName("Номер договора цессии");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasIndex(e => e.Group)
                    .HasName("IX_Group_log");

                entity.HasIndex(e => e.Time)
                    .HasName("IX_Time");

                entity.HasIndex(e => new { e.Group, e.Time, e.Text })
                    .HasName("Temp_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Error)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationIdentify).HasColumnName("Operation_Identify");

                entity.Property(e => e.Process)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reestr)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogConverter>(entity =>
            {
                entity.ToTable("Log_Converter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateConvert)
                    .HasColumnName("dateConvert")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("errorMessage")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.FileExtension)
                    .HasColumnName("fileExtension")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Host)
                    .HasColumnName("host")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdContractScan).HasColumnName("idContractScan");

                entity.Property(e => e.NewPath)
                    .HasColumnName("newPath")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OldPath)
                    .HasColumnName("oldPath")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnName("result");
            });

            modelBuilder.Entity<LogInsContractScans>(entity =>
            {
                entity.ToTable("Log_Ins_Contract_scans");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmBox)
                    .IsRequired()
                    .HasColumnName("amBox")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AmFolder)
                    .IsRequired()
                    .HasColumnName("amFolder")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ErrorCode).HasColumnName("errorCode");

                entity.Property(e => e.ErrorMess)
                    .HasColumnName("errorMess")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExistDocument).HasDefaultValueSql("((1))");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Hash)
                    .HasColumnName("hash")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdCsOnAddScan).HasColumnName("idCsOnAddScan");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LenInFile).HasColumnName("lenInFile");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PathIn)
                    .HasColumnName("pathIn")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PathOut)
                    .HasColumnName("pathOut")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScType).HasColumnName("scType");

                entity.HasOne(d => d.ExistDocumentNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.ExistDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Ins_Contract_scansExistDocument");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Task_Id");

                entity.HasOne(d => d.ScTypeNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.ScType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contract_Scans_Types");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany(p => p.LogInsContractScans)
                    .HasForeignKey(d => d.StatusCopy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Ins_Contract_scans_statuses_id");
            });

            modelBuilder.Entity<LogInsContractScansStatuses>(entity =>
            {
                entity.ToTable("Log_Ins_Contract_scans_statuses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogInsContracts>(entity =>
            {
                entity.ToTable("Log_Ins_Contracts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Auditing).HasColumnName("auditing");

                entity.Property(e => e.Avtocredit).HasColumnName("avtocredit");

                entity.Property(e => e.CessionId).HasColumnName("Cession_id");

                entity.Property(e => e.DebtDate)
                    .HasColumnName("debt_date")
                    .HasColumnType("date");

                entity.Property(e => e.DebtFio)
                    .IsRequired()
                    .HasColumnName("debt_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ErrMess)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogInsContracts)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Ins_Contracts_idTask");
            });

            modelBuilder.Entity<LogInsRequests>(entity =>
            {
                entity.ToTable("Log_Ins_Requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("idHkd");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.ReqType).HasColumnName("reqType");

                entity.Property(e => e.RequestUser)
                    .HasColumnName("requestUser")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogInsRequests)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_Task");

                entity.HasOne(d => d.ReqTypeNavigation)
                    .WithMany(p => p.LogInsRequests)
                    .HasForeignKey(d => d.ReqType)
                    .HasConstraintName("FK_requestType");
            });

            modelBuilder.Entity<LogUpdContractAssign>(entity =>
            {
                entity.ToTable("Log_Upd_Contract_Assign");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrorCode).HasColumnName("errorCode");

                entity.Property(e => e.ErrorMess)
                    .HasColumnName("errorMess")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("idHkd");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.IsAssign).HasColumnName("isAssign");

                entity.Property(e => e.StatusUpdate).HasColumnName("statusUpdate");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogUpdContractAssign)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceTask_TypeTask");
            });

            modelBuilder.Entity<LogUpdContractScansLocations>(entity =>
            {
                entity.ToTable("Log_Upd_Contract_Scans_locations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Box)
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CsType).HasColumnName("cs_type");

                entity.Property(e => e.ErrMess)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasColumnName("fileName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Folder)
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Party)
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusUpd).HasColumnName("statusUpd");

                entity.Property(e => e.Сity)
                    .HasColumnName("сity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CsTypeNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.CsType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locations_csTypes");

                entity.HasOne(d => d.ExistDocumentNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.ExistDocument)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locationsExistDocument");

                entity.HasOne(d => d.IdHkdNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.IdHkd)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locations_idHkd");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogUpdContractScansLocations)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Upd_Contract_Scans_locations_idTask");
            });

            modelBuilder.Entity<LogUpdRequests>(entity =>
            {
                entity.ToTable("Log_Upd_Requests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdReq).HasColumnName("idReq");

                entity.Property(e => e.IdTask).HasColumnName("idTask");

                entity.Property(e => e.ReqStatus).HasColumnName("reqStatus");

                entity.HasOne(d => d.IdTaskNavigation)
                    .WithMany(p => p.LogUpdRequests)
                    .HasForeignKey(d => d.IdTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_UpdRequests_idTask");
            });

            modelBuilder.Entity<Migr2dwhDocsLoad>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MIGR2DWH_DOCS_LOAD");

                entity.Property(e => e.ExtNumber).HasColumnName("ext_number");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NewStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("New_status", "exchange");

                entity.Property(e => e.IdNrs).HasColumnName("ID_NRS");

                entity.Property(e => e.IdPkb)
                    .HasColumnName("ID_PKB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPristav).HasColumnName("ID_PRISTAV");

                entity.Property(e => e.IdStatus).HasColumnName("ID_STATUS");
            });

            modelBuilder.Entity<NrsIds>(entity =>
            {
                entity.HasKey(e => e.IdNrs);

                entity.ToTable("NRS_IDS", "exchange");

                entity.Property(e => e.IdNrs)
                    .HasColumnName("id_nrs")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cession)
                    .HasColumnName("cession")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CessionContractDate)
                    .HasColumnName("cession_contract_date")
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.CessionNumberDtIns)
                    .HasColumnName("cession_number_dt_ins")
                    .HasColumnType("date");

                entity.Property(e => e.Contract)
                    .HasColumnName("contract")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreditDate)
                    .HasColumnName("credit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdPkb)
                    .HasColumnName("id_pkb")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerDtIns)
                    .HasColumnName("partner_dt_ins")
                    .HasColumnType("date");

                entity.Property(e => e.PortfolioName)
                    .HasColumnName("portfolio_name")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfficeAddress>(entity =>
            {
                entity.ToTable("Office_Address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasColumnName("city");

                entity.HasOne(d => d.CityNavigation)
                    .WithMany(p => p.OfficeAddress)
                    .HasForeignKey(d => d.City)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Office_City");
            });

            modelBuilder.Entity<OfficeCity>(entity =>
            {
                entity.ToTable("Office_City");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OldPathContractScans>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ErrorMess).IsUnicode(false);

                entity.Property(e => e.IdScan).HasColumnName("id_scan");

                entity.Property(e => e.LenFile).HasColumnName("lenFile");

                entity.Property(e => e.NewPath)
                    .HasColumnName("newPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldPath)
                    .HasColumnName("oldPath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCopy).HasColumnName("statusCopy");

                entity.HasOne(d => d.StatusCopyNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.StatusCopy)
                    .HasConstraintName("FK_StatusesCopy");
            });

            modelBuilder.Entity<OutsideRequess>(entity =>
            {
                entity.ToTable("Outside_requess");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MsgBody)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.SendTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubjectMsg)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("Template_id");

                entity.Property(e => e.UserSend)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.OutsideRequess)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Outside_requess_Template");
            });

            modelBuilder.Entity<PartnerTemplates>(entity =>
            {
                entity.ToTable("Partner_templates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("Partner_id");

                entity.Property(e => e.TemplateId).HasColumnName("Template_id");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerTemplates)
                    .HasForeignKey(d => d.PartnerId)
                    .HasConstraintName("FK_Partner_templates_Partners");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.PartnerTemplates)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Partner_templates_Templates");
            });

            modelBuilder.Entity<Partners>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.PrimaryCreditor).HasColumnName("primary_creditor");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasKey(e => e.PersonId);
            });

            modelBuilder.Entity<ReqArchComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("req_arch_comment");

                entity.Property(e => e.ArchComm)
                    .HasColumnName("arch_comm")
                    .IsUnicode(false);

                entity.Property(e => e.IdReq).HasColumnName("id_req");
            });

            modelBuilder.Entity<RequessReson>(entity =>
            {
                entity.ToTable("Requess_reson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RequestOutParam>(entity =>
            {
                entity.ToTable("Request_out_param");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.RequestOutParam)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_reqeust_out_param_ToTemplateId");
            });

            modelBuilder.Entity<ScanCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ScanCount");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number");

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.ScanCount1).HasColumnName("Scan_count");

                entity.Property(e => e.ДатаЦессии)
                    .HasColumnName("Дата цессии")
                    .HasColumnType("datetime");

                entity.Property(e => e.ДоговораЦессии)
                    .IsRequired()
                    .HasColumnName("№ Договора Цессии");

                entity.Property(e => e.Цедент)
                    .IsRequired()
                    .HasColumnName("цедент");
            });

            modelBuilder.Entity<ScanList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("scan_list", "podlevsky");

                entity.Property(e => e.CessionName)
                    .IsRequired()
                    .HasColumnName("cession_name");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("fileName");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasColumnName("partner_name");

                entity.Property(e => e.ScanType)
                    .HasColumnName("scanType")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<ServiceTasks>(entity =>
            {
                entity.ToTable("Service_Tasks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParamTask)
                    .HasColumnName("paramTask")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PathInFile)
                    .HasColumnName("pathInFile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PathOutFile)
                    .HasColumnName("pathOutFile")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResponceMessage)
                    .HasColumnName("responceMessage")
                    .IsUnicode(false);

                entity.Property(e => e.TypeInFile).HasColumnName("typeInFile");

                entity.Property(e => e.TypeOutFile).HasColumnName("typeOutFile");

                entity.Property(e => e.TypeStatus).HasColumnName("typeStatus");

                entity.Property(e => e.TypeTask).HasColumnName("typeTask");

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasColumnName("userCreate")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserFileName)
                    .HasColumnName("userFileName")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.TypeStatusNavigation)
                    .WithMany(p => p.ServiceTasks)
                    .HasForeignKey(d => d.TypeStatus)
                    .HasConstraintName("FK_Service_StatusesTask");

                entity.HasOne(d => d.TypeTaskNavigation)
                    .WithMany(p => p.ServiceTasks)
                    .HasForeignKey(d => d.TypeTask)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_TypesTask");
            });

            modelBuilder.Entity<ServiceTasksStatusesTask>(entity =>
            {
                entity.ToTable("Service_Tasks_StatusesTask");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceTasksTypesTask>(entity =>
            {
                entity.ToTable("Service_Tasks_TypesTask");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status1cDescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Status_1c_description");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<StatusesCopy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Templates>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dossier)
                    .HasColumnName("dossier")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fio)
                    .HasColumnName("fio")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIl)
                    .HasColumnName("original_il")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Post)
                    .HasColumnName("post")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pts)
                    .HasColumnName("pts")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TemplateName)
                    .HasColumnName("template_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCessionTree>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCessionTree");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(500);

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.PartnerName)
                    .HasColumnName("partner_name")
                    .HasMaxLength(500);

                entity.Property(e => e.Rn)
                    .HasColumnName("rn")
                    .IsUnicode(false);

                entity.Property(e => e.RootCessionId).HasColumnName("root_cession_id");
            });

            modelBuilder.Entity<VwCodeTamplateSendMailRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_code_Tamplate_SendMailRequest");

                entity.Property(e => e.ArchivistComment)
                    .IsRequired()
                    .HasColumnName("archivistComment");

                entity.Property(e => e.CessionDate)
                    .HasColumnName("cessionDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CessionNum)
                    .IsRequired()
                    .HasColumnName("cessionNum");

                entity.Property(e => e.ContractRequessId).HasColumnName("contract_requess_id");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocketAddress)
                    .HasColumnName("docket_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdHkd).HasColumnName("idHkd");

                entity.Property(e => e.IsCopy)
                    .IsRequired()
                    .HasColumnName("isCopy")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LawyerAddress)
                    .HasColumnName("lawyer_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .IsRequired()
                    .HasColumnName("location_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIlAdress)
                    .HasColumnName("original_il_adress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OutsideRequessId).HasColumnName("outside_requess_id");

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasColumnName("partnerName");

                entity.Property(e => e.PtsAddress)
                    .HasColumnName("pts_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestComment)
                    .IsRequired()
                    .HasColumnName("requestComment");

                entity.Property(e => e.RequestDate)
                    .HasColumnName("requestDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RequestType)
                    .HasColumnName("requestType")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUser)
                    .IsRequired()
                    .HasColumnName("requestUser");

                entity.Property(e => e.RequestUserFio)
                    .HasColumnName("requestUserFIO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<VwConnectionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwConnectionInfo");

                entity.Property(e => e.IpКлиента)
                    .HasColumnName("IP клиента")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.IpПодключенияКСерверу)
                    .HasColumnName("IP подключения к серверу")
                    .HasMaxLength(48)
                    .IsUnicode(false);

                entity.Property(e => e.Loginame)
                    .IsRequired()
                    .HasColumnName("loginame")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.ИмяPcКлиента)
                    .IsRequired()
                    .HasColumnName("Имя PC клиента")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.ИмяПрограммы)
                    .IsRequired()
                    .HasColumnName("Имя программы")
                    .HasMaxLength(128)
                    .IsFixedLength();

                entity.Property(e => e.ПротоколПодключения)
                    .IsRequired()
                    .HasColumnName("Протокол подключения")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<VwContractFromCessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwContractFromCessions");

                entity.Property(e => e.Auditing)
                    .IsRequired()
                    .HasColumnName("auditing")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Avtocredit)
                    .IsRequired()
                    .HasColumnName("avtocredit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.CessDate)
                    .HasColumnName("cess_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CessionId).HasColumnName("cession_id");

                entity.Property(e => e.Cessions)
                    .HasColumnName("cessions")
                    .HasMaxLength(500);

                entity.Property(e => e.CountScanContracts).HasColumnName("count_scan_contracts");

                entity.Property(e => e.CountScanIl).HasColumnName("count_scan_IL");

                entity.Property(e => e.CountScanPts).HasColumnName("count_scan_PTS");

                entity.Property(e => e.CountScanSud).HasColumnName("count_scan_SUD");

                entity.Property(e => e.CountScanVipiska).HasColumnName("count_scan_vipiska");

                entity.Property(e => e.DeptDate)
                    .HasColumnName("dept_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeptFio)
                    .IsRequired()
                    .HasColumnName("dept_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeptNumber)
                    .IsRequired()
                    .HasColumnName("dept_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.IsAssigment)
                    .IsRequired()
                    .HasColumnName("isAssigment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.KeeperKd)
                    .HasColumnName("keeper_kd")
                    .HasMaxLength(200);

                entity.Property(e => e.LocationDocket)
                    .HasColumnName("location_docket")
                    .HasMaxLength(1000);

                entity.Property(e => e.LocationIl)
                    .HasColumnName("location_il")
                    .HasMaxLength(1000);

                entity.Property(e => e.LocationKd)
                    .HasColumnName("location_kd")
                    .HasMaxLength(1000);

                entity.Property(e => e.LocationLawyer)
                    .HasColumnName("location_lawyer")
                    .HasMaxLength(1000);

                entity.Property(e => e.LocationPts)
                    .HasColumnName("location_pts")
                    .HasMaxLength(1000);

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.Partners)
                    .HasColumnName("partners")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<VwContractScanFromContracts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwContractScanFromContracts");

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cession)
                    .HasColumnName("cession")
                    .HasMaxLength(500);

                entity.Property(e => e.CessionId).HasColumnName("cession_id");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CsId).HasColumnName("cs_id");

                entity.Property(e => e.CsType)
                    .IsRequired()
                    .HasColumnName("cs_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeptFio)
                    .IsRequired()
                    .HasColumnName("dept_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeptNumber)
                    .IsRequired()
                    .HasColumnName("dept_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("file_name");

                entity.Property(e => e.FileType)
                    .HasColumnName("file_type")
                    .HasMaxLength(255);

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdHkd).HasColumnName("id_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.InsertDate)
                    .HasColumnName("insert_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertUser)
                    .HasColumnName("insert_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAssigment)
                    .IsRequired()
                    .HasColumnName("isAssigment")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(500);

                entity.Property(e => e.PartnerId).HasColumnName("partner_id");

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwContractStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwContractStat");

                entity.Property(e => e.Avtokredit)
                    .IsRequired()
                    .HasColumnName("avtokredit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cession)
                    .HasColumnName("cession")
                    .HasMaxLength(500);

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CommentArhiv)
                    .IsRequired()
                    .HasColumnName("comment_arhiv")
                    .HasMaxLength(500);

                entity.Property(e => e.CountScanContracts).HasColumnName("count_scan_contracts");

                entity.Property(e => e.CountScanIl).HasColumnName("count_scan_IL");

                entity.Property(e => e.CountScanPts).HasColumnName("count_scan_PTS");

                entity.Property(e => e.CountScanSud).HasColumnName("count_scan_SUD");

                entity.Property(e => e.CountScanVipiska).HasColumnName("count_scan_vipiska");

                entity.Property(e => e.DataCession)
                    .HasColumnName("data_cession")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataContract)
                    .HasColumnName("data_contract")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEnd)
                    .HasColumnName("data_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRequest)
                    .HasColumnName("data_request")
                    .HasColumnType("datetime");

                entity.Property(e => e.FioDoljnika)
                    .IsRequired()
                    .HasColumnName("fio_doljnika")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("ID_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("ID_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("ID_pristav");

                entity.Property(e => e.IdRequest).HasColumnName("ID_request");

                entity.Property(e => e.IsBit)
                    .IsRequired()
                    .HasColumnName("isBit")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Ispolnitel).HasMaxLength(100);

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(200);

                entity.Property(e => e.LawyerAddress)
                    .HasColumnName("lawyer_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .HasColumnName("location_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mestopolojenie)
                    .HasColumnName("mestopolojenie")
                    .HasMaxLength(1000);

                entity.Property(e => e.NumderContract)
                    .IsRequired()
                    .HasColumnName("Numder_Contract")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIlAdress)
                    .HasColumnName("original_il_adress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(500);

                entity.Property(e => e.Pereustup)
                    .IsRequired()
                    .HasColumnName("pereustup")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prosujen)
                    .IsRequired()
                    .HasColumnName("prosujen")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PtsAddress)
                    .HasColumnName("pts_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReqStatus).HasColumnName("req_status");

                entity.Property(e => e.ReqType).HasColumnName("reqType");

                entity.Property(e => e.RequestLawers)
                    .IsRequired()
                    .HasColumnName("request_lawers")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatusRequest)
                    .IsRequired()
                    .HasColumnName("status_request")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summ).HasColumnName("summ");

                entity.Property(e => e.TypeRequest)
                    .IsRequired()
                    .HasColumnName("type_request")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userfio)
                    .HasColumnName("userfio")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WorkoutDate)
                    .HasColumnName("workoutDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkoutUser)
                    .HasColumnName("workoutUser")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VwContractsAndRequestsHkdData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwContracts_and_requests_HKD_data");

                entity.Property(e => e.CessName)
                    .HasColumnName("cess_name")
                    .HasMaxLength(500);

                entity.Property(e => e.DateCess)
                    .HasColumnName("date_cess")
                    .HasColumnType("datetime");

                entity.Property(e => e.DosPredost).HasColumnName("dos_predost");

                entity.Property(e => e.DosUPart).HasColumnName("dos_u_part");

                entity.Property(e => e.DosUPartn).HasColumnName("dos_u_partn");

                entity.Property(e => e.InRoud).HasColumnName("inRoud");

                entity.Property(e => e.KolichZaprosOjid).HasColumnName("kolich_zapros_ojid");

                entity.Property(e => e.NeZalitHkd).HasColumnName("ne_zalit_hkd");

                entity.Property(e => e.Otsutstv).HasColumnName("otsutstv");

                entity.Property(e => e.PartnerName)
                    .HasColumnName("partner_name")
                    .HasMaxLength(500);

                entity.Property(e => e.Prodaja).HasColumnName("prodaja");

                entity.Property(e => e.ReqDigitscan).HasColumnName("req_digitscan");

                entity.Property(e => e.ReqFtp).HasColumnName("req_ftp");

                entity.Property(e => e.ReqInRoad).HasColumnName("req_inRoad");

                entity.Property(e => e.ReqInfolog).HasColumnName("req_infolog");

                entity.Property(e => e.ReqIronMountain).HasColumnName("req_iron_mountain");

                entity.Property(e => e.ReqOrb).HasColumnName("req_orb");

                entity.Property(e => e.ReqPkb).HasColumnName("req_pkb");

                entity.Property(e => e.ReqRaiswolf).HasColumnName("req_raiswolf");

                entity.Property(e => e.RowId).HasColumnName("row_id");

                entity.Property(e => e.SkanVHkd).HasColumnName("skan_v_hkd");

                entity.Property(e => e.SumDigitscan).HasColumnName("sum_digitscan");

                entity.Property(e => e.SumFtp).HasColumnName("sum_ftp");

                entity.Property(e => e.SumInfolog).HasColumnName("sum_infolog");

                entity.Property(e => e.SumIronmountan).HasColumnName("sum_ironmountan");

                entity.Property(e => e.SumOrb).HasColumnName("sum_orb");

                entity.Property(e => e.SumPkb).HasColumnName("sum_pkb");

                entity.Property(e => e.SumRaiswolf).HasColumnName("sum_raiswolf");

                entity.Property(e => e.VsegoKupleno).HasColumnName("vsego_kupleno");

                entity.Property(e => e.VsegoNePeredano).HasColumnName("vsego_ne_peredano");

                entity.Property(e => e.VsegoPeredano).HasColumnName("vsego_peredano");
            });

            modelBuilder.Entity<VwContractsAndRequestsHkdDescr>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwContracts_and_requests_HKD_descr");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.NameColumn)
                    .IsRequired()
                    .HasColumnName("name_column");
            });

            modelBuilder.Entity<VwContractsLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwContractsLocations");

                entity.Property(e => e.DocketAddress)
                    .HasColumnName("docket_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.LawyerAddress)
                    .HasColumnName("lawyer_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LocationAddress)
                    .IsRequired()
                    .HasColumnName("location_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalIlAdress)
                    .HasColumnName("original_il_adress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PtsAddress)
                    .HasColumnName("pts_address")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwRequestsExecutiveDocsSelect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwRequestsExecutiveDocsSelect");

                entity.Property(e => e.Box)
                    .IsRequired()
                    .HasColumnName("box")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CessDate)
                    .HasColumnName("cess_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cession)
                    .HasColumnName("cession")
                    .HasMaxLength(500);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Csid).HasColumnName("csid");

                entity.Property(e => e.DebtNumber)
                    .IsRequired()
                    .HasColumnName("debt_number")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorFio)
                    .IsRequired()
                    .HasColumnName("debtor_fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExistDocument)
                    .IsRequired()
                    .HasColumnName("exist_document")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasColumnName("file_name");

                entity.Property(e => e.Folder)
                    .IsRequired()
                    .HasColumnName("folder")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdPkb).HasColumnName("id_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("id_pristav");

                entity.Property(e => e.Keeper)
                    .IsRequired()
                    .HasColumnName("keeper")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(500);

                entity.Property(e => e.Party)
                    .IsRequired()
                    .HasColumnName("party")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReqId).HasColumnName("req_id");
            });

            modelBuilder.Entity<VwRestoreHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwRestoreHistory");

                entity.Property(e => e.BackupDevice)
                    .HasColumnName("Backup Device")
                    .HasMaxLength(260);

                entity.Property(e => e.BackupFinished)
                    .HasColumnName("Backup Finished")
                    .HasColumnType("datetime");

                entity.Property(e => e.BackupMadeBy)
                    .HasColumnName("Backup Made By")
                    .HasMaxLength(128);

                entity.Property(e => e.BackupSizeCompressedMb)
                    .HasColumnName("Backup Size Compressed (MB)")
                    .HasColumnType("money");

                entity.Property(e => e.BackupSizeMb)
                    .HasColumnName("Backup Size (MB)")
                    .HasColumnType("money");

                entity.Property(e => e.BackupStarted)
                    .HasColumnName("Backup Started")
                    .HasColumnType("datetime");

                entity.Property(e => e.BackupType)
                    .HasColumnName("Backup Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BackupsetDesc)
                    .HasColumnName("Backupset Desc")
                    .HasMaxLength(255);

                entity.Property(e => e.BackupsetName)
                    .HasColumnName("Backupset Name")
                    .HasMaxLength(128);

                entity.Property(e => e.CheckpointLsn)
                    .HasColumnName("checkpoint_lsn")
                    .HasColumnType("numeric(25, 0)");

                entity.Property(e => e.Compression)
                    .HasColumnName("Compression %")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DatabaseBackupLsn)
                    .HasColumnName("database_backup_lsn")
                    .HasColumnType("numeric(25, 0)");

                entity.Property(e => e.DestinationDb)
                    .HasColumnName("Destination DB")
                    .HasMaxLength(128);

                entity.Property(e => e.DeviceType)
                    .HasColumnName("Device Type")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.FirstLsn)
                    .HasColumnName("first_lsn")
                    .HasColumnType("numeric(25, 0)");

                entity.Property(e => e.LastLsn)
                    .HasColumnName("last_lsn")
                    .HasColumnType("numeric(25, 0)");

                entity.Property(e => e.RestoreDate)
                    .HasColumnName("Restore Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RestoreType)
                    .HasColumnName("Restore Type")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RestoredBy)
                    .HasColumnName("Restored By")
                    .HasMaxLength(128);

                entity.Property(e => e.SdbCollation)
                    .HasColumnName("SDB Collation")
                    .HasMaxLength(128);

                entity.Property(e => e.SdbCompLevel).HasColumnName("SDB CompLevel");

                entity.Property(e => e.SdbCreated)
                    .HasColumnName("SDB Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.SdbRecovery)
                    .HasColumnName("SDB Recovery")
                    .HasMaxLength(60);

                entity.Property(e => e.SourceDbSdb)
                    .HasColumnName("Source DB (SDB)")
                    .HasMaxLength(128);

                entity.Property(e => e.SourceSql)
                    .HasColumnName("Source SQL")
                    .HasMaxLength(128);

                entity.Property(e => e.SqlVersion)
                    .HasColumnName("SQL Version")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StopAt)
                    .HasColumnName("stop_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.StopAtMarkName)
                    .HasColumnName("stop_at_mark_name")
                    .HasMaxLength(128);

                entity.Property(e => e.StopBefore).HasColumnName("stop_before");

                entity.Property(e => e.WithRecovery).HasColumnName("With Recovery");

                entity.Property(e => e.WithReplace).HasColumnName("With Replace");
            });

            modelBuilder.Entity<VwScanStat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwScanStat");

                entity.Property(e => e.ContractId).HasColumnName("Contract_id");

                entity.Property(e => e.CountScanContracts).HasColumnName("count_scan_contracts");

                entity.Property(e => e.CountScanIl).HasColumnName("count_scan_IL");

                entity.Property(e => e.CountScanPts).HasColumnName("count_scan_PTS");

                entity.Property(e => e.CountScanSud).HasColumnName("count_scan_SUD");

                entity.Property(e => e.CountScanVipiska).HasColumnName("count_scan_vipiska");

                entity.Property(e => e.DocExist).HasColumnName("doc_exist");
            });

            modelBuilder.Entity<VwStatisticRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwStatisticRequest");

                entity.Property(e => e.Avtokredit)
                    .IsRequired()
                    .HasColumnName("avtokredit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cession)
                    .HasColumnName("cession")
                    .HasMaxLength(500);

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CommentArhiv)
                    .IsRequired()
                    .HasColumnName("comment_arhiv")
                    .HasMaxLength(500);

                entity.Property(e => e.CountScanContracts).HasColumnName("count_scan_contracts");

                entity.Property(e => e.CountScanIl).HasColumnName("count_scan_IL");

                entity.Property(e => e.CountScanPts).HasColumnName("count_scan_PTS");

                entity.Property(e => e.CountScanSud).HasColumnName("count_scan_SUD");

                entity.Property(e => e.CountScanVipiska).HasColumnName("count_scan_vipiska");

                entity.Property(e => e.DataCession)
                    .HasColumnName("data_cession")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataContract)
                    .HasColumnName("data_contract")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataEnd)
                    .HasColumnName("data_end")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataRequest)
                    .HasColumnName("data_request")
                    .HasColumnType("datetime");

                entity.Property(e => e.FioDoljnika)
                    .IsRequired()
                    .HasColumnName("fio_doljnika")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdHkd).HasColumnName("ID_hkd");

                entity.Property(e => e.IdPkb).HasColumnName("ID_pkb");

                entity.Property(e => e.IdPristav).HasColumnName("ID_pristav");

                entity.Property(e => e.IdRequest).HasColumnName("ID_request");

                entity.Property(e => e.Ispolnitel).HasMaxLength(100);

                entity.Property(e => e.Keeper)
                    .HasColumnName("keeper")
                    .HasMaxLength(200);

                entity.Property(e => e.Mestopolojenie)
                    .HasColumnName("mestopolojenie")
                    .HasMaxLength(1000);

                entity.Property(e => e.NumderContract)
                    .IsRequired()
                    .HasColumnName("Numder_Contract")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Partner)
                    .HasColumnName("partner")
                    .HasMaxLength(500);

                entity.Property(e => e.Pereustup)
                    .IsRequired()
                    .HasColumnName("pereustup")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prosujen)
                    .IsRequired()
                    .HasColumnName("prosujen")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReqType).HasColumnName("reqType");

                entity.Property(e => e.RequestLawers)
                    .IsRequired()
                    .HasColumnName("request_lawers")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatusRequest)
                    .IsRequired()
                    .HasColumnName("status_request")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summ).HasColumnName("summ");

                entity.Property(e => e.TypeRequest)
                    .IsRequired()
                    .HasColumnName("type_request")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userfio)
                    .HasColumnName("userfio")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZdEaSubType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zd_ea_sub_type", "exchange");

                entity.Property(e => e.IdDEaSubType).HasColumnName("id_d_ea_sub_type");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(512)
                    .IsUnicode(false);
            });
            #endregion
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
