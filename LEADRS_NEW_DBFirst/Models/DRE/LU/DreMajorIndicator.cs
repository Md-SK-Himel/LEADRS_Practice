using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_DRE_MAJOR_INDICATORS ", Schema = "DRE")]
public class DreMajorIndicator
{
    [Key]
    public int DreMajorIndicatorId { get; set; }

    public int? IndTypeId { get; set; }

    [StringLength(255)]
    public string ColumnName { get; set; }

    [StringLength(255)]
    public string ValueToDisplay { get; set; }

    [StringLength(500)]
    public string Note { get; set; }
}
