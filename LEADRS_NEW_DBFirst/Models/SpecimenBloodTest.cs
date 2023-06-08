using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("SpecimenBloodTests", Schema = "DUI")]
[Index("EmployedId", Name = "IX_SpecimenBloodTests_EmployedId")]
[Index("MoreLessIntoxId", Name = "IX_SpecimenBloodTests_MoreLessIntoxId")]
[Index("SpecimenReportId", Name = "IX_SpecimenBloodTests_SpecimenReportId")]
public partial class SpecimenBloodTest
{
    [Key]
    public int SpecimenBloodTestId { get; set; }

    public int SpecimenReportId { get; set; }

    [StringLength(50)]
    public string? BloodVials { get; set; }

    public int? MoreLessIntoxId { get; set; }

    [StringLength(50)]
    public string? PersonName { get; set; }

    [StringLength(20)]
    public string? PersonPhone { get; set; }

    [StringLength(100)]
    public string? EmployerName { get; set; }

    public int? EmployedId { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }

    [StringLength(500)]
    public string? LocationDescription { get; set; }

    public DateTime? SpecimenDate { get; set; }

    [Column("BWI_Preservative")]
    public bool BwiPreservative { get; set; }

    [Column("BWI_NoAlcohol")]
    public bool BwiNoAlcohol { get; set; }

    [Column("BWI_Rotated")]
    public bool BwiRotated { get; set; }

    [StringLength(100)]
    public string? LabName { get; set; }

    [StringLength(50)]
    public string? LabAddress { get; set; }

    [StringLength(50)]
    public string? LabCity { get; set; }

    [StringLength(20)]
    public string? LabPhone { get; set; }

    [ForeignKey("EmployedId")]
    [InverseProperty("SpecimenBloodTests")]
    public virtual TblOptEmployedPwd? Employed { get; set; }

    [ForeignKey("MoreLessIntoxId")]
    [InverseProperty("SpecimenBloodTests")]
    public virtual TblOptMoreLessIntoxicated? MoreLessIntox { get; set; }

    [ForeignKey("SpecimenReportId")]
    [InverseProperty("SpecimenBloodTests")]
    public virtual SpecimenReport SpecimenReport { get; set; } = null!;
}
