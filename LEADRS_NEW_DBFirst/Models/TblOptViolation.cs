using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Violations", Schema = "DUI")]
public partial class TblOptViolation
{
    [Key]
    public int ViolationId { get; set; }

    [StringLength(100)]
    public string? ViolationDeswc { get; set; }

    public bool Active { get; set; }

    public int? SortOrder { get; set; }

    public bool? IsArrest { get; set; }

    public bool? IsOther { get; set; }

    [InverseProperty("Violation")]
    public virtual ICollection<CaseViolation> CaseViolations { get; set; } = new List<CaseViolation>();
}
