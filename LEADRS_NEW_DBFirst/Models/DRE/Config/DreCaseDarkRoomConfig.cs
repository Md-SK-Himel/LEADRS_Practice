using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseDarkRoomConfig : IEntityTypeConfiguration<DreCaseDarkRoom>
    {
        public void Configure(EntityTypeBuilder<DreCaseDarkRoom> entity)
        {
            entity.ToTable($"DRE_CASES_DARK_ROOM");

            entity.HasKey(m => m.DreCaseDarkRoomId);

            entity.Property(m => m.DreCaseDarkRoomId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.DarkRoom).HasForeignKey<DreCaseDarkRoom>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
