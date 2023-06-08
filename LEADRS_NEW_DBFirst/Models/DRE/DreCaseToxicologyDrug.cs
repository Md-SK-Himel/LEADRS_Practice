using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DRE_CASE_TOXICOLOGY_DRUG", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DRE_CASE_TOXICOLOGY_DRUG_DreCaseId")]
[Index("DreCaseToxSpecId", Name = "IX_DRE_CASE_TOXICOLOGY_DRUG_DreCaseToxSpecId")]
public class DreCaseToxicologyDrug : EntityAbstraction
{
    [Key]
    public int DreCaseToxDrugId { get; set; }
    public int? DreCaseToxSpecId { get; set; }
    public int? DpsDrugListId { get; set; }

    [MaxLength(50)]
    public string DrugResult { get; set; }
    public int? DrugMeasurement { get; set; }

    [ForeignKey("DreCaseToxSpecId")]
    public DreCaseToxSpec DreCaseToxSpec { get; set; }
}
