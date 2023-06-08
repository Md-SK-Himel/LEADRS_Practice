using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Injury", Schema = "DUI")]
public partial class TblOptInjury
{
    [Key]
    public int InjuryId { get; set; }

    [StringLength(50)]
    public string? InjuryDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Injury")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
