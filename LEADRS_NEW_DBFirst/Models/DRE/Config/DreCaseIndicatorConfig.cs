using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseIndicatorConfig : IEntityTypeConfiguration<DreCaseIndicator>
    {
        public void Configure(EntityTypeBuilder<DreCaseIndicator> entity)
        {
            entity.ToTable($"DRE_CASE_INDICATORS");

            entity.HasKey(m => m.DreCaseIndicatorId);

            entity.Property(m => m.DreCaseIndicatorId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne().HasForeignKey<DreCaseIndicator>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
