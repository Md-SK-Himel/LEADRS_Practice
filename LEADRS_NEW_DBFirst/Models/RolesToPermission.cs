using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class RolesToPermission
{
    [Key]
    [StringLength(100)]
    public string RoleName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? PermissionsInRole { get; set; }

    [InverseProperty("RoleNameNavigation")]
    public virtual ICollection<UserToRole> UserToRoles { get; set; } = new List<UserToRole>();
}
