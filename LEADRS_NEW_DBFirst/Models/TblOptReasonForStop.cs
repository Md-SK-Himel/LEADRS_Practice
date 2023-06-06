using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Reason_For_Stop", Schema = "DUI")]
public partial class TblOptReasonForStop
{
    [Key]
    public int ReasonForStopId { get; set; }

    [StringLength(100)]
    public string? ReasonForStopDescription { get; set; }

    public bool ReasonForStopTxt { get; set; }

    public bool Active { get; set; }

    [StringLength(50)]
    public string? AssocControl { get; set; }

    public bool? IsCrash { get; set; }

    public bool? Dwi { get; set; }

    public bool? Bwi { get; set; }

    [InverseProperty("ReasonForStop")]
    public virtual ICollection<ConditionReasonForStop> ConditionReasonForStops { get; set; } = new List<ConditionReasonForStop>();
}
