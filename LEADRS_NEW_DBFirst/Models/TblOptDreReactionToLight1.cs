using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Reaction_To_Lights", Schema = "DUI")]
public partial class TblOptDreReactionToLight1
{
    [Key]
    public int DreReactionToLightId { get; set; }

    [StringLength(100)]
    public string? DreReactionToLightDesc { get; set; }

    public bool Active { get; set; }
}
