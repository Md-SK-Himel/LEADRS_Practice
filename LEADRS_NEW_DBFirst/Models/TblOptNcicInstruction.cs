using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Instructions", Schema = "DUI")]
public partial class TblOptNcicInstruction
{
    [Key]
    public int NcicInstructionId { get; set; }

    public int TransportModeId { get; set; }

    [StringLength(2000)]
    public string? Instruction { get; set; }

    public bool Active { get; set; }
}
