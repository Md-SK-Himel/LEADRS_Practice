using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_AO_FST", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_AO_FST_DreCaseId", IsUnique = true)]
public class DreCaseArrestingOfficerFST : EntityAbstraction
{
    [Key]
    public int ArrestingOfficerFSTId { get; set; }


    // HGN
    public int? HGNCluesLeft { get; set; }
    public int? HGNCluesRight { get; set; }
    public int? HGNCluesTotal { get; set; }

    public bool? HGNLackOfPursuitLeft { get; set; }
    public bool? HGNLackOfPursuitRight { get; set; }

    public bool? HGNDistinctMaxDevLeft { get; set; }
    public bool? HGNDistinctMaxDevRight { get; set; }

    public bool? HGNOnsetPrior45Left { get; set; }
    public bool? HGNOnsetPrior45Right { get; set; }

    public bool? IsHGNVerticalNyst { get; set; }


    // Walk Turn
    public bool? WalkTurnStartSoon { get; set; }
    public bool? WalkTurnStepOffLine { get; set; }
    public bool? WalkTurnMissHeelToe { get; set; }
    public bool? WalkTurnRaisesArms { get; set; }
    public bool? WalkTurnWrongNumberSteps { get; set; }
    public bool? WalkTurnStopWalking { get; set; }
    public bool? WalkTurnImproperTurn { get; set; }
    public bool? WalkTurnCannotBalance { get; set; }
    public int? WalkTurnClues { get; set; }

    // One Leg Stand
    public bool? OneLegSways { get; set; }
    public bool? OneLegUsesArms { get; set; }
    public bool? OneLegHopps { get; set; }
    public bool? OneLegPutFootDown { get; set; }
    public int? OneLegClues { get; set; }


}
