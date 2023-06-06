using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Zones", Schema = "DUI")]
public partial class TblOptZone
{
    [Key]
    public int ZoneId { get; set; }

    [StringLength(50)]
    public string? ZoneDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Zone")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();

    [InverseProperty("Zone")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();
}
