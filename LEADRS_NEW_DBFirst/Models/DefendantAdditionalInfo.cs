using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantAdditionalInfos", Schema = "DUI")]
[Index("DefendantId", Name = "IX_DefendantAdditionalInfos_DefendantId", IsUnique = true)]
public partial class DefendantAdditionalInfo
{
    [Key]
    public int DefendantAdditionalInfoId { get; set; }

    public int DefendantId { get; set; }

    public string? AdditionalInformation { get; set; }

    public bool AccidentReport { get; set; }

    public bool WitnessStatements { get; set; }

    public bool ImpoundSheet { get; set; }

    [Column("SFSTCheckList")]
    public bool SfstcheckList { get; set; }

    [Column("DIC23")]
    public bool Dic23 { get; set; }

    [Column("DIC24")]
    public bool Dic24 { get; set; }

    [Column("DIC25")]
    public bool Dic25 { get; set; }

    public bool OfficerSupplement { get; set; }

    public bool Intoxilyzer { get; set; }

    public bool SearchWarrant { get; set; }

    public bool Other { get; set; }

    [StringLength(1023)]
    public string? OtherDesc { get; set; }

    public bool DefendantInfo { get; set; }

    public bool OffenseInfo { get; set; }

    public bool Observations { get; set; }

    [Column("FSTs")]
    public bool Fsts { get; set; }

    public bool SpecimenInfo { get; set; }

    public bool PassengerInfo { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantAdditionalInfo")]
    public virtual Defendant Defendant { get; set; } = null!;
}
