using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_DEFENDANTS", Schema = "DRE")]
[Index("ArrestingOfficerTypeId", Name = "IX_DRE_DEFENDANTS_ArrestingOfficerTypeId")]
[Index("DreCaseId", Name = "IX_DRE_DEFENDANTS_DreCaseId", IsUnique = true)]
public class DreCaseDefendant : EntityAbstraction
{
    [Key]
    public int DreCaseDefendantId { get; set; }

    [MaxLength(50)]
    public string LastName { get; set; }
    [MaxLength(30)]
    public string FirstName { get; set; }
    [MaxLength(30)]
    public string MiddleName { get; set; }
    public DateTime? DOB { get; set; }
    public int? Age { get; set; }
    public int? EthnicityId { get; set; }
    public int? SexId { get; set; }
    public int? RaceId { get; set; }

    // Arresting Officer
    [MaxLength(50)]
    public string ArrestingOfficerId { get; set; }
    [MaxLength(100)]
    public string ArrestingOfficerAgency { get; set; }

    [MaxLength(100)]
    public string ArrestingOfficerName { get; set; }
    public int? ArrestingOfficerTypeId { get; set; }

    [ForeignKey("ArrestingOfficerTypeId")]
    public LU.ArrestingOfficerType ArrestingOfficerType { get; set; }
}
