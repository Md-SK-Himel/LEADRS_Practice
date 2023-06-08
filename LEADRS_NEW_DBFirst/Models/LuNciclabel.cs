using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICLabels")]
public partial class LuNciclabel
{
    [Key]
    public int LabelId { get; set; }

    public int TransportModeId { get; set; }

    [StringLength(50)]
    public string LabelName { get; set; } = null!;

    [StringLength(250)]
    public string Description { get; set; } = null!;

    [Column("NCICCode")]
    [StringLength(20)]
    public string? Nciccode { get; set; }

    public bool Active { get; set; }
}
