using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseFingerToNoseConfig : IEntityTypeConfiguration<DreCaseFingerToNose>
    {
        public void Configure(EntityTypeBuilder<DreCaseFingerToNose> entity)
        {
            entity.ToTable($"DRE_CASES_FTN");

            entity.HasKey(m => m.DreCaseFingerToNoseId);

            entity.Property(m => m.DreCaseFingerToNoseId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne().HasForeignKey<DreCaseFingerToNose>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
