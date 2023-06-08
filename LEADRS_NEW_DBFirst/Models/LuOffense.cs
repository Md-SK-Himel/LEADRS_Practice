using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_Offenses")]
public partial class LuOffense
{
    [Key]
    public int OffenseId { get; set; }

    [StringLength(10)]
    public string? OffenseCitation { get; set; }

    [StringLength(100)]
    public string OffenseDescription { get; set; } = null!;

    [StringLength(50)]
    public string? OffenseClassification { get; set; }

    [StringLength(20)]
    public string OffenseCode { get; set; } = null!;

    public int OffenseComplaintId { get; set; }

    public int OffenseType { get; set; }

    public bool OffenseFelony { get; set; }

    public bool OffenseIntoxilyzer { get; set; }

    public bool OffenseOpenContainer { get; set; }

    public bool OffensePriors { get; set; }

    public bool OffenseMinors { get; set; }

    public bool OffenseMinor { get; set; }

    public bool OffenseAssult { get; set; }

    public bool OffenseManslaughter { get; set; }

    [StringLength(50)]
    public string? OffenseTitle { get; set; }

    [StringLength(50)]
    public string? OffenseSubtitle { get; set; }

    public int OffenseOrder { get; set; }

    [Column("OffenseBWI")]
    public bool OffenseBwi { get; set; }

    public bool Active { get; set; }
}
