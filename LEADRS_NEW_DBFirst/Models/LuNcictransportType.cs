using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICTransportTypes")]
public partial class LuNcictransportType
{
    [Key]
    public int TransportTypeId { get; set; }

    public int TransportModeId { get; set; }

    [StringLength(250)]
    public string Description { get; set; } = null!;

    public bool Active { get; set; }
}
