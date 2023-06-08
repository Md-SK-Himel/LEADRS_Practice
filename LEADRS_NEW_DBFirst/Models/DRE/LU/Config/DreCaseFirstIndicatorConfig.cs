using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DreCaseFirstIndicatorConfig : IEntityTypeConfiguration<DreCaseFirstIndicator>
    {
        public void Configure(EntityTypeBuilder<DreCaseFirstIndicator> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_FIRST_INDICATORS");

            entity.HasKey(m => m.DreCaseFirstIndicatorId);

            entity.Property(m => m.DreCaseFirstIndicatorId).ValueGeneratedOnAdd();

        }
    }
}
