using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU.Config
{
    public class ReactionToLightConfig : IEntityTypeConfiguration<ReactionToLight>
    {
        public void Configure(EntityTypeBuilder<ReactionToLight> entity)
        {
            entity.ToTable($"TBL_OPT_DRE_REACTION_TO_LIGHT");

            entity.HasKey(m => m.ReactionToLightId);

            entity.Property(m => m.ReactionToLightId).ValueGeneratedOnAdd();

        }
    }
}
