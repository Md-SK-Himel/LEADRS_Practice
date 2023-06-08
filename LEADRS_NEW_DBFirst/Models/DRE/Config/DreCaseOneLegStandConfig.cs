using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseOneLegStandConfig : IEntityTypeConfiguration<DreCaseOneLegStand>
    {
        public void Configure(EntityTypeBuilder<DreCaseOneLegStand> entity)
        {
            entity.ToTable($"DRE_CASE_OLS");

            entity.HasKey(m => m.DreCaseOLSId);

            entity.Property(m => m.DreCaseOLSId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.OneLegStand).HasForeignKey<DreCaseOneLegStand>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
