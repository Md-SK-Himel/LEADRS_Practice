using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_SECOND_INDICATORS", Schema = "DRE")]
public partial class TblOptDreSecondIndicator
{
    [Key]
    public int DreCaseSecondIndicatorId { get; set; }

    [StringLength(255)]
    public string? IndType { get; set; }

    [StringLength(255)]
    public string? IndTypeFullName { get; set; }

    public string? CnsDep { get; set; }

    public string? CnsSti { get; set; }

    public string? Hall { get; set; }

    public string? DissAne { get; set; }

    public string? NarAna { get; set; }

    public string? Inha { get; set; }

    public string? Cann { get; set; }
}
