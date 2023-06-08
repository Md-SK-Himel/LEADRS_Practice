using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DRECaseConfig : IEntityTypeConfiguration<DRECase>
    {
        public void Configure(EntityTypeBuilder<DRECase> entity)
        {
            entity.ToTable($"DRE_CASES");

            entity.HasKey(m => m.DRECaseId);

            entity.Property(m => m.DRECaseId).ValueGeneratedOnAdd();

            entity.HasIndex(m => m.UniqueId).IsUnique();

            entity.HasOne(m => m.DREType).WithMany().HasForeignKey(f => f.DreTypeId).OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(m => m.DreRole).WithMany().HasForeignKey(f => f.DreRoleId).OnDelete(DeleteBehavior.SetNull);
            entity.HasOne(m => m.Status).WithMany().HasForeignKey(f => f.StatusId).OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(m => m.OtherOfficers).WithOne(f => f.DreCase).HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
