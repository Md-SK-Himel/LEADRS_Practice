using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseDefendantConfig : IEntityTypeConfiguration<DreCaseDefendant>
    {
        public void Configure(EntityTypeBuilder<DreCaseDefendant> entity)
        {
            entity.ToTable($"DRE_DEFENDANTS");

            entity.HasKey(m => m.DreCaseDefendantId);

            entity.Property(m => m.DreCaseDefendantId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(f => f.Defendant).HasForeignKey<DreCaseDefendant>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
            
            entity.HasOne(m => m.ArrestingOfficerType).WithMany().HasForeignKey(f => f.ArrestingOfficerTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
