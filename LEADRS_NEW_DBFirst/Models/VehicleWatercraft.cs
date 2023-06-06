using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Vehicle_Watercraft", Schema = "DUI")]
[Index("MotorId", Name = "IX_Vehicle_Watercraft_MotorId")]
[Index("VehicleId", Name = "IX_Vehicle_Watercraft_VehicleId", IsUnique = true)]
[Index("VesselId", Name = "IX_Vehicle_Watercraft_VesselId")]
public partial class VehicleWatercraft
{
    [Key]
    public int VehicleWatercraftId { get; set; }

    public DateTime? RegExpDate { get; set; }

    [Column("HIN")]
    public string? Hin { get; set; }

    public int? MotorId { get; set; }

    public int? VesselId { get; set; }

    public string? VesselComments { get; set; }

    public string? BoatCondition { get; set; }

    [Column("Less50HP")]
    public bool Less50Hp { get; set; }

    public int VehicleId { get; set; }

    [ForeignKey("MotorId")]
    [InverseProperty("VehicleWatercrafts")]
    public virtual TblOptBwiMotor? Motor { get; set; }

    [ForeignKey("VehicleId")]
    [InverseProperty("VehicleWatercraft")]
    public virtual CaseVehicle Vehicle { get; set; } = null!;

    [ForeignKey("VesselId")]
    [InverseProperty("VehicleWatercrafts")]
    public virtual TblOptBwiVessel? Vessel { get; set; }
}
