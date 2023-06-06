using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_REQUESTED", Schema = "DRE")]
public partial class TblOptDreRequested
{
    [Key]
    public int DreRequestedId { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    public bool Active { get; set; }

    [InverseProperty("DreRequested")]
    public virtual ICollection<DreCase> DreCases { get; set; } = new List<DreCase>();
}
