using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_DRE_CASE_STATUS", Schema = "DRE")]
public partial class TblOptDreCaseStatus
{
    [Key]
    [Column("DRECaseStatusId")]
    public int DrecaseStatusId { get; set; }

    public string? StatusName { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<DreCase> DreCases { get; set; } = new List<DreCase>();
}
