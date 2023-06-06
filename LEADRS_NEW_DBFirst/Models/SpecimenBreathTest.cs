using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SpecimenBreathTests", Schema = "DUI")]
[Index("MoreLessIntoxId", Name = "IX_SpecimenBreathTests_MoreLessIntoxId")]
[Index("SpecimenReportId", Name = "IX_SpecimenBreathTests_SpecimenReportId")]
[Index("VerifyTempId", Name = "IX_SpecimenBreathTests_VerifyTempId")]
public partial class SpecimenBreathTest
{
    [Key]
    public int SpecimenBreathTestId { get; set; }

    public int SpecimenReportId { get; set; }

    public DateTime? TestGivenDate { get; set; }

    public DateTime? WaitingPeriodTime { get; set; }

    public int? VerifyTempId { get; set; }

    [StringLength(2000)]
    public string? SubjectComments { get; set; }

    public bool BreathIntoxiOperator { get; set; }

    [StringLength(50)]
    public string? OperatorName { get; set; }

    [StringLength(50)]
    public string? OperatorAgency { get; set; }

    [StringLength(50)]
    public string? RecordNumber { get; set; }

    [StringLength(50)]
    public string? SerialNumber { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Result1Number { get; set; }

    public DateTime? Result1Time { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Result2Number { get; set; }

    public DateTime? Result2Time { get; set; }

    public int? MoreLessIntoxId { get; set; }

    [ForeignKey("MoreLessIntoxId")]
    [InverseProperty("SpecimenBreathTests")]
    public virtual TblOptMoreLessIntoxicated? MoreLessIntox { get; set; }

    [ForeignKey("SpecimenReportId")]
    [InverseProperty("SpecimenBreathTests")]
    public virtual SpecimenReport SpecimenReport { get; set; } = null!;

    [ForeignKey("VerifyTempId")]
    [InverseProperty("SpecimenBreathTests")]
    public virtual TblOptIntoxVerifyTemp? VerifyTemp { get; set; }
}
