using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_NCICBoatShape")]
public partial class LuNcicboatShape
{
    [Key]
    public int BodyStyleId { get; set; }

    public int TransportTypeId { get; set; }

    [StringLength(250)]
    public string? Description { get; set; }

    [Column("NCICCode")]
    [StringLength(20)]
    public string? Nciccode { get; set; }

    public bool Active { get; set; }
}
