using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Ethnicity", Schema = "DUI")]
public partial class TblOptEthnicity
{
    [Key]
    public int EthnicityId { get; set; }

    [StringLength(50)]
    public string? EthnicityDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Ethnicity")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();
}
