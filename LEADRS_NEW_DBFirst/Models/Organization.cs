using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("Organization")]
[Index("OrganizationMainLocationIdFk", Name = "IX_Organization_OrganizationMainLocationID_FK")]
public partial class Organization
{
    [Key]
    [Column("OrganizationID")]
    public int OrganizationId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string OrganizationName { get; set; } = null!;

    [Column("OrganizationMainLocationID_FK")]
    public int? OrganizationMainLocationIdFk { get; set; }

    [Column("RejectedEULA")]
    public bool RejectedEula { get; set; }

    [Column("ORINumber")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Orinumber { get; set; }

    [Column("RejectedEULAOn")]
    public DateTime? RejectedEulaon { get; set; }

    public bool TransferEnabled { get; set; }

    public string? RoleGroupId { get; set; }

    public bool EsignActive { get; set; }

    [Column("SWGroupIDFK")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SwgroupIdfk { get; set; }

    public bool EsignSecSignJudge { get; set; }

    public bool Active { get; set; }

    public bool StepZonesByLoc { get; set; }

    [Column("RestrictAccessByIP")]
    public bool RestrictAccessByIp { get; set; }

    [Column("ACName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Acname { get; set; }

    [Column("ACEmail")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Acemail { get; set; }

    [Column("ACPhone")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Acphone { get; set; }

    public bool Training { get; set; }

    [Column("AgencyORI")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AgencyOri { get; set; }

    [Required]
    public bool? IsTest { get; set; }

    [InverseProperty("Organization")]
    public virtual ICollection<CaseOutcome> CaseOutcomes { get; set; } = new List<CaseOutcome>();

    [InverseProperty("Organisation")]
    public virtual ICollection<ClerkSupplement> ClerkSupplements { get; set; } = new List<ClerkSupplement>();

    [ForeignKey("OrganizationMainLocationIdFk")]
    [InverseProperty("Organizations")]
    public virtual OrganizationLocation? OrganizationMainLocationIdFkNavigation { get; set; }

    [InverseProperty("Organization")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();

    [ForeignKey("OrganizationId")]
    [InverseProperty("Organizations")]
    public virtual ICollection<LuCourtType> CourtTypes { get; set; } = new List<LuCourtType>();
}
