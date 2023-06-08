using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_BWI_Vessels", Schema = "DUI")]
public partial class TblOptBwiVessel
{
    [Key]
    public int BwiVesselId { get; set; }

    [StringLength(50)]
    public string? BwiVesselDesc { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Vessel")]
    public virtual ICollection<VehicleWatercraft> VehicleWatercrafts { get; set; } = new List<VehicleWatercraft>();
}
