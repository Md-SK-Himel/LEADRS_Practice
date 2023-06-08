using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseNoteConfig : IEntityTypeConfiguration<DreCaseNote>
    {
        public void Configure(EntityTypeBuilder<DreCaseNote> entity)
        {
            entity.ToTable($"DRE_CASE_NOTES");

            entity.HasKey(m => m.DreCaseNoteId);

            entity.Property(m => m.DreCaseNoteId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithMany().HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(m => m.DreCaseNoteType).WithMany().HasForeignKey(f => f.DreCaseNoteTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
