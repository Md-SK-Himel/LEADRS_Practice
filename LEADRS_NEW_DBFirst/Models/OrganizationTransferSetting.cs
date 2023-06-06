using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class OrganizationTransferSetting
{
    [Key]
    public int OrganizationTransferSettingsId { get; set; }

    public int OrganizationIdFk { get; set; }

    [Unicode(false)]
    public string? TransferType { get; set; }

    public bool LocationTransfer { get; set; }

    [Unicode(false)]
    public string? VendorSystem { get; set; }

    [Column("URL")]
    [Unicode(false)]
    public string? Url { get; set; }

    [Unicode(false)]
    public string? Username { get; set; }

    [Unicode(false)]
    public string? Password { get; set; }

    [Unicode(false)]
    public string? Folder { get; set; }

    [Unicode(false)]
    public string? UniqueTransferCode { get; set; }

    public bool UseCustomTransportProperties { get; set; }

    public bool EnableDataTransfer { get; set; }

    public bool EnablePdfTransfer { get; set; }

    public bool AllowMultipleDataTransfer { get; set; }

    public bool AllowMultiplePdfTransfer { get; set; }

    [Column("UsePASVTransfer")]
    public bool UsePasvtransfer { get; set; }

    public int UseCustomPort { get; set; }

    public int AuthType { get; set; }

    [Column("APIKey")]
    [Unicode(false)]
    public string? Apikey { get; set; }
}
