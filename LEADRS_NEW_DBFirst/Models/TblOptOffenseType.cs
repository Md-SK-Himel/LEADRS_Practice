using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Offense_Types", Schema = "DUI")]
public partial class TblOptOffenseType
{
    [Key]
    public int OffenseTypeId { get; set; }

    [StringLength(100)]
    public string? OffenseTypeDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("OffenseType")]
    public virtual ICollection<TblOptSystemMode> TblOptSystemModes { get; set; } = new List<TblOptSystemMode>();
}
