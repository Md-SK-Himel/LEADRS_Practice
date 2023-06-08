using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseArrestingOfficerFSTConfig : IEntityTypeConfiguration<DreCaseArrestingOfficerFST>
    {
        public void Configure(EntityTypeBuilder<DreCaseArrestingOfficerFST> entity)
        {
            entity.ToTable($"DRE_CASE_AO_FST");

            entity.HasKey(m => m.ArrestingOfficerFSTId);

            entity.Property(m => m.ArrestingOfficerFSTId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne().HasForeignKey<DreCaseArrestingOfficerFST>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
