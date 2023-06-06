using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("CaseVehicles", Schema = "DUI")]
[Index("BoatHullShapeId", Name = "IX_CaseVehicles_BoatHullShapeId")]
[Index("CaseId", Name = "IX_CaseVehicles_CaseId")]
[Index("StateId", Name = "IX_CaseVehicles_StateId")]
[Index("VehicleColorId", Name = "IX_CaseVehicles_VehicleColorId")]
[Index("VehicleMakeId", Name = "IX_CaseVehicles_VehicleMakeId")]
[Index("VehicleModelId", Name = "IX_CaseVehicles_VehicleModelId")]
[Index("VehicleStyleId", Name = "IX_CaseVehicles_VehicleStyleId")]
[Index("VehicleTypeId", Name = "IX_CaseVehicles_VehicleTypeId")]
public partial class CaseVehicle
{
    [Key]
    public int CaseVehicleId { get; set; }

    public int CaseId { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? VehicleMakeId { get; set; }

    public int? VehicleModelId { get; set; }

    public int? VehicleStyleId { get; set; }

    public int? VehicleColorId { get; set; }

    [StringLength(4)]
    public string? Year { get; set; }

    [StringLength(20)]
    public string? LicensePlate { get; set; }

    public int? StateId { get; set; }

    [Column("VIN")]
    [StringLength(15)]
    public string? Vin { get; set; }

    public bool Impounded { get; set; }

    [StringLength(50)]
    public string? ImpoundedBy { get; set; }

    [StringLength(100)]
    public string? StoredAt { get; set; }

    public bool VehiclePlacedOnHold { get; set; }

    [StringLength(500)]
    public string? HoldReason { get; set; }

    public int? VehicleWatercraftId { get; set; }

    public int? VehicleWatercraftOwnerId { get; set; }

    [StringLength(4)]
    public string? LicenseYear { get; set; }

    [Required]
    public bool? VehicleCommercial { get; set; }

    [Required]
    public bool? VehicleHazMat { get; set; }

    public string? VehicleCondition { get; set; }

    public int? BoatHullShapeId { get; set; }

    [ForeignKey("BoatHullShapeId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptNcicVehicleBodyStyle? BoatHullShape { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("CaseVehicles")]
    public virtual CaseHeader Case { get; set; } = null!;

    [InverseProperty("CaseVehicle")]
    public virtual ICollection<CaseVehiclePassenger> CaseVehiclePassengers { get; set; } = new List<CaseVehiclePassenger>();

    [ForeignKey("StateId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptState? State { get; set; }

    [ForeignKey("VehicleColorId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptNcicColor? VehicleColor { get; set; }

    [ForeignKey("VehicleMakeId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptNcicTransportMake? VehicleMake { get; set; }

    [ForeignKey("VehicleModelId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptNcicVehicleModel? VehicleModel { get; set; }

    [ForeignKey("VehicleStyleId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptNcicVehcileStyleType? VehicleStyle { get; set; }

    [ForeignKey("VehicleTypeId")]
    [InverseProperty("CaseVehicles")]
    public virtual TblOptNcicTransportType? VehicleType { get; set; }

    [InverseProperty("Vehicle")]
    public virtual VehicleWatercraft? VehicleWatercraft { get; set; }

    [InverseProperty("Vehicle")]
    public virtual VehicleWatercraftOwner? VehicleWatercraftOwner { get; set; }
}
