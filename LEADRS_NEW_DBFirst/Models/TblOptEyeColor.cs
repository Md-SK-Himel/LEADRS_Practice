using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Eye_Colors", Schema = "DUI")]
public partial class TblOptEyeColor
{
    [Key]
    public int EyeColorId { get; set; }

    [StringLength(50)]
    public string? EyeColorDesc { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    public bool Active { get; set; }

    [InverseProperty("EyeColor")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();
}
