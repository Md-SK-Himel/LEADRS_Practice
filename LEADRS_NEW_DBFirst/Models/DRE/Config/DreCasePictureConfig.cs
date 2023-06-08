using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCasePictureConfig : IEntityTypeConfiguration<DreCasePicture>
    {
        public void Configure(EntityTypeBuilder<DreCasePicture> entity)
        {
            entity.ToTable($"DRE_CASE_PIC");

            entity.HasKey(m => m.DreCasePictureId);
            entity.Property(m => m.DreCasePictureId).ValueGeneratedOnAdd();

            entity.Property(m => m.ImageData).HasColumnType("varbinary(max)");

            entity.HasOne(m => m.DreCase).WithMany().HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
