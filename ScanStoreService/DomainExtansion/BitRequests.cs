using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScanStoreService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScanStoreService.Domain
{
    public class BitRequestStatus : Enumeration
    {
        public static readonly BitRequestStatus None
            = new BitRequestStatus(0, "Отсутствует");
        public static readonly BitRequestStatus New
            = new BitRequestStatus(1, "Новый");
        public static readonly BitRequestStatus Finished
            = new BitRequestStatus(2, "Завершенный");

        public BitRequestStatus() { }
        private BitRequestStatus(int value, string displayName) : base(value, displayName) { }
    }

    public partial class BitRequest
    {
        public BitRequest()
        {
            ContractRequests = new HashSet<ContractRequess>();
        }
    }

    public class BitRequestsConfiguration : IEntityTypeConfiguration<BitRequest>
    {
        public void Configure(EntityTypeBuilder<BitRequest> entity)
        {
            //entity.HasDiscriminator<LoaderTypeEnum>("Type");
            entity.HasKey(e => new { e.Id });
            //entity.HasAlternateKey(s => s.IdBit);
            entity.HasMany(s => s.ContractRequests)
                .WithOne(l => l.BitRequests)
                .OnDelete(DeleteBehavior.NoAction);
            entity.Property(s => s.IdPkb).IsRequired();
            entity.Property(s => s.IdBit)
                .IsRequired()
                .HasMaxLength(20);
            
            entity.Property(s => s.DateInst).HasColumnType("datetime").HasDefaultValueSql("GetDate()");
            entity.Property(s => s.DateUpdate).HasColumnType("datetime").HasDefaultValueSql("GetDate()");
            entity.Property(s => s.Fio)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(s => s.Status)
                .IsRequired()
                .HasConversion(
                v => v.Value,
                v => Enumeration.FromValue<BitRequestStatus>(v));
            //entity.Property(s => s.Status).HasColumnType("int");
        }
    }
}
