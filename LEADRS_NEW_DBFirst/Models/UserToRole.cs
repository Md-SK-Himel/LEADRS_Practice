using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[PrimaryKey("UserId", "RoleName")]
[Index("RoleName", Name = "IX_UserToRoles_RoleName")]
public partial class UserToRole
{
    [Key]
    [StringLength(36)]
    public string UserId { get; set; } = null!;

    [Key]
    [StringLength(100)]
    public string RoleName { get; set; } = null!;

    [ForeignKey("RoleName")]
    [InverseProperty("UserToRoles")]
    public virtual RolesToPermission RoleNameNavigation { get; set; } = null!;
}
