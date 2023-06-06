using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_InjuryType")]
public partial class LuInjuryType
{
    [Key]
    public int InjuryId { get; set; }

    [StringLength(250)]
    public string InjuryDescription { get; set; } = null!;

    public bool Active { get; set; }
}
