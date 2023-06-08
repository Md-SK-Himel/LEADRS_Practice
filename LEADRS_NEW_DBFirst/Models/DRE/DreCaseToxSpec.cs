using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LEADRS_NEW_DBFirst.Models.DRE.LU;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models.DRE;

[Table("DreCaseToxSpec", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DreCaseToxSpec_DreCaseId")]
[Index("ToxSpecTypeId", Name = "IX_DreCaseToxSpec_ToxSpecTypeId")]
public class DreCaseToxSpec : EntityAbstraction
{
    [Key]
    public int DreCaseToxSpecId { get; set; }
    public int? ToxSpecTypeId { get; set; }
    public string BacResult { get; set; }
    [MaxLength(255)]
    public string HospSerResult { get; set; }
    [MaxLength(255)]
    public string WholeBloodResult { get; set; }
    [MaxLength(255)]
    public bool? Active { get; set; }
    public DateTime DtCreated { get; set; } = DateTime.Now;
    public DateTime DtUpdated { get; set; }
    public bool? NoAlcohol { get; set; }

    [ForeignKey("ToxSpecTypeId")]
    public DreCaseToxSpecType DreCaseToxSpecType { get; set; }

}
