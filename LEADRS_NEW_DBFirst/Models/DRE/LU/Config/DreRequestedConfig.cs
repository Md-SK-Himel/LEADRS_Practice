using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DreRequestedConfig : IEntityTypeConfiguration<DreRequested>
    {
        public void Configure(EntityTypeBuilder<DreRequested> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_REQUESTED");

            entity.HasKey(m => m.DreRequestedId);

            entity.Property(m => m.DreRequestedId).ValueGeneratedOnAdd();

        }
    }
}
