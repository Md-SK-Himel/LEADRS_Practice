using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Light_Conditions", Schema = "DUI")]
public partial class TblOptLightCondition
{
    [Key]
    public int LightConditionId { get; set; }

    [StringLength(50)]
    public string? LightConditionDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("LightCondition")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
