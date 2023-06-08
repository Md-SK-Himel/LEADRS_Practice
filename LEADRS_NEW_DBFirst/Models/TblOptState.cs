using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_States", Schema = "DUI")]
public partial class TblOptState
{
    [Key]
    public int StateId { get; set; }

    [StringLength(100)]
    public string StateName { get; set; } = null!;

    [StringLength(5)]
    public string Abbreviation { get; set; } = null!;

    public bool Active { get; set; }

    [InverseProperty("ArrestState")]
    public virtual ICollection<CaseOffense> CaseOffenseArrestStates { get; set; } = new List<CaseOffense>();

    [InverseProperty("OffState")]
    public virtual ICollection<CaseOffense> CaseOffenseOffStates { get; set; } = new List<CaseOffense>();

    [InverseProperty("State")]
    public virtual ICollection<CaseVehiclePassenger> CaseVehiclePassengers { get; set; } = new List<CaseVehiclePassenger>();

    [InverseProperty("State")]
    public virtual ICollection<CaseVehicle> CaseVehicles { get; set; } = new List<CaseVehicle>();

    [InverseProperty("EmState")]
    public virtual ICollection<DefendantAddress> DefendantAddressEmStates { get; set; } = new List<DefendantAddress>();

    [InverseProperty("OccState")]
    public virtual ICollection<DefendantAddress> DefendantAddressOccStates { get; set; } = new List<DefendantAddress>();

    [InverseProperty("State")]
    public virtual ICollection<DefendantAddress> DefendantAddressStates { get; set; } = new List<DefendantAddress>();

    [InverseProperty("State")]
    public virtual ICollection<DefendantEmContact> DefendantEmContacts { get; set; } = new List<DefendantEmContact>();

    [InverseProperty("State")]
    public virtual ICollection<DefendantOccupationAddress> DefendantOccupationAddresses { get; set; } = new List<DefendantOccupationAddress>();

    [InverseProperty("State")]
    public virtual ICollection<DefendantStatement> DefendantStatements { get; set; } = new List<DefendantStatement>();

    [InverseProperty("DlState")]
    public virtual ICollection<Defendant> Defendants { get; set; } = new List<Defendant>();

    [InverseProperty("State")]
    public virtual ICollection<VehicleWatercraftOwner> VehicleWatercraftOwners { get; set; } = new List<VehicleWatercraftOwner>();

    [InverseProperty("DlState")]
    public virtual ICollection<Witness> WitnessDlStates { get; set; } = new List<Witness>();

    [InverseProperty("State")]
    public virtual ICollection<Witness> WitnessStates { get; set; } = new List<Witness>();
}
