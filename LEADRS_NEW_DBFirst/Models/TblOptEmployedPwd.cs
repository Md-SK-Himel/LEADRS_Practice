using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Employed_PWD", Schema = "DUI")]
public partial class TblOptEmployedPwd
{
    [Key]
    public int EmployedId { get; set; }

    [StringLength(100)]
    public string? Employed { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Employed")]
    public virtual ICollection<SpecimenBloodTest> SpecimenBloodTests { get; set; } = new List<SpecimenBloodTest>();
}
