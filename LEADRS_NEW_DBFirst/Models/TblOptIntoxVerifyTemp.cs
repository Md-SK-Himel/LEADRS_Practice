using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_INTOX_VerifyTemp", Schema = "DUI")]
public partial class TblOptIntoxVerifyTemp
{
    [Key]
    public int IntoxVerifytempId { get; set; }

    [StringLength(50)]
    public string? Verifytemp { get; set; }

    public bool Active { get; set; }

    [InverseProperty("VerifyTemp")]
    public virtual ICollection<SpecimenBreathTest> SpecimenBreathTests { get; set; } = new List<SpecimenBreathTest>();
}
