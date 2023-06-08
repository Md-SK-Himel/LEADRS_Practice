using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseRombergBalanceConfig : IEntityTypeConfiguration<DreCaseRombergBalance>
    {
        public void Configure(EntityTypeBuilder<DreCaseRombergBalance> entity)
        {
            entity.ToTable($"DRE_CASE_RB");

            entity.HasKey(m => m.DreCaseRBId);

            entity.Property(m => m.DreCaseRBId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.RombergBalance).HasForeignKey<DreCaseRombergBalance>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
