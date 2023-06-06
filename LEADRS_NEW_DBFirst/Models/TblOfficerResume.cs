using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OFFICER_RESUME")]
public partial class TblOfficerResume
{
    [Key]
    public int OfficerResumeId { get; set; }

    public string? UserId { get; set; }

    [Column("SFST")]
    public bool Sfst { get; set; }

    [Column("BTO")]
    public bool Bto { get; set; }

    [Column("SFST_INSTRUCTOR")]
    public bool SfstInstructor { get; set; }

    [Column("SFST_35")]
    public bool Sfst35 { get; set; }

    [Column("DRE")]
    public bool Dre { get; set; }

    [Column("DRE_INSTRUCTOR")]
    public bool DreInstructor { get; set; }

    [Column("ARIDE")]
    public bool Aride { get; set; }

    [Column("MSEO")]
    public bool Mseo { get; set; }

    [Column("RESUME")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? Resume { get; set; }

    [Column("AGREEMENT_ROLE_ID")]
    public int AgreementRoleId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column("CREATED_DATE", TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column("MODIFIED_BY")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column("MODIFIED_DATE", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column("SEATED_SFST")]
    public bool SeatedSfst { get; set; }

    [Column("ARIDE_INSTRUCTOR")]
    public bool ArideInstructor { get; set; }
}
