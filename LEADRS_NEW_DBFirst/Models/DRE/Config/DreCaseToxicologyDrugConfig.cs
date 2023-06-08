using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseToxicologyDrugConfig : IEntityTypeConfiguration<DreCaseToxicologyDrug>
    {
        public void Configure(EntityTypeBuilder<DreCaseToxicologyDrug> entity)
        {
            entity.ToTable($"DRE_CASE_TOXICOLOGY_DRUG");

            entity.HasKey(m => m.DreCaseToxDrugId);

            entity.Property(m => m.DreCaseToxDrugId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithMany().HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
