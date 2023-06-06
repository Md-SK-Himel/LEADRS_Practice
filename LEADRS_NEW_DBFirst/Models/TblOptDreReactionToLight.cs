using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_REACTION_TO_LIGHT", Schema = "DRE")]
public partial class TblOptDreReactionToLight
{
    [Key]
    public int ReactionToLightId { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public bool Active { get; set; }
}
