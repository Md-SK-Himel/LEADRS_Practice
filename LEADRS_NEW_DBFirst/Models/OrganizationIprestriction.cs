using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("OrganizationIPRestriction")]
public partial class OrganizationIprestriction
{
    [Key]
    [Column("OrganizationIPRestrictionId")]
    public int OrganizationIprestrictionId { get; set; }

    public int OrganizationId { get; set; }

    public int RestrictionTypeId { get; set; }

    [StringLength(50)]
    public string Restriction { get; set; } = null!;

    public bool Active { get; set; }

    public int WebsiteOrApi { get; set; }
}
