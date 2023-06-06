using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_OperatorOccupation")]
public partial class LuOperatorOccupation
{
    [Key]
    public int OperatorOccupationId { get; set; }

    [StringLength(250)]
    public string Occupation { get; set; } = null!;

    public bool Active { get; set; }
}
