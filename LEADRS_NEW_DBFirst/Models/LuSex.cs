using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_Sex")]
public partial class LuSex
{
    [Key]
    public int SexId { get; set; }

    [StringLength(50)]
    public string SexName { get; set; } = null!;

    [StringLength(50)]
    public string? SexIcon { get; set; }

    [StringLength(50)]
    public string? IncidentImage { get; set; }

    [StringLength(50)]
    public string? Subject { get; set; }

    [StringLength(50)]
    public string? Object { get; set; }

    [StringLength(50)]
    public string? Possessive { get; set; }

    [StringLength(50)]
    public string? PossessivePronoun { get; set; }

    [StringLength(50)]
    public string? Reflexive { get; set; }

    [Column("IV_BodyFront")]
    [StringLength(50)]
    public string? IvBodyFront { get; set; }

    [Column("IV_BodyBack")]
    [StringLength(50)]
    public string? IvBodyBack { get; set; }

    [Column("IV_Hands")]
    [StringLength(50)]
    public string? IvHands { get; set; }

    [Column("IV_HeadChinUp")]
    [StringLength(50)]
    public string? IvHeadChinUp { get; set; }

    [Column("IV_HeadEyes")]
    [StringLength(50)]
    public string? IvHeadEyes { get; set; }

    [Column("IV_HeadMouth")]
    [StringLength(50)]
    public string? IvHeadMouth { get; set; }

    [Column("IV_HeadLeft")]
    [StringLength(50)]
    public string? IvHeadLeft { get; set; }

    [Column("IV_HeadRight")]
    [StringLength(50)]
    public string? IvHeadRight { get; set; }

    [Column("IV_HeadTop")]
    [StringLength(50)]
    public string? IvHeadTop { get; set; }

    public bool Active { get; set; }
}
