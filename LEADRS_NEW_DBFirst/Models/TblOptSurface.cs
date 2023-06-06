using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Surfaces", Schema = "DUI")]
public partial class TblOptSurface
{
    [Key]
    public int SurfaceId { get; set; }

    [StringLength(50)]
    public string? SurfaceDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Surface")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
