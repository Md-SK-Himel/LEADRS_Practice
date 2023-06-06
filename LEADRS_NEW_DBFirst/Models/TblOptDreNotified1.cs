using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_Notified", Schema = "DUI")]
public partial class TblOptDreNotified1
{
    [Key]
    public int DreNotifiedId { get; set; }

    [StringLength(50)]
    public string? DreNotifiedDesc { get; set; }

    public bool Active { get; set; }
}
