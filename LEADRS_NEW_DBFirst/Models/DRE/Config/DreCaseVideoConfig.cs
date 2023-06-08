using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseVideoConfig : IEntityTypeConfiguration<DreCaseVideo>
    {
        public void Configure(EntityTypeBuilder<DreCaseVideo> entity)
        {
            entity.ToTable($"DRE_Case_Video");

            entity.HasKey(m => m.DreCaseVideoId);

            entity.Property(m => m.DreCaseVideoId).ValueGeneratedOnAdd();

            //entity.HasOne(m => m.DRECase).WithOne().HasForeignKey<DreCaseVideo>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(m => m.DreCase).WithMany().HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
