using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Case_Outcome_Pleas", Schema = "DUI")]
public partial class TblOptCaseOutcomePlea
{
    [Key]
    public int CaseOutcomePleaId { get; set; }

    [StringLength(100)]
    public string? PleaText { get; set; }

    public bool Active { get; set; }
}
