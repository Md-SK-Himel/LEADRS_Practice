using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_BWI_Motors", Schema = "DUI")]
public partial class TblOptBwiMotor
{
    [Key]
    public int BwiMotorId { get; set; }

    [StringLength(50)]
    public string? BwiMotorDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Motor")]
    public virtual ICollection<VehicleWatercraft> VehicleWatercrafts { get; set; } = new List<VehicleWatercraft>();
}
