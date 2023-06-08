using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Accidents", Schema = "DUI")]
public partial class TblOptAccident
{
    [Key]
    public int AccidentId { get; set; }

    [StringLength(50)]
    public string? AccidentDescription { get; set; }

    public bool Active { get; set; }
}
