using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Foot_Wear_Types", Schema = "DUI")]
public partial class TblOptFootWearType
{
    [Key]
    public int FootwearTypeId { get; set; }

    [StringLength(50)]
    public string? FootwearDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("FootWear")]
    public virtual ICollection<FstOneLegStandTest> FstOneLegStandTests { get; set; } = new List<FstOneLegStandTest>();
}
