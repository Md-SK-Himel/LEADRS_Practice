using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Hair_Colors", Schema = "DUI")]
public partial class TblOptHairColor
{
    [Key]
    public int HairColorId { get; set; }

    [StringLength(50)]
    public string? HairColorDesc { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    public bool Active { get; set; }

    [InverseProperty("HairColor")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();
}
