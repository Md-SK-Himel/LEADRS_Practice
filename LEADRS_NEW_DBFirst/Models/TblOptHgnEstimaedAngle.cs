using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_HGN_Estimaed_Angle", Schema = "DUI")]
public partial class TblOptHgnEstimaedAngle
{
    [Key]
    public int HgnEstimatedAngleId { get; set; }

    [StringLength(100)]
    public string? EstimatedAngleDesc { get; set; }

    public bool Active { get; set; }

    public int DisplayOrder { get; set; }

    [StringLength(15)]
    public string? ShortName { get; set; }
}
