using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SpecimenUrineTests", Schema = "DUI")]
[Index("MoreLessIntoxId", Name = "IX_SpecimenUrineTests_MoreLessIntoxId")]
[Index("SpecimenReportId", Name = "IX_SpecimenUrineTests_SpecimenReportId")]
public partial class SpecimenUrineTest
{
    [Key]
    public int SpecimenUrineTestId { get; set; }

    public int SpecimenReportId { get; set; }

    public DateTime? UrineCollectedDate { get; set; }

    public DateTime? UrineCollectedTime { get; set; }

    [StringLength(100)]
    public string? WitnessedBy { get; set; }

    public string? Results { get; set; }

    [StringLength(100)]
    public string? LabName { get; set; }

    [StringLength(50)]
    public string? LabAddress { get; set; }

    [StringLength(50)]
    public string? LabCity { get; set; }

    [StringLength(20)]
    public string? LabPhone { get; set; }

    public int? MoreLessIntoxId { get; set; }

    [ForeignKey("MoreLessIntoxId")]
    [InverseProperty("SpecimenUrineTests")]
    public virtual TblOptMoreLessIntoxicated? MoreLessIntox { get; set; }

    [ForeignKey("SpecimenReportId")]
    [InverseProperty("SpecimenUrineTests")]
    public virtual SpecimenReport SpecimenReport { get; set; } = null!;
}
