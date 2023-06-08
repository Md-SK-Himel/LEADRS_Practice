using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class DpsDrugListConfig : IEntityTypeConfiguration<DpsDrugList>
    {
        public void Configure(EntityTypeBuilder<DpsDrugList> entity)
        {
            entity.ToTable($"TBL_OPT_DPS_DRUG_LIST");

            entity.HasKey(m => m.DpsDrugListId);

            entity.Property(m => m.DpsDrugListId).ValueGeneratedOnAdd();

        }
    }
}
