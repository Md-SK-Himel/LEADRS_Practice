using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE.LU;

[Table("TBL_OPT_DPS_DRUG_LIST", Schema = "DRE")]
public class DpsDrugList
{
    [Key]
    public int DpsDrugListId { get; set; }

    [StringLength(50)]
    public string DpsDrug { get; set; }

    [StringLength(50)]
    public string DpsDrugCategory { get; set; }

    public bool? Active { get; set; }
}
