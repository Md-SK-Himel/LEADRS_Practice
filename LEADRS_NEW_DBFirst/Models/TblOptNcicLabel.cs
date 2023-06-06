using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Labels", Schema = "DUI")]
public partial class TblOptNcicLabel
{
    [Key]
    public int NcicLabelId { get; set; }

    public int TransportModeId { get; set; }

    [StringLength(50)]
    public string? TableName { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    public bool Active { get; set; }
}
