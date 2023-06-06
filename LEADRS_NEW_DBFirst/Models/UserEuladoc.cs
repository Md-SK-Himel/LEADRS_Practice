using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("UserEULADoc")]
public partial class UserEuladoc
{
    [Key]
    [Column("UserEULADocId")]
    public int UserEuladocId { get; set; }

    public string? Version { get; set; }

    [Column("EULAText")]
    public string? Eulatext { get; set; }

    public bool IsLive { get; set; }

    public DateTime? ActiveDate { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime LastModified { get; set; }
}
