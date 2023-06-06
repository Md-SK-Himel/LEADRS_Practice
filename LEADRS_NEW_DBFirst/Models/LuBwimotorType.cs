using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_BWIMotorType")]
public partial class LuBwimotorType
{
    [Key]
    [Column("BWIMotorTypeId")]
    public int BwimotorTypeId { get; set; }

    [Column("BWIMotor")]
    [StringLength(100)]
    public string Bwimotor { get; set; } = null!;

    public bool Active { get; set; }
}
