using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("TBL_OPT_Specimen_Storage", Schema = "DUI")]
public partial class TblOptSpecimenStorage
{
    [Key]
    public int SpecimenStorageId { get; set; }

    [StringLength(50)]
    public string? Storage { get; set; }

    public bool Active { get; set; }
}
