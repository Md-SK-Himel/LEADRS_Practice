using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DRERoleConfig : IEntityTypeConfiguration<DRERole>
    {
        public void Configure(EntityTypeBuilder<DRERole> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_ROLES");

            entity.HasKey(m => m.DRERoleId);

            entity.Property(m => m.DRERoleId).ValueGeneratedOnAdd();
        }
    }
}
