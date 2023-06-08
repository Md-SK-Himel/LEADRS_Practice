using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Counties", Schema = "DUI")]
public partial class TblOptCounty
{
    [Key]
    public int CountyId { get; set; }

    [StringLength(100)]
    public string CountyName { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("ArrestCounty")]
    public virtual ICollection<CaseOffense> CaseOffenseArrestCounties { get; set; } = new List<CaseOffense>();

    [InverseProperty("OffCounty")]
    public virtual ICollection<CaseOffense> CaseOffenseOffCounties { get; set; } = new List<CaseOffense>();

    [InverseProperty("County")]
    public virtual ICollection<CaseVehiclePassenger> CaseVehiclePassengers { get; set; } = new List<CaseVehiclePassenger>();

    [InverseProperty("County")]
    public virtual ICollection<DefendantAddress> DefendantAddresses { get; set; } = new List<DefendantAddress>();

    [InverseProperty("County")]
    public virtual ICollection<DefendantEmContact> DefendantEmContacts { get; set; } = new List<DefendantEmContact>();

    [InverseProperty("County")]
    public virtual ICollection<DefendantStatement> DefendantStatements { get; set; } = new List<DefendantStatement>();

    [InverseProperty("County")]
    public virtual ICollection<VehicleWatercraftOwner> VehicleWatercraftOwners { get; set; } = new List<VehicleWatercraftOwner>();

    [InverseProperty("County")]
    public virtual ICollection<Witness> Witnesses { get; set; } = new List<Witness>();
}
