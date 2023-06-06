using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("CaseOffenses", Schema = "DUI")]
[Index("ArrestAddressGroupId", Name = "IX_CaseOffenses_ArrestAddressGroupId")]
[Index("ArrestCountyId", Name = "IX_CaseOffenses_ArrestCountyId")]
[Index("ArrestStateId", Name = "IX_CaseOffenses_ArrestStateId")]
[Index("CaseId", Name = "IX_CaseOffenses_CaseId")]
[Index("OffAddressGroupId", Name = "IX_CaseOffenses_OffAddressGroupId")]
[Index("OffCountyId", Name = "IX_CaseOffenses_OffCountyId")]
[Index("OffStateId", Name = "IX_CaseOffenses_OffStateId")]
[Index("OffenseId", Name = "IX_CaseOffenses_OffenseId")]
public partial class CaseOffense
{
    [Key]
    public int CaseOffenseId { get; set; }

    [StringLength(500)]
    public string? Explanation { get; set; }

    public int CaseId { get; set; }

    public bool OpenContainers { get; set; }

    [StringLength(2000)]
    public string? ContainersDesc { get; set; }

    public int? OffenseId { get; set; }

    public DateTime? DateOfOff { get; set; }

    public DateTime? TimeOfOff { get; set; }

    public int? OffAddressGroupId { get; set; }

    [StringLength(50)]
    public string? OffAddress1 { get; set; }

    [StringLength(50)]
    public string? OffAddress2 { get; set; }

    [StringLength(50)]
    public string? OffCity { get; set; }

    [StringLength(10)]
    public string? OffZipCode { get; set; }

    public int? OffStateId { get; set; }

    public int? OffCountyId { get; set; }

    public double OffLat { get; set; }

    public double OffLng { get; set; }

    public DateTime? DateOfArrest { get; set; }

    public DateTime? TimeOfArrest { get; set; }

    public DateTime? DateOfBooking { get; set; }

    public DateTime? TimeOfBooking { get; set; }

    public DateTime? DateOfEventEnd { get; set; }

    public DateTime? TimeOfEventEnd { get; set; }

    public int? ArrestAddressGroupId { get; set; }

    [StringLength(100)]
    public string? ArrestAddress1 { get; set; }

    [StringLength(100)]
    public string? ArrestAddress2 { get; set; }

    [StringLength(100)]
    public string? ArrestCity { get; set; }

    public int? ArrestStateId { get; set; }

    [StringLength(13)]
    public string? ArrestZipCode { get; set; }

    public int? ArrestCountyId { get; set; }

    public double ArrestLat { get; set; }

    public double ArrestLng { get; set; }

    [Required]
    public bool? ChkOffAddressOfficerGeo { get; set; }

    [Required]
    public bool? ChkUpdateArrestInfo { get; set; }

    [InverseProperty("CaseOffense")]
    public virtual ICollection<AdditionalOffense> AdditionalOffenses { get; set; } = new List<AdditionalOffense>();

    [ForeignKey("ArrestAddressGroupId")]
    [InverseProperty("CaseOffenseArrestAddressGroups")]
    public virtual TblOptAddressGroup? ArrestAddressGroup { get; set; }

    [ForeignKey("ArrestCountyId")]
    [InverseProperty("CaseOffenseArrestCounties")]
    public virtual TblOptCounty? ArrestCounty { get; set; }

    [ForeignKey("ArrestStateId")]
    [InverseProperty("CaseOffenseArrestStates")]
    public virtual TblOptState? ArrestState { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("CaseOffenses")]
    public virtual CaseHeader Case { get; set; } = null!;

    [ForeignKey("OffAddressGroupId")]
    [InverseProperty("CaseOffenseOffAddressGroups")]
    public virtual TblOptAddressGroup? OffAddressGroup { get; set; }

    [ForeignKey("OffCountyId")]
    [InverseProperty("CaseOffenseOffCounties")]
    public virtual TblOptCounty? OffCounty { get; set; }

    [ForeignKey("OffStateId")]
    [InverseProperty("CaseOffenseOffStates")]
    public virtual TblOptState? OffState { get; set; }

    [ForeignKey("OffenseId")]
    [InverseProperty("CaseOffenses")]
    public virtual TblOptOffense? Offense { get; set; }
}
