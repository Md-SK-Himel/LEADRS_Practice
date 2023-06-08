using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseOtherObservationConfig : IEntityTypeConfiguration<DreCaseOtherObservation>
    {
        public void Configure(EntityTypeBuilder<DreCaseOtherObservation> entity)
        {
            entity.ToTable($"DRE_Case_OtherObservation");

            entity.HasKey(m => m.OtherObservationId);

            entity.Property(m => m.OtherObservationId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(x => x.OtherObservation).HasForeignKey<DreCaseOtherObservation>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
