using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("OtherOfficers", Schema = "DUI")]
[Index("CaseId", Name = "IX_OtherOfficers_CaseId")]
public partial class OtherOfficer
{
    [Key]
    public int OtherOfficerId { get; set; }

    public int CaseId { get; set; }

    [StringLength(50)]
    public string? OfficerName { get; set; }

    [StringLength(50)]
    public string? BadgeNumber { get; set; }

    [StringLength(100)]
    public string? Department { get; set; }

    [StringLength(2000)]
    public string? OtherOfficerParticipation { get; set; }

    [Required]
    public bool? Supplement { get; set; }

    [ForeignKey("CaseId")]
    [InverseProperty("OtherOfficers")]
    public virtual CaseHeader Case { get; set; } = null!;
}
