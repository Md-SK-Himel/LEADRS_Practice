using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseWalkTurnConfig : IEntityTypeConfiguration<DreCaseWalkTurn>
    {
        public void Configure(EntityTypeBuilder<DreCaseWalkTurn> entity)
        {
            entity.ToTable($"DRE_CASE_WT");

            entity.HasKey(m => m.DreCaseWTId);

            entity.Property(m => m.DreCaseWTId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.WalkTurn).HasForeignKey<DreCaseWalkTurn>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
