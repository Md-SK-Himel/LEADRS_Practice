using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseIntoxilyzerReportConfig : IEntityTypeConfiguration<DreCaseIntoxilyzerReport>
    {
        public void Configure(EntityTypeBuilder<DreCaseIntoxilyzerReport> entity)
        {
            entity.ToTable($"DRE_CASE_INTOXILYZER_REPORT");

            entity.HasKey(m => m.DreCaseIntoxilyzerReportId);

            entity.Property(m => m.DreCaseIntoxilyzerReportId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.IntoxilyzerReport).HasForeignKey<DreCaseIntoxilyzerReport>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
