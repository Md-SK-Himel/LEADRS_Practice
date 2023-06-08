using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("LoginHistory")]
public partial class LoginHistory
{
    [Key]
    [Column("Audit_Login_Id")]
    public int AuditLoginId { get; set; }

    [Column("Ip_Address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IpAddress { get; set; }

    [Column("Continent_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ContinentCode { get; set; }

    [Column("Country_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CountryCode { get; set; }

    [Column("Region_Code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RegionCode { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [Column("User_Name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? UserName { get; set; }

    public bool Success { get; set; }

    [Column("Attempt_Date", TypeName = "datetime")]
    public DateTime AttemptDate { get; set; }

    [Column("User_Id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UserId { get; set; }
}
