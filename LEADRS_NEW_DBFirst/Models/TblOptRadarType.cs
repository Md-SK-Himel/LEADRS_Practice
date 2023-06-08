using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Radar_Types", Schema = "DUI")]
public partial class TblOptRadarType
{
    [Key]
    public int RadarTypeId { get; set; }

    [StringLength(50)]
    public string? RadarDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("RadarType")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
