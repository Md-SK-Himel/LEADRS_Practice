using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("DefendantPhones", Schema = "DUI")]
[Index("DefendantId", Name = "IX_DefendantPhones_DefendantId")]
[Index("PhoneTypeId", Name = "IX_DefendantPhones_PhoneTypeId")]
public partial class DefendantPhone
{
    [Key]
    public int DefendantPhoneId { get; set; }

    public int DefendantId { get; set; }

    public int PhoneTypeId { get; set; }

    [StringLength(20)]
    public string PhoneNumber { get; set; } = null!;

    public bool ContactNumber { get; set; }

    [ForeignKey("DefendantId")]
    [InverseProperty("DefendantPhones")]
    public virtual Defendant Defendant { get; set; } = null!;

    [ForeignKey("PhoneTypeId")]
    [InverseProperty("DefendantPhones")]
    public virtual TblOptPhoneType PhoneType { get; set; } = null!;
}
