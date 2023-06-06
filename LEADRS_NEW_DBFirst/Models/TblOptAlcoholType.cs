using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_AlcoholTypes", Schema = "DUI")]
public partial class TblOptAlcoholType
{
    [Key]
    public int AlcoholTypeId { get; set; }

    [StringLength(50)]
    public string? Alcohol { get; set; }

    public bool Active { get; set; }

    [InverseProperty("AlcoholType")]
    public virtual ICollection<DefendantObservation> DefendantObservations { get; set; } = new List<DefendantObservation>();
}
