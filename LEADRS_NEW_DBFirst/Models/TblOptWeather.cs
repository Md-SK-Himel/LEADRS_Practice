using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Weathers", Schema = "DUI")]
public partial class TblOptWeather
{
    [Key]
    public int WeatherId { get; set; }

    [StringLength(50)]
    public string? WeatherDescription { get; set; }

    public bool Active { get; set; }

    [InverseProperty("Weather")]
    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();
}
