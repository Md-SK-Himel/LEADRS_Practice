using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("ClerkSupplement")]
[Index("OrganisationId", Name = "IX_ClerkSupplement_OrganisationID")]
public partial class ClerkSupplement
{
    [Key]
    [Column("ClerkSupplementID")]
    public int ClerkSupplementId { get; set; }

    [Column("OfficerID")]
    public int OfficerId { get; set; }

    [Column("OrganisationID")]
    public int? OrganisationId { get; set; }

    public string? CaseNumber { get; set; }

    [Column("CaseID")]
    public int CaseId { get; set; }

    [Required]
    public bool? Submitted { get; set; }

    public string? Supplement { get; set; }

    [Required]
    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    [ForeignKey("OrganisationId")]
    [InverseProperty("ClerkSupplements")]
    public virtual Organization? Organisation { get; set; }
}
