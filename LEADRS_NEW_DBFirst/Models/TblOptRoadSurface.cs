using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Road_Surface", Schema = "DUI")]
public partial class TblOptRoadSurface
{
    [Key]
    public int RoadSurfaceId { get; set; }

    [StringLength(50)]
    public string? RoadSurfaceDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("RoadSurface")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
