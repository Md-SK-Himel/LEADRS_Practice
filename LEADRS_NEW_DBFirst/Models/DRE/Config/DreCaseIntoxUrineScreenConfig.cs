using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseIntoxUrineScreenConfig : IEntityTypeConfiguration<DreCaseIntoxUrineScreen>
    {
        public void Configure(EntityTypeBuilder<DreCaseIntoxUrineScreen> entity)
        {
            entity.ToTable($"DRE_CASE_INTOX_URINE_SCREEN");

            entity.HasKey(m => m.DreUrineToxResultId);

            entity.Property(m => m.DreUrineToxResultId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCaseIntoxilyzerReport).WithMany().HasForeignKey(f => f.DreCaseIntoxilyzerReportId).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
