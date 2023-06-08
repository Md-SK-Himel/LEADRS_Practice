using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LU_IntegrationVendors")]
public partial class LuIntegrationVendor
{
    [Key]
    public int VendorId { get; set; }

    [StringLength(100)]
    public string VendorName { get; set; } = null!;

    [StringLength(100)]
    public string VendorSystemName { get; set; } = null!;

    [Column("VendorGraphicURL")]
    [StringLength(255)]
    public string VendorGraphicUrl { get; set; } = null!;

    [Column("VendorXMLVerbiage")]
    public string VendorXmlverbiage { get; set; } = null!;

    [Column("VendorPDFVerbiage")]
    public string VendorPdfverbiage { get; set; } = null!;

    [Column("VendorXMLButtonText")]
    [StringLength(50)]
    public string VendorXmlbuttonText { get; set; } = null!;

    [Column("VendorPDFButtonText")]
    [StringLength(50)]
    public string VendorPdfbuttonText { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateUpdated { get; set; }

    public bool Active { get; set; }
}
