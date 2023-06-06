using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Major_Types", Schema = "DUI")]
public partial class TblOptDreMajorType
{
    [Key]
    public int DreMajorIndicatorsTypeId { get; set; }

    [StringLength(100)]
    public string? IndType { get; set; }

    [StringLength(200)]
    public string? IndTypeFullName { get; set; }

    public bool Active { get; set; }
}
