using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DreCaseToxSpec", Schema = "DRE")]
[Index("DreCaseId", Name = "IX_DreCaseToxSpec_DreCaseId")]
[Index("ToxSpecTypeId", Name = "IX_DreCaseToxSpec_ToxSpecTypeId")]
public partial class DreCaseToxSpec
{
    [Key]
    public int DreCaseToxSpecId { get; set; }

    public int DreCaseId { get; set; }

    public int? ToxSpecTypeId { get; set; }

    public string? BacResult { get; set; }

    [StringLength(255)]
    public string? HospSerResult { get; set; }

    [StringLength(255)]
    public string? WholeBloodResult { get; set; }

    public bool? Active { get; set; }

    public DateTime DtCreated { get; set; }

    public DateTime DtUpdated { get; set; }

    public bool? NoAlcohol { get; set; }

    [ForeignKey("DreCaseId")]
    [InverseProperty("DreCaseToxSpecs")]
    public virtual DreCase DreCase { get; set; } = null!;

    [InverseProperty("DreCaseToxSpec")]
    public virtual ICollection<DreCaseToxicologyDrug> DreCaseToxicologyDrugs { get; set; } = new List<DreCaseToxicologyDrug>();

    [ForeignKey("ToxSpecTypeId")]
    [InverseProperty("DreCaseToxSpecs")]
    public virtual TblOptToxSpecType? ToxSpecType { get; set; }
}
