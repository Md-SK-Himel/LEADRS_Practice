using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseIntoxSalivaScreenConfig : IEntityTypeConfiguration<DreCaseIntoxSalivaScreen>
    {
        public void Configure(EntityTypeBuilder<DreCaseIntoxSalivaScreen> entity)
        {
            entity.ToTable($"DRE_CASE_INTOX_SALIVA_SCREEN");

            entity.HasKey(m => m.DreSalivaToxResultId);

            entity.Property(m => m.DreSalivaToxResultId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCaseIntoxilyzerReport).WithMany().HasForeignKey(f => f.DreCaseIntoxilyzerReportId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
