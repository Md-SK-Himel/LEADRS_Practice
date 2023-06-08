using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DRECaseStatusConfig : IEntityTypeConfiguration<DRECaseStatus>
    {
        public void Configure(EntityTypeBuilder<DRECaseStatus> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_CASE_STATUS");

            entity.HasKey(m => m.DRECaseStatusId);

            entity.Property(m => m.DRECaseStatusId).ValueGeneratedOnAdd();
        }
    }
}
