using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE.LU;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES_OTHER_OFFICER", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_OTHER_OFFICER_DreCaseId")]
[Index("DreRoleId", Name = "IX_DRE_CASES_OTHER_OFFICER_DreRoleId")]
public class DreCaseOtherOfficer : EntityAbstraction
{
    [Key]
    public int OtherOfficerId { get; set; }


    public int? OfficerId { get; set; }
    public int? OfficerUserId { get; set; }
    [MaxLength(100)]
    public string OfficerName { get; set; }
    [MaxLength(50)]
    public string DreNumber { get; set; }

    [MaxLength(100)]
    public string Badge { get; set; }
    [MaxLength(100)]
    public string OfficerAgency { get; set; }
    public int? OfficerDeptId { get; set; }

    public int? DreRoleId { get; set; }
    public LU.DRERole DRERole { get; set; }

    public bool? PBT { get; set; }
    [MaxLength(24)]
    public string RollingLogNumber { get; set; }

    public bool? Accepted { get; set; }
    /// <summary>
    /// This flag is on Means this the creator of this case
    /// </summary>
    public bool? IsOwner { get; set; }

}
