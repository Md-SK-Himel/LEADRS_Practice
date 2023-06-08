using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Step_Dar_Event_Types", Schema = "DUI")]
public partial class TblOptStepDarEventType
{
    [Key]
    public int StepDarEventTypeId { get; set; }

    [StringLength(100)]
    public string? StepDarEventTypeDesc { get; set; }

    public bool Active { get; set; }
}
