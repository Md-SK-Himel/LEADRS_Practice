using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseObservationsConfig : IEntityTypeConfiguration<DreCaseObservations>
    {
        public void Configure(EntityTypeBuilder<DreCaseObservations> entity)
        {
            entity.ToTable($"DRE_CASES_OBS");

            entity.HasKey(m => m.DreCaseObservationsId);

            entity.Property(m => m.DreCaseObservationsId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.CaseObservations).HasForeignKey<DreCaseObservations>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
