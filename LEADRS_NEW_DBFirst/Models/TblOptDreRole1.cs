using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Roles", Schema = "DUI")]
public partial class TblOptDreRole1
{
    [Key]
    public int DreRoleId { get; set; }

    [StringLength(50)]
    public string? DreRoleDesc { get; set; }

    public bool Active { get; set; }
}
