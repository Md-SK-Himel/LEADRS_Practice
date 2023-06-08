using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantAddresses", Schema = "DUI")]
[Index("AddressGroupId", Name = "IX_DefendantAddresses_AddressGroupId")]
[Index("CountyId", Name = "IX_DefendantAddresses_CountyId")]
[Index("DefendantId", Name = "IX_DefendantAddresses_DefendantId")]
[Index("EmStateId", Name = "IX_DefendantAddresses_EmStateId")]
[Index("OccStateId", Name = "IX_DefendantAddresses_OccStateId")]
[Index("StateId", Name = "IX_DefendantAddresses_StateId")]
public partial class DefendantAddress
{
    [Key]
    public int DefendantAddressId { get; set; }

    public int DefendantId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

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

    public string? DefOccupation { get; set; }

    public string? DefPhone { get; set; }

    public string? DefPlaceEmployment { get; set; }

    public string? DefWorkPhone { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactName { get; set; }

    public string? ContactPhone { get; set; }

    public string? EmAddress1 { get; set; }

    public string? EmAddress2 { get; set; }

    public string? EmCity { get; set; }

    public int? EmStateId { get; set; }

    public string? EmZipCode { get; set; }

    public string? OccAddress1 { get; set; }

    public string? OccAddress2 { get; set; }

    public string? OccCity { get; set; }

    public int? OccStateId { get; set; }

    public string? OccZipCode { get; set; }

    public string? Relationship { get; set; }

    [ForeignKey("AddressGroupId")]
    [InverseProperty("DefendantAddresses")]
    public virtual TblOptAddressGroup? AddressGroup { get; set; }

    [ForeignKey("CountyId")]
    [InverseProperty("DefendantAddresses")]
    public virtual TblOptCounty? County { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantAddresses")]
    public virtual Defendant Defendant { get; set; } = null!;

    [ForeignKey("EmStateId")]
    [InverseProperty("DefendantAddressEmStates")]
    public virtual TblOptState? EmState { get; set; }

    [ForeignKey("OccStateId")]
    [InverseProperty("DefendantAddressOccStates")]
    public virtual TblOptState? OccState { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("DefendantAddressStates")]
    public virtual TblOptState? State { get; set; }
}
