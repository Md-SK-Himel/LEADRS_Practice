using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_DEFENDANTS", Schema = "DRE")]
[Index("ArrestingOfficerTypeId", Name = "IX_DRE_DEFENDANTS_ArrestingOfficerTypeId")]
[Index("DreCaseId", Name = "IX_DRE_DEFENDANTS_DreCaseId", IsUnique = true)]
public partial class DreDefendant
{
    [Key]
    public int DreCaseDefendantId { get; set; }

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(30)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    public string? MiddleName { get; set; }

    [Column("DOB")]
    public DateTime? Dob { get; set; }

    public int? Age { get; set; }

    public int? EthnicityId { get; set; }

    public int? SexId { get; set; }

    public int? RaceId { get; set; }

    public int DreCaseId { get; set; }

    [StringLength(50)]
    public string? ArrestingOfficerId { get; set; }

    [StringLength(100)]
    public string? ArrestingOfficerName { get; set; }

    public int? ArrestingOfficerTypeId { get; set; }

    [StringLength(100)]
    public string? ArrestingOfficerAgency { get; set; }

    [ForeignKey("ArrestingOfficerTypeId")]
    [InverseProperty("DreDefendants")]
    public virtual TblOptAoType? ArrestingOfficerType { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreDefendant")]
    public virtual DreCase DreCase { get; set; } = null!;
}
