using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DPS_Drugs", Schema = "DUI")]
public partial class TblOptDpsDrug
{
    [Key]
    public int DpsDrugListId { get; set; }

    [StringLength(50)]
    public string? DpsDrug { get; set; }

    [StringLength(50)]
    public string? DpsDrugCategory { get; set; }

    public bool Active { get; set; }
}
