using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Outcomes", Schema = "DUI")]
public partial class TblOptOutcome
{
    [Key]
    public int OutcomeId { get; set; }

    [StringLength(50)]
    public string? OutcomeDescription { get; set; }

    public bool Active { get; set; }
}
