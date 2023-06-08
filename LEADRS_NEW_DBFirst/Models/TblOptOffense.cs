using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Offenses", Schema = "DUI")]
public partial class TblOptOffense
{
    [Key]
    public int OffenseId { get; set; }

    [StringLength(10)]
    public string? OffenseCitation { get; set; }

    [StringLength(100)]
    public string? OffenseDescription { get; set; }

    [StringLength(50)]
    public string? OffenseClassification { get; set; }

    [StringLength(10)]
    public string? OffenseCode { get; set; }

    public int? OffenseComplaintId { get; set; }

    public short OffenseType { get; set; }

    public bool? OffenseFelony { get; set; }

    public bool OffenseIntoxilizer { get; set; }

    public bool OffenseOpenContainer { get; set; }

    public bool OffensePriors { get; set; }

    public bool OffenseMinors { get; set; }

    public bool? OffenseMinor { get; set; }

    public bool? OffenseAssult { get; set; }

    public bool? OffenseManslaughter { get; set; }

    [StringLength(50)]
    public string? OffenseTitle { get; set; }

    [StringLength(50)]
    public string? OffenseSubtitle { get; set; }

    public int? OffenseOrder { get; set; }

    public bool? OffenseBwi { get; set; }

    [StringLength(200)]
    public string? Mark43OffDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Offense")]
    public virtual ICollection<CaseOffense> CaseOffenses { get; set; } = new List<CaseOffense>();
}
