using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseImageConfig : IEntityTypeConfiguration<DreCaseImage>
    {
        public void Configure(EntityTypeBuilder<DreCaseImage> entity)
        {
            entity.ToTable($"DRE_CASE_IMAGES");

            entity.HasKey(m => m.DreCaseImageId);
            entity.Property(m => m.DreCaseImageId).ValueGeneratedOnAdd();

            entity.Property(m => m.Image).HasColumnType("varbinary(max)");

            entity.HasOne(m => m.DreCase).WithMany().HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
