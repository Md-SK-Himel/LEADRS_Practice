using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class ArrestingOfficerTypeConfig : IEntityTypeConfiguration<ArrestingOfficerType>
    {
        public void Configure(EntityTypeBuilder<ArrestingOfficerType> entity)
        {
            entity.ToTable($"TBL_OPT_AO_TYPES");

            entity.HasKey(m => m.ArrestingOfficerTypeId);

            entity.Property(m => m.ArrestingOfficerTypeId).ValueGeneratedOnAdd();
        }
    }
}
