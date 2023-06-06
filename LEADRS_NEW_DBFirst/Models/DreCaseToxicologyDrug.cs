using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DRE_CASE_TOXICOLOGY_DRUG", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_TOXICOLOGY_DRUG_DreCaseId")]
[Index("DreCaseToxSpecId", Name = "IX_DRE_CASE_TOXICOLOGY_DRUG_DreCaseToxSpecId")]
public partial class DreCaseToxicologyDrug
{
    [Key]
    public int DreCaseToxDrugId { get; set; }

    public int? DreCaseId { get; set; }

    public int? DreCaseToxSpecId { get; set; }

    public int? DpsDrugListId { get; set; }

    [StringLength(50)]
    public string? DrugResult { get; set; }

    public int? DrugMeasurement { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseToxicologyDrugs")]
    public virtual DreCase? DreCase { get; set; }

    [ForeignKey("DreCaseToxSpecId")]
    [InverseProperty("DreCaseToxicologyDrugs")]
    public virtual DreCaseToxSpec? DreCaseToxSpec { get; set; }
}
