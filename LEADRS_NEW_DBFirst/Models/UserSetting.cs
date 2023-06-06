using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

public partial class UserSetting
{
    [Key]
    [Column("User_Id")]
    public string UserId { get; set; } = null!;

    [Column("Sidebar_Color")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SidebarColor { get; set; }

    [Column("Header_Brand_Color")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HeaderBrandColor { get; set; }

    [Column("Header_Color")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HeaderColor { get; set; }

    [Column("Sidebar_Position")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SidebarPosition { get; set; }

    [Column("Header_Option")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HeaderOption { get; set; }

    [Column("Sidebar_Menu_Option")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SidebarMenuOption { get; set; }

    [Column("Footer_Option")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FooterOption { get; set; }

    [Required]
    public bool? Notification { get; set; }

    [Required]
    public bool? EmailNotification { get; set; }
}
