using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Case_Outcome_Dismissals", Schema = "DUI")]
public partial class TblOptCaseOutcomeDismissal
{
    [Key]
    public int CaseOutcomeDismissalId { get; set; }

    [StringLength(100)]
    public string? DismissalText { get; set; }

    public bool Active { get; set; }
}
