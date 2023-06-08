using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseVitalSignConfig : IEntityTypeConfiguration<DreCaseVitalSign>
    {
        public void Configure(EntityTypeBuilder<DreCaseVitalSign> entity)
        {
            entity.ToTable($"DRE_CASES_VITAL_SIGNS");

            entity.HasKey(m => m.DreCaseVitalSignId);

            entity.Property(m => m.DreCaseVitalSignId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.VitalSign).HasForeignKey<DreCaseVitalSign>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
