using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCasePageConfig : IEntityTypeConfiguration<DreCasePage>
    {
        public void Configure(EntityTypeBuilder<DreCasePage> entity)
        {
            entity.ToTable($"DRE_CASE_PAGES");

            entity.HasKey(m => m.DreCasePageId);

            entity.Property(m => m.DreCasePageId).ValueGeneratedOnAdd();
        }
    }
}
