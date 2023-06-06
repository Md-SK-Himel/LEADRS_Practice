using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("OrganizationSignedEULA")]
public partial class OrganizationSignedEula
{
    [Key]
    [Column("OrganizationSignedEULAId")]
    public int OrganizationSignedEulaid { get; set; }

    public int OrganizationId { get; set; }

    public string? UserId { get; set; }

    public string? SignedName { get; set; }

    public string? SignedPosition { get; set; }

    public byte[]? Signature { get; set; }

    [Column("OrganizationEULADocId")]
    public int OrganizationEuladocId { get; set; }

    [Column("EULAVersion")]
    public string? Eulaversion { get; set; }

    public DateTime CreatedDate { get; set; }
}
