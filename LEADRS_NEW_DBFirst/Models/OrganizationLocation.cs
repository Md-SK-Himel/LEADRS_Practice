using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("OrganizationLocation")]
public partial class OrganizationLocation
{
    [Key]
    [Column("OrganizationLocationID")]
    public int OrganizationLocationId { get; set; }

    [Column("OrganizationID_FK")]
    public int OrganizationIdFk { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationLocationName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationLocationAddr1 { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? OrganizationLocationAddr2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OrganizationLocationCity { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string OrganizationLocationCounty { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string OrganizationLocationState { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string OrganizationLocationZip { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string OrganizationLocationPhone { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationLocationContact { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OrganizationLocationEmail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OrganizationLocationFax { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OrganizationLocationTransferCode { get; set; }

    public bool IsEsignActive { get; set; }

    public bool IsActive { get; set; }

    [Column("ORINumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Orinumber { get; set; }

    [InverseProperty("OrganizationMainLocationIdFkNavigation")]
    public virtual ICollection<Organization> Organizations { get; set; } = new List<Organization>();
}
