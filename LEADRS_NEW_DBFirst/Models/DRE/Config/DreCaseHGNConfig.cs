using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    internal class DreCaseHGNConfig : IEntityTypeConfiguration<DreCaseHGN>
    {
        public void Configure(EntityTypeBuilder<DreCaseHGN> entity)
        {
            entity.ToTable($"DRE_CASE_HGN");

            entity.HasKey(m => m.DreCaseHgnId);

            entity.Property(m => m.DreCaseHgnId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithMany(m => m.Hgns).HasForeignKey(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);

            entity.Property(e => e.CluesLeft).HasMaxLength(4);
            entity.Property(e => e.CluesRight).HasMaxLength(4);
            entity.Property(e => e.CluesTotal).HasMaxLength(4);

            entity.Property(e => e.HeadInjuriesComments).HasMaxLength(2000);
            entity.Property(e => e.ContactDescription).HasMaxLength(2000);
            entity.Property(e => e.PupilSizeComments).HasMaxLength(2000);
            entity.Property(e => e.StimulusComments).HasMaxLength(2000);
            entity.Property(e => e.OtherComments).HasMaxLength(2000);
        }
    }
}
