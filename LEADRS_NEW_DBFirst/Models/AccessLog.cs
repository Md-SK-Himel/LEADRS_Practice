using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Table("AccessLog")]
public partial class AccessLog
{
    [Key]
    public int AccessLogId { get; set; }

    [StringLength(100)]
    public string? EntityName { get; set; }

    public int EntityId { get; set; }

    [StringLength(100)]
    public string? SubEntityName { get; set; }

    public int SubEntityId { get; set; }

    [StringLength(100)]
    public string? RootEntityName { get; set; }

    public int RootEntityId { get; set; }

    [StringLength(100)]
    public string? Action { get; set; }

    [StringLength(100)]
    public string? UserId { get; set; }

    [StringLength(100)]
    public string? UserEmail { get; set; }

    [Column("IPAddress")]
    [StringLength(50)]
    public string? Ipaddress { get; set; }

    [StringLength(10)]
    public string? ContinentCode { get; set; }

    [StringLength(10)]
    public string? CountryCode { get; set; }

    [StringLength(10)]
    public string? RegionCode { get; set; }

    [StringLength(200)]
    public string? City { get; set; }

    [StringLength(12)]
    public string? Zip { get; set; }

    [StringLength(50)]
    public string? Latitiude { get; set; }

    [StringLength(50)]
    public string? Longtitude { get; set; }

    [StringLength(200)]
    public string? ClientIdentifier { get; set; }

    [StringLength(100)]
    public string? OwningUserId { get; set; }

    public int? OwningOrganizationId { get; set; }

    [Column("RequestURL")]
    [StringLength(200)]
    public string? RequestUrl { get; set; }

    public bool IsAjaxRequest { get; set; }

    public DateTime AccessDate { get; set; }
}
