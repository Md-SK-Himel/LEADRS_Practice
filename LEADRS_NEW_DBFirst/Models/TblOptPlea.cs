using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Plea", Schema = "DUI")]
public partial class TblOptPlea
{
    [Key]
    public int PleaId { get; set; }

    [StringLength(50)]
    public string? PleaDescription { get; set; }

    public bool Active { get; set; }
}
