using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScanStoreService.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScanStoreService.Domain
{
    public class BitRequestDetailsStatus : Enumeration
    {        
        public static readonly BitRequestDetailsStatus None
            = new BitRequestDetailsStatus(0, "Отсутствует");
        public static readonly BitRequestDetailsStatus New
            = new BitRequestDetailsStatus(1, "Новый");
        public static readonly BitRequestDetailsStatus Finished
            = new BitRequestDetailsStatus(2, "Завершенный");

        public BitRequestDetailsStatus() { }
        private BitRequestDetailsStatus(int value, string displayName) : base(value, displayName) { }
    }

    public partial class BitRequestDetail
    {

    }

    public class BitRequestDetailsConfiguration : IEntityTypeConfiguration<BitRequestDetail>
    {
        public void Configure(EntityTypeBuilder<BitRequestDetail> entity)
        {

            entity.HasKey(e => e.Id);
            entity.Property(s => s.Comment).HasMaxLength(255);
            entity.Property(s => s.DateInst).HasColumnType("datetime").HasDefaultValueSql("GetDate()");
            entity.Property(s => s.DateUpdate).HasColumnType("datetime").HasDefaultValueSql("GetDate()");
            entity.Property(s => s.Status)
                .IsRequired()
                .HasConversion(
                v => v.Value,
                v => Enumeration.FromValue<BitRequestDetailsStatus>(v));

        }

    }
    /*
    public class BitRequestDetailsStatusConfiguration : IEntityTypeConfiguration<BitRequestDetailsStatus>
    {
        public void Configure(EntityTypeBuilder<BitRequestDetailsStatus> entity)
        {
            entity.HasNoKey();
        }
    } */
}
