using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("UserSignedEULA")]
public partial class UserSignedEula
{
    [Key]
    [Column("UserSignedEULAId")]
    public int UserSignedEulaid { get; set; }

    public string? UserId { get; set; }

    [Column("UserEULADocId")]
    public int UserEuladocId { get; set; }

    [Column("EULAVersion")]
    public string? Eulaversion { get; set; }

    public DateTime CreatedDate { get; set; }
}
