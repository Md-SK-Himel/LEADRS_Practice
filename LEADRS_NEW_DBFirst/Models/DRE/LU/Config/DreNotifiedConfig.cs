using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DreNotifiedConfig : IEntityTypeConfiguration<DreNotified>
    {
        public void Configure(EntityTypeBuilder<DreNotified> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_NOTIFIED");

            entity.HasKey(m => m.DreNotifiedId);

            entity.Property(m => m.DreNotifiedId).ValueGeneratedOnAdd();

        }
    }
}
