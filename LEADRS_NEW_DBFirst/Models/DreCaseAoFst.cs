using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_AO_FST", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_AO_FST_DreCaseId", IsUnique = true)]
public partial class DreCaseAoFst
{
    [Key]
    [Column("ArrestingOfficerFSTId")]
    public int ArrestingOfficerFstid { get; set; }

    public int DreCaseId { get; set; }

    [Column("HGNCluesLeft")]
    public int? HgncluesLeft { get; set; }

    [Column("HGNCluesRight")]
    public int? HgncluesRight { get; set; }

    [Column("HGNCluesTotal")]
    public int? HgncluesTotal { get; set; }

    [Column("HGNLackOfPursuitLeft")]
    public bool? HgnlackOfPursuitLeft { get; set; }

    [Column("HGNLackOfPursuitRight")]
    public bool? HgnlackOfPursuitRight { get; set; }

    [Column("HGNDistinctMaxDevLeft")]
    public bool? HgndistinctMaxDevLeft { get; set; }

    [Column("HGNDistinctMaxDevRight")]
    public bool? HgndistinctMaxDevRight { get; set; }

    [Column("HGNOnsetPrior45Left")]
    public bool? HgnonsetPrior45Left { get; set; }

    [Column("HGNOnsetPrior45Right")]
    public bool? HgnonsetPrior45Right { get; set; }

    [Column("IsHGNVerticalNyst")]
    public bool? IsHgnverticalNyst { get; set; }

    public bool? WalkTurnStartSoon { get; set; }

    public bool? WalkTurnStepOffLine { get; set; }

    public bool? WalkTurnMissHeelToe { get; set; }

    public bool? WalkTurnRaisesArms { get; set; }

    public bool? WalkTurnWrongNumberSteps { get; set; }

    public bool? WalkTurnStopWalking { get; set; }

    public bool? WalkTurnImproperTurn { get; set; }

    public bool? WalkTurnCannotBalance { get; set; }

    public int? WalkTurnClues { get; set; }

    public bool? OneLegSways { get; set; }

    public bool? OneLegUsesArms { get; set; }

    public bool? OneLegHopps { get; set; }

    public bool? OneLegPutFootDown { get; set; }

    public int? OneLegClues { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseAoFst")]
    public virtual DreCase DreCase { get; set; } = null!;
}
