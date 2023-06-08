using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantOccupationAddress", Schema = "DUI")]
[Index("StateId", Name = "IX_DefendantOccupationAddress_StateId")]
public partial class DefendantOccupationAddress
{
    [Key]
    public int DefendantOccupationAddressId { get; set; }

    public int DefendantId { get; set; }

    public string? OccAddress1 { get; set; }

    public string? OccAddress2 { get; set; }

    public string? OccCity { get; set; }

    public int? StateId { get; set; }

    public string? OccZipCode { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("DefendantOccupationAddresses")]
    public virtual TblOptState? State { get; set; }
}
