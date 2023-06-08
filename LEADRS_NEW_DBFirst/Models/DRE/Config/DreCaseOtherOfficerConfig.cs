using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseOtherOfficerConfig : IEntityTypeConfiguration<DreCaseOtherOfficer>
    {
        public void Configure(EntityTypeBuilder<DreCaseOtherOfficer> entity)
        {
            entity.ToTable($"DRE_CASES_OTHER_OFFICER");

            entity.HasKey(m => m.OtherOfficerId);

            entity.Property(m => m.OtherOfficerId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DRERole).WithMany().HasForeignKey(f => f.DreRoleId).OnDelete(DeleteBehavior.SetNull);


        }
    }
}
