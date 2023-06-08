using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("StepZones", Schema = "DUI")]
[Index("StepGrantTypeId", Name = "IX_StepZones_StepGrantTypeId")]
public partial class StepZone
{
    [Key]
    public int StepZoneId { get; set; }

    public int? DepartmentId { get; set; }

    public int? LocationId { get; set; }

    public int ZoneNumber { get; set; }

    [StringLength(300)]
    public string? ZoneDesc { get; set; }

    public int? StepGrantTypeId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    [ForeignKey("StepGrantTypeId")]
    [InverseProperty("StepZones")]
    public virtual TblOptStepGrantType? StepGrantType { get; set; }

    [InverseProperty("StepZone")]
    public virtual ICollection<StepOfficerShiftZone> StepOfficerShiftZones { get; set; } = new List<StepOfficerShiftZone>();
}
