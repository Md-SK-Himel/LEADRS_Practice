using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("FieldSobrietyTests", Schema = "DUI")]
[Index("CaseId", Name = "IX_FieldSobrietyTests_CaseId")]
public partial class FieldSobrietyTest
{
    [Key]
    public int FieldSobrietyTestId { get; set; }

    public int CaseId { get; set; }

    [Column("FSTGiven")]
    public bool Fstgiven { get; set; }

    [Column("WhyNotGivenFST")]
    public string? WhyNotGivenFst { get; set; }

    public bool DefendantRefused { get; set; }

    public bool PhysicalInjuries { get; set; }

    public bool DefMoreThan65 { get; set; }

    public bool TimeAshore { get; set; }

    public bool OnWater { get; set; }

    [Column("SeatedFST")]
    public bool SeatedFst { get; set; }

    public bool AttachNote { get; set; }

    public string? Notes { get; set; }

    public DateTime? TimeAshoreDate { get; set; }

    [Column("TimeStartedFST")]
    public DateTime? TimeStartedFst { get; set; }

    public bool WaterTestGiven { get; set; }

    public string? WhyNotWaterTest { get; set; }

    public bool PhysicalProblem { get; set; }

    public string? PhysicalProblemDesc { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("FieldSobrietyTests")]
    public virtual CaseHeader Case { get; set; } = null!;
}
