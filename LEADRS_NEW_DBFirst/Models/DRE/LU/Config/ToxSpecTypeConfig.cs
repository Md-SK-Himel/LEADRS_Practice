using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class ToxSpecTypeConfig : IEntityTypeConfiguration<DreCaseToxSpecType>
    {
        public void Configure(EntityTypeBuilder<DreCaseToxSpecType> entity)
        {
            entity.ToTable($"TBL_OPT_TOX_SPEC_TYPE");

            entity.HasKey(m => m.ToxSpecTypeId);

            entity.Property(m => m.ToxSpecTypeId).ValueGeneratedOnAdd();

        }
    }
}
