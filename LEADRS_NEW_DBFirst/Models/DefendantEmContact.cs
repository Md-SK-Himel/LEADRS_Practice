using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantEmContacts", Schema = "DUI")]
[Index("AddressGroupId", Name = "IX_DefendantEmContacts_AddressGroupId")]
[Index("CountyId", Name = "IX_DefendantEmContacts_CountyId")]
[Index("DefendantId", Name = "IX_DefendantEmContacts_DefendantId")]
[Index("StateId", Name = "IX_DefendantEmContacts_StateId")]
public partial class DefendantEmContact
{
    [Key]
    public int EmergencyContactId { get; set; }

    public int DefendantId { get; set; }

    public string? ContactName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? Relationship { get; set; }

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
    [InverseProperty("DefendantEmContacts")]
    public virtual TblOptAddressGroup? AddressGroup { get; set; }

    [ForeignKey("CountyId")]
    [InverseProperty("DefendantEmContacts")]
    public virtual TblOptCounty? County { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantEmContacts")]
    public virtual Defendant Defendant { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("DefendantEmContacts")]
    public virtual TblOptState? State { get; set; }
}
