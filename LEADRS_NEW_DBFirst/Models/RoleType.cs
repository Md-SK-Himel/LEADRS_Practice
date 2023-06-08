using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("RoleType")]
public partial class RoleType
{
    [Key]
    public Guid RoleTypeId { get; set; }

    [Column("RoleType")]
    public string? RoleType1 { get; set; }

    public bool IsEnforcement { get; set; }
}
