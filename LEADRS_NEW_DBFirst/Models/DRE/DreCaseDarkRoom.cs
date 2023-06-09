﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASES_DARK_ROOM", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASES_DARK_ROOM_DreCaseId", IsUnique = true)]
public class DreCaseDarkRoom : EntityAbstraction
{
    [Key]
    public int DreCaseDarkRoomId { get; set; }

    [MaxLength(3)]
    public string LightL { get; set; }
    [MaxLength(3)]
    public string LightR { get; set; }
    [MaxLength(3)]
    public string DarkL { get; set; }
    [MaxLength(3)]
    public string DarkR { get; set; }
    [MaxLength(3)]
    public string DirectL { get; set; }
    [MaxLength(3)]
    public string DirectR { get; set; }
    public bool? ReboundY { get; set; }
    public bool? ReboundN { get; set; }
    public bool? HippusObserveD { get; set; }
    [MaxLength(50)]
    public string LightReaction { get; set; }
    public bool? NasalAreaClear { get; set; }
    public bool? NasalAreaRed { get; set; }
    public bool? NasalAreableeding { get; set; }
    public bool? NasalAreadeviated { get; set; }
    public bool? NasalAreawhite { get; set; }
    public bool? NasalAreaother { get; set; }
    [MaxLength(50)]
    public string NasalAreaothertxt { get; set; }
    public bool? OralCavityclear { get; set; }
    public bool? OralCavityRaised { get; set; }
    public bool? OralCavityMarijuana { get; set; }
    public bool? OralCavityDry { get; set; }
    public bool? OralCavityRotten { get; set; }
    public bool? OralCavityGreen { get; set; }
    public bool? OralCavityMissing { get; set; }
    public bool? OralCavityOther { get; set; }
    [MaxLength(50)]
    public string OralCavityOtherText { get; set; }
    public int? ReactionToLightId { get; set; }
    [MaxLength(3)]
    public string ReboundStartL { get; set; }
    [MaxLength(3)]
    public string ReboundEndL { get; set; }
    [MaxLength(3)]
    public string ReboundStartR { get; set; }
    [MaxLength(3)]
    public string ReboundEndR { get; set; }
    public bool? UvLight { get; set; }
}
