using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Road_Conditions", Schema = "DUI")]
public partial class TblOptRoadCondition
{
    [Key]
    public int RoadConditionId { get; set; }

    [StringLength(50)]
    public string? RoadConditionDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("RoadCondition")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
