using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("CaseVehiclePassengers", Schema = "DUI")]
[Index("AddressGroupId", Name = "IX_CaseVehiclePassengers_AddressGroupId")]
[Index("CaseVehicleId", Name = "IX_CaseVehiclePassengers_CaseVehicleId")]
[Index("CountyId", Name = "IX_CaseVehiclePassengers_CountyId")]
[Index("GenderId", Name = "IX_CaseVehiclePassengers_GenderId")]
[Index("RaceId", Name = "IX_CaseVehiclePassengers_RaceId")]
[Index("StateId", Name = "IX_CaseVehiclePassengers_StateId")]
public partial class CaseVehiclePassenger
{
    [Key]
    public int CaseVehiclePassengerId { get; set; }

    public int CaseVehicleId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MothersMaidenName { get; set; }

    [Column("DOB")]
    public DateTime? Dob { get; set; }

    public int? RaceId { get; set; }

    public int? GenderId { get; set; }

    [Column("CPSNotified")]
    public bool Cpsnotified { get; set; }

    [Column("CPSCaseNumber")]
    public string? CpscaseNumber { get; set; }

    [Column("CPSNotifiedBy")]
    public string? CpsnotifiedBy { get; set; }

    [Column("CPSNotExplanation")]
    public string? CpsnotExplanation { get; set; }

    public string? Phone { get; set; }

    [Column("ID")]
    public string? Id { get; set; }

    [Column("DLNumber")]
    public string? Dlnumber { get; set; }

    [Column("DLStateId")]
    public int? DlstateId { get; set; }

    public int Intoxicated { get; set; }

    public bool Arrested { get; set; }

    public string? Charge { get; set; }

    public bool WearSafetyBelt { get; set; }

    public bool WearHelmet { get; set; }

    [StringLength(500)]
    public string? WhereSeated { get; set; }

    [StringLength(500)]
    public string? Comments { get; set; }

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
    [InverseProperty("CaseVehiclePassengers")]
    public virtual TblOptAddressGroup? AddressGroup { get; set; }

    [ForeignKey("CaseVehicleId")]
    [InverseProperty("CaseVehiclePassengers")]
    public virtual CaseVehicle CaseVehicle { get; set; } = null!;

    [ForeignKey("CountyId")]
    [InverseProperty("CaseVehiclePassengers")]
    public virtual TblOptCounty? County { get; set; }

    [ForeignKey("GenderId")]
    [InverseProperty("CaseVehiclePassengers")]
    public virtual TblOptGender? Gender { get; set; }

    [ForeignKey("RaceId")]
    [InverseProperty("CaseVehiclePassengers")]
    public virtual TblOptRace? Race { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("CaseVehiclePassengers")]
    public virtual TblOptState? State { get; set; }
}
