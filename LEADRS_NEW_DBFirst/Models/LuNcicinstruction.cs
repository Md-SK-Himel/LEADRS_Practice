using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICInstructions")]
public partial class LuNcicinstruction
{
    [Key]
    public int InstructionId { get; set; }

    public int TransportModeId { get; set; }

    [StringLength(250)]
    public string? Instruction { get; set; }

    public bool Active { get; set; }
}
