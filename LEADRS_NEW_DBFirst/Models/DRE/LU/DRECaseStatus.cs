using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_DRE_CASE_STATUS", Schema = "DRE")]
public class DRECaseStatus
{
    [Key]
    public int DRECaseStatusId { get; set; }

    public string StatusName { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DRECase> DreCases { get; set; } = new List<DRECase>();
}
