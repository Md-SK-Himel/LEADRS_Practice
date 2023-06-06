using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Status", Schema = "DUI")]
public partial class TblOptStatus
{
    [Key]
    public int StatusId { get; set; }

    public string? StatusDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<CaseHeader> CaseHeaders { get; set; } = new List<CaseHeader>();
}
