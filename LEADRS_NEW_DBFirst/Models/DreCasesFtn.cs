using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASES_FTN", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_FTN_DreCaseId", IsUnique = true)]
public partial class DreCasesFtn
{
    [Key]
    public int DreCaseFingerToNoseId { get; set; }

    public int DreCaseId { get; set; }

    public bool? UsedPad1 { get; set; }

    public bool? MovedFinger1 { get; set; }

    public bool? OpenedEyes1 { get; set; }

    public bool? UsedPad2 { get; set; }

    public bool? MovedFinger2 { get; set; }

    public bool? OpenedEyes2 { get; set; }

    public bool? UsedPad3 { get; set; }

    public bool? MovedFinger3 { get; set; }

    public bool? OpenedEyes3 { get; set; }

    public bool? UsedPad4 { get; set; }

    public bool? MovedFinger4 { get; set; }

    public bool? OpenedEyes4 { get; set; }

    public bool? UsedPad5 { get; set; }

    public bool? MovedFinger5 { get; set; }

    public bool? OpenedEyes5 { get; set; }

    public bool? UsedPad6 { get; set; }

    public bool? MovedFinger6 { get; set; }

    public bool? OpenedEyes6 { get; set; }

    public bool? Swaying { get; set; }

    public bool? BodyTremors { get; set; }

    public bool? EyelidTremors { get; set; }

    public bool? MuscleTensions { get; set; }

    public bool? Sounds { get; set; }

    public string? FtnNotes { get; set; }

    public bool? UsedWrongHand1 { get; set; }

    public bool? StartedUseWrongHand1 { get; set; }

    public bool? UsedWrongHand2 { get; set; }

    public bool? StartedUseWrongHand2 { get; set; }

    public bool? UsedWrongHand3 { get; set; }

    public bool? StartedUseWrongHand3 { get; set; }

    public bool? UsedWrongHand4 { get; set; }

    public bool? StartedUseWrongHand4 { get; set; }

    public bool? UsedWrongHand5 { get; set; }

    public bool? StartedUseWrongHand5 { get; set; }

    public bool? UsedWrongHand6 { get; set; }

    public bool? StartedUseWrongHand6 { get; set; }

    public bool? LegTremors { get; set; }

    public bool? MuscleToneRigid { get; set; }

    public bool? MuscleToneFlaccid { get; set; }

    public bool? FtnBalanceGiven { get; set; }

    public bool? UnableToPerform { get; set; }

    public bool? UnderstoodInstructions { get; set; }

    public bool? OpenedEyes { get; set; }

    public bool? AlmostFell { get; set; }

    public bool? UsedArms { get; set; }

    public bool? UnableToStandStill { get; set; }

    public bool? Other { get; set; }

    [StringLength(2000)]
    public string? OtherComments { get; set; }

    public bool? HandDown1 { get; set; }

    public bool? HandDown2 { get; set; }

    public bool? HandDown3 { get; set; }

    public bool? HandDown4 { get; set; }

    public bool? HandDown5 { get; set; }

    public bool? HandDown6 { get; set; }

    public bool? Sway1 { get; set; }

    public bool? Sway2 { get; set; }

    public bool? Sway3 { get; set; }

    public bool? Sway4 { get; set; }

    public bool? Sway5 { get; set; }

    public bool? Sway6 { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCasesFtn")]
    public virtual DreCase DreCase { get; set; } = null!;
}
