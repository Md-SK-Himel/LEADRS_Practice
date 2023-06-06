using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Operation_Occupations", Schema = "DUI")]
public partial class TblOptOperationOccupation
{
    [Key]
    public int OperatorOccupationId { get; set; }

    [StringLength(50)]
    public string? Occupation { get; set; }

    public bool Active { get; set; }
}
