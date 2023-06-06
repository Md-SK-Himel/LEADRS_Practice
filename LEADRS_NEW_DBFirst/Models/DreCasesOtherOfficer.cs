using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASES_OTHER_OFFICER", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_OTHER_OFFICER_DreCaseId")]
[Index("DreRoleId", Name = "IX_DRE_CASES_OTHER_OFFICER_DreRoleId")]
public partial class DreCasesOtherOfficer
{
    [Key]
    public int OtherOfficerId { get; set; }

    public int DreCaseId { get; set; }

    public int? OfficerId { get; set; }

    public string? OfficerUserId { get; set; }

    [StringLength(100)]
    public string? OfficerName { get; set; }

    [StringLength(50)]
    public string? DreNumber { get; set; }

    [StringLength(100)]
    public string? OfficerAgency { get; set; }

    public int? OfficerDeptId { get; set; }

    public int? DreRoleId { get; set; }

    [Column("PBT")]
    public bool Pbt { get; set; }

    [StringLength(24)]
    public string? RollingLogNumber { get; set; }

    public bool Accepted { get; set; }

    [StringLength(100)]
    public string? Badge { get; set; }

    [Required]
    public bool? IsOwner { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCasesOtherOfficers")]
    public virtual DreCase DreCase { get; set; } = null!;

    [ForeignKey("DreRoleId")]
    [InverseProperty("DreCasesOtherOfficers")]
    public virtual TblOptDreRole? DreRole { get; set; }
}
