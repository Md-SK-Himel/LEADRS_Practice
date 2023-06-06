using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Conditions", Schema = "DUI")]
[Index("CaseId", Name = "IX_Conditions_CaseId")]
[Index("InjuryId", Name = "IX_Conditions_InjuryId")]
[Index("LightConditionId", Name = "IX_Conditions_LightConditionId")]
[Index("RadarTypeId", Name = "IX_Conditions_RadarTypeId")]
[Index("RoadConditionId", Name = "IX_Conditions_RoadConditionId")]
[Index("RoadSurfaceId", Name = "IX_Conditions_RoadSurfaceId")]
[Index("SurfaceId", Name = "IX_Conditions_SurfaceId")]
[Index("WeatherId", Name = "IX_Conditions_WeatherId")]
[Index("ZoneId", Name = "IX_Conditions_ZoneId")]
public partial class Condition
{
    [Key]
    public int ConditionId { get; set; }

    public int CaseId { get; set; }

    public int? LightConditionId { get; set; }

    public int? WeatherId { get; set; }

    public int? SurfaceId { get; set; }

    public int? RoadConditionId { get; set; }

    public int? RoadSurfaceId { get; set; }

    public int? ZoneId { get; set; }

    public bool RoadMarked { get; set; }

    public string? DescriptionTrafficLanes { get; set; }

    public string? Cause { get; set; }

    public bool SpeedAsFactor { get; set; }

    public int? PostedSpeedLimit { get; set; }

    public int? ObservedSpeed { get; set; }

    public bool OfficerRadarTrained { get; set; }

    public bool RadarChecked { get; set; }

    public int? RadarTypeId { get; set; }

    public string? HowDefendantWasObserved { get; set; }

    public string? StatementOnInitialContact { get; set; }

    public bool SuspectResistance { get; set; }

    public bool ResistanceVerbalThreat { get; set; }

    public bool ResistancePassive { get; set; }

    public bool ResistancePhysical { get; set; }

    public int? InjuryId { get; set; }

    public int? WaterSurfaceId { get; set; }

    public int? WindSpeedId { get; set; }

    public int? WaveHeightId { get; set; }

    [Required]
    public bool? ParksAndWildLifeStop { get; set; }

    public bool? ResistanceNone { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("Conditions")]
    public virtual CaseHeader Case { get; set; } = null!;

    [InverseProperty("Condition")]
    public virtual ICollection<ConditionReasonForStop> ConditionReasonForStops { get; set; } = new List<ConditionReasonForStop>();

    [ForeignKey("InjuryId")]
    [InverseProperty("Conditions")]
    public virtual TblOptInjury? Injury { get; set; }

    [ForeignKey("LightConditionId")]
    [InverseProperty("Conditions")]
    public virtual TblOptLightCondition? LightCondition { get; set; }

    [ForeignKey("RadarTypeId")]
    [InverseProperty("Conditions")]
    public virtual TblOptRadarType? RadarType { get; set; }

    [ForeignKey("RoadConditionId")]
    [InverseProperty("Conditions")]
    public virtual TblOptRoadCondition? RoadCondition { get; set; }

    [ForeignKey("RoadSurfaceId")]
    [InverseProperty("Conditions")]
    public virtual TblOptRoadSurface? RoadSurface { get; set; }

    [ForeignKey("SurfaceId")]
    [InverseProperty("Conditions")]
    public virtual TblOptSurface? Surface { get; set; }

    [ForeignKey("WeatherId")]
    [InverseProperty("Conditions")]
    public virtual TblOptWeather? Weather { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("Conditions")]
    public virtual TblOptZone? Zone { get; set; }
}
