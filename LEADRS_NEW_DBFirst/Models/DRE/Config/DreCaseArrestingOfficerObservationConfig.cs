using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseArrestingOfficerObservationConfig : IEntityTypeConfiguration<DreCaseArrestingOfficerObservation>
    {
        public void Configure(EntityTypeBuilder<DreCaseArrestingOfficerObservation> entity)
        {
            entity.ToTable($"DRE_CASES_AO_OBS");

            entity.HasKey(m => m.ObservationId);

            entity.Property(m => m.ObservationId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.ArrestingOfficerObservation).HasForeignKey<DreCaseArrestingOfficerObservation>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
