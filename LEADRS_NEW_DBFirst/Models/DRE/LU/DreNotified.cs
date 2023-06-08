﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_DRE_NOTIFIED", Schema = "DRE")]
public class DreNotified
{
    [Key]
    public int DreNotifiedId { get; set; }

    [StringLength(100)]
    public string Description { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<DRECase> DreCases { get; set; } = new List<DRECase>();
}
