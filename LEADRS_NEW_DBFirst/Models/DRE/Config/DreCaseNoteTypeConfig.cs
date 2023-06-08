using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseNoteTypeConfig : IEntityTypeConfiguration<DreCaseNoteType>
    {
        public void Configure(EntityTypeBuilder<DreCaseNoteType> entity)
        {
            entity.ToTable($"DRE_CASE_NOTE_TYPES");

            entity.HasKey(m => m.DreCaseNoteTypeId);

            entity.Property(m => m.DreCaseNoteTypeId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCasePage).WithMany().HasForeignKey(f => f.DreCasePageId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
