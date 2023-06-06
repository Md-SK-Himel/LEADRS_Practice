using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantStatements", Schema = "DUI")]
[Index("AddressGroupId", Name = "IX_DefendantStatements_AddressGroupId")]
[Index("CountyId", Name = "IX_DefendantStatements_CountyId")]
[Index("DefendantId", Name = "IX_DefendantStatements_DefendantId", IsUnique = true)]
[Index("StateId", Name = "IX_DefendantStatements_StateId")]
public partial class DefendantStatement
{
    [Key]
    public int DefendantStatementId { get; set; }

    public int DefendantId { get; set; }

    public string? StatementAfterArrested { get; set; }

    public bool LeaveBusinessServedAlcohol { get; set; }

    [StringLength(511)]
    public string? NameOfBusiness { get; set; }

    [StringLength(511)]
    public string? WhoObservedDrinking { get; set; }

    public string? Under21AlcoholConsumeLocation { get; set; }

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

    [Required]
    public bool? DefendantRefusedStatement { get; set; }

    [Required]
    [Column("DidEMSResponse")]
    public bool? DidEmsresponse { get; set; }

    [Column("NamesOfEMSUnit")]
    [StringLength(150)]
    public string? NamesOfEmsunit { get; set; }

    [StringLength(60)]
    public string? Unit { get; set; }

    [StringLength(2000)]
    public string? WhatTheyDid { get; set; }

    [ForeignKey("AddressGroupId")]
    [InverseProperty("DefendantStatements")]
    public virtual TblOptAddressGroup? AddressGroup { get; set; }

    [ForeignKey("CountyId")]
    [InverseProperty("DefendantStatements")]
    public virtual TblOptCounty? County { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantStatement")]
    public virtual Defendant Defendant { get; set; } = null!;

    [ForeignKey("StateId")]
    [InverseProperty("DefendantStatements")]
    public virtual TblOptState? State { get; set; }
}
