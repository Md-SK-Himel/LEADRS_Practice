using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_AddressGroup", Schema = "DUI")]
public partial class TblOptAddressGroup
{
    [Key]
    public int AddressGroupId { get; set; }

    [StringLength(20)]
    public string AddressGroupName { get; set; } = null!;

    [StringLength(20)]
    public string? Icon { get; set; }

    public bool Active { get; set; }

    [InverseProperty("ArrestAddressGroup")]
    public virtual ICollection<CaseOffense> CaseOffenseArrestAddressGroups { get; set; } = new List<CaseOffense>();

    [InverseProperty("OffAddressGroup")]
    public virtual ICollection<CaseOffense> CaseOffenseOffAddressGroups { get; set; } = new List<CaseOffense>();

    [InverseProperty("AddressGroup")]
    public virtual ICollection<CaseVehiclePassenger> CaseVehiclePassengers { get; set; } = new List<CaseVehiclePassenger>();

    [InverseProperty("AddressGroup")]
    public virtual ICollection<DefendantAddress> DefendantAddresses { get; set; } = new List<DefendantAddress>();

    [InverseProperty("AddressGroup")]
    public virtual ICollection<DefendantEmContact> DefendantEmContacts { get; set; } = new List<DefendantEmContact>();

    [InverseProperty("AddressGroup")]
    public virtual ICollection<DefendantStatement> DefendantStatements { get; set; } = new List<DefendantStatement>();

    [InverseProperty("AddressGroup")]
    public virtual ICollection<VehicleWatercraftOwner> VehicleWatercraftOwners { get; set; } = new List<VehicleWatercraftOwner>();

    [InverseProperty("AddressGroup")]
    public virtual ICollection<Witness> Witnesses { get; set; } = new List<Witness>();
}
