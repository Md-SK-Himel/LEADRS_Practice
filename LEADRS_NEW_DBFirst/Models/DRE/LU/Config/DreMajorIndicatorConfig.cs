using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DreMajorIndicatorConfig : IEntityTypeConfiguration<DreMajorIndicator>
    {
        public void Configure(EntityTypeBuilder<DreMajorIndicator> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_MAJOR_INDICATORS ");

            entity.HasKey(m => m.DreMajorIndicatorId);

            entity.Property(m => m.DreMajorIndicatorId).ValueGeneratedOnAdd();

        }
    }
}
