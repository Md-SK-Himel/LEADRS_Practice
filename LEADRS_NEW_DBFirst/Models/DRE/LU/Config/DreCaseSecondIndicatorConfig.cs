using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DreCaseSecondIndicatorConfig : IEntityTypeConfiguration<DreCaseSecondIndicator>
    {
        public void Configure(EntityTypeBuilder<DreCaseSecondIndicator> entity)
    {
        entity.ToTable($"TBL_OPT_DRE_SECOND_INDICATORS");

        entity.HasKey(m => m.DreCaseSecondIndicatorId);

        entity.Property(m => m.DreCaseSecondIndicatorId).ValueGeneratedOnAdd();

    }
}
}
