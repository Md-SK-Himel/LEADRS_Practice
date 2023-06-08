using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Dismissals", Schema = "DUI")]
public partial class TblOptDismissal
{
    [Key]
    public int DismissalId { get; set; }

    [StringLength(50)]
    public string? DismissalDescription { get; set; }

    public bool Active { get; set; }
}
