using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_FirstIndicators", Schema = "DUI")]
public partial class TblOptDreFirstIndicator1
{
    [Key]
    public int DreFirstIndicatorId { get; set; }

    [StringLength(100)]
    public string? IndType { get; set; }

    [StringLength(100)]
    public string? CnsDep { get; set; }

    [StringLength(100)]
    public string? CnsSti { get; set; }

    [StringLength(100)]
    public string? Hall { get; set; }

    [StringLength(100)]
    public string? DissAne { get; set; }

    [StringLength(100)]
    public string? NarAna { get; set; }

    [StringLength(100)]
    public string? Inha { get; set; }

    [StringLength(100)]
    public string? Cann { get; set; }

    [StringLength(200)]
    public string? IndTypeFullName { get; set; }

    [StringLength(100)]
    public string? DisplayName { get; set; }

    public bool Active { get; set; }
}
