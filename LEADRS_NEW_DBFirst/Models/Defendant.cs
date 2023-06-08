using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Defendants", Schema = "DUI")]
[Index("CaseId", Name = "IX_Defendants_CaseId")]
[Index("DlStateId", Name = "IX_Defendants_DlStateId")]
[Index("EducationId", Name = "IX_Defendants_EducationId")]
[Index("EthnicityId", Name = "IX_Defendants_EthnicityId")]
[Index("EyeColorId", Name = "IX_Defendants_EyeColorId")]
[Index("GenderId", Name = "IX_Defendants_GenderId")]
[Index("HairColorId", Name = "IX_Defendants_HairColorId")]
[Index("RaceId", Name = "IX_Defendants_RaceId")]
[Index("SkinComplexionSkinId", Name = "IX_Defendants_SkinComplexionSkinId")]
[Index("StepGrantTypeId", Name = "IX_Defendants_StepGrantTypeId")]
[Index("ZoneId", Name = "IX_Defendants_ZoneId")]
public partial class Defendant
{
    [Key]
    public int DefendantId { get; set; }

    public int CaseId { get; set; }

    public DateTime DateEntered { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    public int? RaceId { get; set; }

    public int? GenderId { get; set; }

    public int? HeightIn { get; set; }

    public int? HeightFt { get; set; }

    public int? EthnicityId { get; set; }

    [Column("DOB")]
    public DateTime Dob { get; set; }

    [Column("SSN")]
    public string? Ssn { get; set; }

    public int? HairColorId { get; set; }

    public int? EyeColorId { get; set; }

    public int? Weight { get; set; }

    public int? SkinId { get; set; }

    public int? SkinComplexionSkinId { get; set; }

    [StringLength(500)]
    public string? Tattoos { get; set; }

    [StringLength(50)]
    public string? Alias { get; set; }

    [StringLength(50)]
    public string? BirthPlace { get; set; }

    public string? Occupation { get; set; }

    public string? PlaceEmployment { get; set; }

    public string? MotherMaiden { get; set; }

    public bool Citizen { get; set; }

    public string? DlNumber { get; set; }

    public string? IdNumber { get; set; }

    public int? DlStateId { get; set; }

    public string? DlType { get; set; }

    public DateTime? DlExpire { get; set; }

    public int? EducationId { get; set; }

    public string? SpecialNeeds { get; set; }

    public string? Condition { get; set; }

    public bool SafetyBelt { get; set; }

    public bool Helmet { get; set; }

    public string? DpsSid { get; set; }

    public bool StepFunded { get; set; }

    public bool Training { get; set; }

    public string? ActivityType { get; set; }

    public int? OfficerStepShiftId { get; set; }

    public int? StepZoneId { get; set; }

    public int? ZoneId { get; set; }

    public int? StepGrantTypeId { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("Defendants")]
    public virtual CaseHeader Case { get; set; } = null!;

    [InverseProperty("Defendant")]
    public virtual DefendantAdditionalInfo? DefendantAdditionalInfo { get; set; }

    [InverseProperty("Defendant")]
    public virtual ICollection<DefendantAddress> DefendantAddresses { get; set; } = new List<DefendantAddress>();

    [InverseProperty("Defendant")]
    public virtual ICollection<DefendantEmContact> DefendantEmContacts { get; set; } = new List<DefendantEmContact>();

    [InverseProperty("Defendant")]
    public virtual DefendantInterview? DefendantInterview { get; set; }

    [InverseProperty("Defendant")]
    public virtual DefendantObservation? DefendantObservation { get; set; }

    [InverseProperty("Defendant")]
    public virtual ICollection<DefendantPhone> DefendantPhones { get; set; } = new List<DefendantPhone>();

    [InverseProperty("Defendant")]
    public virtual DefendantStatement? DefendantStatement { get; set; }

    [ForeignKey("DlStateId")]
    [InverseProperty("Defendants")]
    public virtual TblOptState? DlState { get; set; }

    [ForeignKey("EducationId")]
    [InverseProperty("Defendants")]
    public virtual TblOptEducation? Education { get; set; }

    [ForeignKey("EthnicityId")]
    [InverseProperty("Defendants")]
    public virtual TblOptEthnicity? Ethnicity { get; set; }

    [ForeignKey("EyeColorId")]
    [InverseProperty("Defendants")]
    public virtual TblOptEyeColor? EyeColor { get; set; }

    [ForeignKey("GenderId")]
    [InverseProperty("Defendants")]
    public virtual TblOptGender? Gender { get; set; }

    [ForeignKey("HairColorId")]
    [InverseProperty("Defendants")]
    public virtual TblOptHairColor? HairColor { get; set; }

    [ForeignKey("RaceId")]
    [InverseProperty("Defendants")]
    public virtual TblOptRace? Race { get; set; }

    [ForeignKey("SkinComplexionSkinId")]
    [InverseProperty("Defendants")]
    public virtual TblOptSkinComplexion? SkinComplexionSkin { get; set; }

    [ForeignKey("StepGrantTypeId")]
    [InverseProperty("Defendants")]
    public virtual TblOptStepGrantType? StepGrantType { get; set; }

    [ForeignKey("ZoneId")]
    [InverseProperty("Defendants")]
    public virtual TblOptZone? Zone { get; set; }
}
