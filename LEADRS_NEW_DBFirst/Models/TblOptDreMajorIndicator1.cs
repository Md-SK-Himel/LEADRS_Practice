using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Major_Indicators", Schema = "DUI")]
public partial class TblOptDreMajorIndicator1
{
    [Key]
    public int DreMajorIndicatorId { get; set; }

    public int? IndTypeId { get; set; }

    [StringLength(20)]
    public string? ColumnName { get; set; }

    [StringLength(100)]
    public string? ValueToDisplay { get; set; }

    public bool Active { get; set; }
}
