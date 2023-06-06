using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Requested", Schema = "DUI")]
public partial class TblOptDreRequested1
{
    [Key]
    public int DreRequestedId { get; set; }

    [StringLength(100)]
    public string? DreRequestedDesc { get; set; }

    public bool Active { get; set; }
}
