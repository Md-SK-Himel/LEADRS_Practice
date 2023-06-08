using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICTransportModes")]
public partial class LuNcictransportMode
{
    [Key]
    public int TransportModeId { get; set; }

    [StringLength(250)]
    public string Description { get; set; } = null!;

    [StringLength(200)]
    public string Comments { get; set; } = null!;

    public bool Active { get; set; }
}
