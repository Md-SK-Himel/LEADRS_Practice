using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Case_Outcome_Trials", Schema = "DUI")]
public partial class TblOptCaseOutcomeTrial
{
    [Key]
    public int CaseOutcomeTrialId { get; set; }

    [StringLength(100)]
    public string? TrialText { get; set; }

    public bool Active { get; set; }
}
