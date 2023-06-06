using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FST_OneLegStandTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FST_OneLegStandTests_CaseId")]
[Index("FootWearId", Name = "IX_FST_OneLegStandTests_FootWearId")]
public partial class FstOneLegStandTest
{
    [Key]
    public int OneLegStandId { get; set; }

    public int CaseId { get; set; }

    public bool OneLegStandGiven { get; set; }

    public string? ReasonNotGiven { get; set; }

    public bool TestStopped { get; set; }

    public bool StatedOneLegStand { get; set; }

    public string FootStoodOn { get; set; } = null!;

    [StringLength(20)]
    public string FootRaised { get; set; } = null!;

    public int? FootWearId { get; set; }

    public bool NotKeepBalance { get; set; }

    public string? KeepBalanceExplain { get; set; }

    public bool Sways { get; set; }

    public string? SwaysDesc { get; set; }

    public bool Hops { get; set; }

    public string? HopsDesc { get; set; }

    public bool PutsFootDown { get; set; }

    public string? PutsFootDownDesc { get; set; }

    public bool UseArmsToBalance { get; set; }

    public string? ArmsBalanceDesc { get; set; }

    public int OneLegClues { get; set; }

    public string? Comments { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FstOneLegStandTests")]
    public virtual CaseHeader Case { get; set; } = null!;

    [ForeignKey("FootWearId")]
    [InverseProperty("FstOneLegStandTests")]
    public virtual TblOptFootWearType? FootWear { get; set; }
}
