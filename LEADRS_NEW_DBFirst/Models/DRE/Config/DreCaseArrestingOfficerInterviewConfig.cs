using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LEADRS_NEW_DBFirst.Models.DRE.Config
{
    public class DreCaseArrestingOfficerInterviewConfig : IEntityTypeConfiguration<DreCaseArrestingOfficerInterview>
    {
        public void Configure(EntityTypeBuilder<DreCaseArrestingOfficerInterview> entity)
        {
            entity.ToTable($"DRE_CASE_AO_INTERVIEWS");

            entity.HasKey(m => m.InterviewId);

            entity.Property(m => m.InterviewId).ValueGeneratedOnAdd();

            entity.HasOne(m => m.DreCase).WithOne(m => m.ArrestingOfficerInterview).HasForeignKey<DreCaseArrestingOfficerInterview>(f => f.DreCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
