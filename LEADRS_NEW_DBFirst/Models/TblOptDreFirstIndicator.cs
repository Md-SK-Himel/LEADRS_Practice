using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_FIRST_INDICATORS", Schema = "DRE")]
public partial class TblOptDreFirstIndicator
{
    [Key]
    public int DreCaseFirstIndicatorId { get; set; }

    [StringLength(255)]
    public string? IndType { get; set; }

    [StringLength(255)]
    public string? CnsDep { get; set; }

    [StringLength(255)]
    public string? CnsSti { get; set; }

    [Column("HALL")]
    [StringLength(255)]
    public string? Hall { get; set; }

    [StringLength(255)]
    public string? DisAne { get; set; }

    [StringLength(255)]
    public string? NarAna { get; set; }

    [Column("INHA")]
    [StringLength(255)]
    public string? Inha { get; set; }

    [Column("CANN")]
    [StringLength(255)]
    public string? Cann { get; set; }

    [StringLength(255)]
    public string? IndTypeFullName { get; set; }

    [StringLength(255)]
    public string? DisplayName { get; set; }
}
