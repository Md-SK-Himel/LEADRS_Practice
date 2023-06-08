using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DRETypeConfig : IEntityTypeConfiguration<DREType>
    {
        public void Configure(EntityTypeBuilder<DREType> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_TYPES");

            entity.HasKey(m => m.DRETypeId);

            entity.Property(m => m.DRETypeId).ValueGeneratedOnAdd();
            entity.HasData(
                new DREType { DRETypeId = 1, TypeName = "Enforcement", Description = "Description", Active = true },
                new DREType { DRETypeId = 2, TypeName = "Training", Description = "", Active = true },
                new DREType { DRETypeId = 3, TypeName = "Other", Description = "", Active = true }
                );
        }
    }
}
