using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_RB", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_RB_DreCaseId", IsUnique = true)]
public partial class DreCaseRb
{
    [Key]
    [Column("DreCaseRBId")]
    public int DreCaseRbid { get; set; }

    public int DreCaseId { get; set; }

    public bool? AlmostFell { get; set; }

    public bool? BodyTremors { get; set; }

    [Column("CIRCSway")]
    public bool? Circsway { get; set; }

    [Column("CIRCSwayDesc")]
    [StringLength(500)]
    public string? CircswayDesc { get; set; }

    public bool? EyelidTremos { get; set; }

    public bool? FrontToBackSway { get; set; }

    [StringLength(500)]
    public string? FrontToBackSwayDesc { get; set; }

    [StringLength(50)]
    public string? InternalClock { get; set; }

    public bool? LegTremos { get; set; }

    public bool? MuscleToneFlaccid { get; set; }

    public bool? MuscleToneRigid { get; set; }

    public bool? NoSway { get; set; }

    public bool? RombergOther { get; set; }

    public bool? RombergBalanceGiven { get; set; }

    public bool? SideToSideSway { get; set; }

    [StringLength(500)]
    public string? SideToSideSwayDesc { get; set; }

    public string? Statement { get; set; }

    public string? OtherText { get; set; }

    public bool? UnableToPerform { get; set; }

    public bool? UnableToStandStill { get; set; }

    public bool? UnserstoodInstructions { get; set; }

    public bool? UsedArms { get; set; }

    public bool? OpenedEyes { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseRb")]
    public virtual DreCase DreCase { get; set; } = null!;
}
