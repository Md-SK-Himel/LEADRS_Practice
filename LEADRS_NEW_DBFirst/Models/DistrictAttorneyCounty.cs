using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class DistrictAttorneyCounty
{
    [Key]
    [Column("DACountyId")]
    public int DacountyId { get; set; }

    public int OrganizationId { get; set; }

    public int CountyId { get; set; }

    public bool Active { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
