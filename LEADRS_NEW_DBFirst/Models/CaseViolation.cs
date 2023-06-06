using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("CaseViolations", Schema = "DUI")]
[Index("CaseId", Name = "IX_CaseViolations_CaseId")]
[Index("ViolationId", Name = "IX_CaseViolations_ViolationId")]
public partial class CaseViolation
{
    [Key]
    public int CaseViolationId { get; set; }

    public int CaseId { get; set; }

    public int ViolationId { get; set; }

    public bool IsCitation { get; set; }

    public bool IsWarning { get; set; }

    public bool IsArrest { get; set; }

    public bool IsOther { get; set; }

    [StringLength(2000)]
    public string? Narrative { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("CaseViolations")]
    public virtual CaseHeader Case { get; set; } = null!;

    [ForeignKey("ViolationId")]
    [InverseProperty("CaseViolations")]
    public virtual TblOptViolation Violation { get; set; } = null!;
}
