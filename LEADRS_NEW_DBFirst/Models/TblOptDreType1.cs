using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Types", Schema = "DUI")]
public partial class TblOptDreType1
{
    [Key]
    public int DreTypeId { get; set; }

    [StringLength(50)]
    public string? DreTypeDesc { get; set; }

    public bool Active { get; set; }
}
