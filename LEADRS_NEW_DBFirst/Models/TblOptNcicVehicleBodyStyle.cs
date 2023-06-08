﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_NCIC_Vehicle_Body_Style", Schema = "DUI")]
public partial class TblOptNcicVehicleBodyStyle
{
    [Key]
    public int BodyStyleId { get; set; }

    public int TransportTypeId { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [StringLength(10)]
    public string? NcicCode { get; set; }

    public bool Active { get; set; }

    [InverseProperty("BoatHullShape")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();
}
