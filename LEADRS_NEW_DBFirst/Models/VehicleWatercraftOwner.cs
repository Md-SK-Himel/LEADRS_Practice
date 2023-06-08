using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Vehicle_Watercraft_Owner", Schema = "DUI")]
[Index("AddressGroupId", Name = "IX_Vehicle_Watercraft_Owner_AddressGroupId")]
[Index("CountyId", Name = "IX_Vehicle_Watercraft_Owner_CountyId")]
[Index("StateId", Name = "IX_Vehicle_Watercraft_Owner_StateId")]
[Index("VehicleId", Name = "IX_Vehicle_Watercraft_Owner_VehicleId", IsUnique = true)]
public partial class VehicleWatercraftOwner
{
    [Key]
    public int VehicleWatercraftOwnerId { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public int VehicleId { get; set; }

    public int? AddressGroupId { get; set; }

    [StringLength(50)]
    public string? Address1 { get; set; }

    [StringLength(50)]
    public string? Address2 { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [StringLength(10)]
    public string? ZipCode { get; set; }

    public int? StateId { get; set; }

    public int? CountyId { get; set; }

    public double Lat { get; set; }

    public double Lng { get; set; }

    [ForeignKey("AddressGroupId")]
    [InverseProperty("VehicleWatercraftOwners")]
    public virtual TblOptAddressGroup? AddressGroup { get; set; }

    [ForeignKey("CountyId")]
    [InverseProperty("VehicleWatercraftOwners")]
    public virtual TblOptCounty? County { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("VehicleWatercraftOwners")]
    public virtual TblOptState? State { get; set; }

    [ForeignKey("VehicleId")]
    [InverseProperty("VehicleWatercraftOwner")]
    public virtual CaseVehicle Vehicle { get; set; } = null!;
}
