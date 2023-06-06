using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_NOTIFIED", Schema = "DRE")]
public partial class TblOptDreNotified
{
    [Key]
    public int DreNotifiedId { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    public bool Active { get; set; }

    [InverseProperty("DreNotified")]
    public virtual ICollection<DreCase> DreCases { get; set; } = new List<DreCase>();
}
