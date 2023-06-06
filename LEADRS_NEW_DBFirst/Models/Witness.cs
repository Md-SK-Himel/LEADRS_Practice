using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Witnesses", Schema = "DUI")]
[Index("AddressGroupId", Name = "IX_Witnesses_AddressGroupId")]
[Index("CaseId", Name = "IX_Witnesses_CaseId")]
[Index("CountyId", Name = "IX_Witnesses_CountyId")]
[Index("DlStateId", Name = "IX_Witnesses_DlStateId")]
[Index("GenderId", Name = "IX_Witnesses_GenderId")]
[Index("RaceId", Name = "IX_Witnesses_RaceId")]
[Index("StateId", Name = "IX_Witnesses_StateId")]
public partial class Witness
{
    [Key]
    public int WitnessId { get; set; }

    public int CaseId { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    public int? RaceId { get; set; }

    public int? GenderId { get; set; }

    [Column("DOB")]
    public DateTime? Dob { get; set; }

    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    [StringLength(20)]
    public string? WorkPhoneNumber { get; set; }

    [StringLength(20)]
    public string? CellPhoneNumber { get; set; }

    [StringLength(20)]
    public string? DlNumber { get; set; }

    public int? DlStateId { get; set; }

    [StringLength(9)]
    public string? SocialSecurityNumber { get; set; }

    public bool WrittenStatementProvided { get; set; }

    public bool IsVictim { get; set; }

    [StringLength(4000)]
    public string? WhatWitnessObserved { get; set; }

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

    [StringLength(2000)]
    public string? ExplainNoStatementReason { get; set; }

    [ForeignKey("AddressGroupId")]
    [InverseProperty("Witnesses")]
    public virtual TblOptAddressGroup? AddressGroup { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("Witnesses")]
    public virtual CaseHeader Case { get; set; } = null!;

    [ForeignKey("CountyId")]
    [InverseProperty("Witnesses")]
    public virtual TblOptCounty? County { get; set; }

    [ForeignKey("DlStateId")]
    [InverseProperty("WitnessDlStates")]
    public virtual TblOptState? DlState { get; set; }

    [ForeignKey("GenderId")]
    [InverseProperty("Witnesses")]
    public virtual TblOptGender? Gender { get; set; }

    [ForeignKey("RaceId")]
    [InverseProperty("Witnesses")]
    public virtual TblOptRace? Race { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("WitnessStates")]
    public virtual TblOptState? State { get; set; }
}
