using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_DRE_FIRST_INDICATORS", Schema = "DRE")]
public class DreCaseFirstIndicator
{
    [Key]
    public int DreCaseFirstIndicatorId { get; set; }

    [MaxLength(255)]
    public string IndType { get; set; }
    [MaxLength(255)]
    public string CnsDep { get; set; }
    [MaxLength(255)]
    public string CnsSti { get; set; }
    [MaxLength(255)]
    public string HALL { get; set; }
    [MaxLength(255)]
    public string DisAne { get; set; }
    [MaxLength(255)]
    public string NarAna { get; set; }
    [MaxLength(255)]
    public string INHA { get; set; }
    [MaxLength(255)]
    public string CANN { get; set; }
    [MaxLength(255)]
    public string IndTypeFullName { get; set; }
    [MaxLength(255)]
    public string DisplayName { get; set; }
}
