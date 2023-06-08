using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_AccidentType")]
public partial class LuAccidentType
{
    [Key]
    public int AccidentId { get; set; }

    [StringLength(100)]
    public string AccidentDescription { get; set; } = null!;

    public bool Active { get; set; }
}
