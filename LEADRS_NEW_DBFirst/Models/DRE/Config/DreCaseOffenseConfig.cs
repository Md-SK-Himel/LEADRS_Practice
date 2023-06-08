using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseOffenseConfig : IEntityTypeConfiguration<DreCaseOffense>
    {
        public void Configure(EntityTypeBuilder<DreCaseOffense> entity)
        {
            entity.ToTable($"DRE_CASES_OFFENSES");

            entity.HasKey(m => m.DreCaseOffenseId);

            entity.Property(m => m.DreCaseOffenseId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne().HasForeignKey<DreCaseOffense>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
