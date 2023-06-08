using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICMakes")]
public partial class LuNcicmake
{
    [Key]
    public int MakeId { get; set; }

    public int TransportTypeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column("NCICCode")]
    [StringLength(20)]
    public string? Nciccode { get; set; }

    [StringLength(200)]
    public string? Comments { get; set; }

    public bool Active { get; set; }
}
