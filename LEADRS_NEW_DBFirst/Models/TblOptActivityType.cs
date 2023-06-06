using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_ActivityTypes", Schema = "DUI")]
public partial class TblOptActivityType
{
    [Key]
    public int ActivityTypeId { get; set; }

    [StringLength(100)]
    public string? ActivityTypeDesc { get; set; }

    public bool? FullCase { get; set; }

    public bool Active { get; set; }
}
