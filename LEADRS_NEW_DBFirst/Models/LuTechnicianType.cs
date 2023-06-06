using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_TechnicianType")]
public partial class LuTechnicianType
{
    [Key]
    public int EmployeeId { get; set; }

    [StringLength(250)]
    public string Employed { get; set; } = null!;

    public bool Active { get; set; }
}
