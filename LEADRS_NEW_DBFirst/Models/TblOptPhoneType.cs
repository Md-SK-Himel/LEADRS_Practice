using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_PhoneType", Schema = "DUI")]
public partial class TblOptPhoneType
{
    [Key]
    public int PhoneTypeId { get; set; }

    [StringLength(20)]
    public string PhoneTypeName { get; set; } = null!;

    [StringLength(20)]
    public string? Icon { get; set; }

    public bool Active { get; set; }

    [InverseProperty("PhoneType")]
    public virtual ICollection<DefendantPhone> DefendantPhones { get; set; } = new List<DefendantPhone>();
}
