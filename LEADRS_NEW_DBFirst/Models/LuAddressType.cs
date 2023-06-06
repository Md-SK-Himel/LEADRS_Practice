using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_AddressType")]
public partial class LuAddressType
{
    [Key]
    public int AddressTypeId { get; set; }

    [StringLength(100)]
    public string? AddressTypeName { get; set; }

    [StringLength(100)]
    public string? AddressIcon { get; set; }

    public bool Active { get; set; }

    public bool PlaceNameRequired { get; set; }

    [Column("NIBRSCode")]
    [StringLength(10)]
    public string? Nibrscode { get; set; }

    public bool RequiresVehicle { get; set; }

    public int SortOrder { get; set; }
}
