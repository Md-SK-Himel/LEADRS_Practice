using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Tox_screen_Result", Schema = "DUI")]
public partial class TblOptToxScreenResult
{
    [Key]
    public int ToxScreenResultId { get; set; }

    [StringLength(50)]
    public string? Result { get; set; }

    public bool? DisplayTextbox { get; set; }

    public bool Active { get; set; }
}
