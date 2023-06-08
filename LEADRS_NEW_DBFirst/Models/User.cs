using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LEADRS_NEW_DBFirst.Models;

[Index("NormalizedEmail", Name = "EmailIndex")]
[Index("OrganizationId", Name = "IX_Users_OrganizationId")]
public partial class User
{
    [Key]
    public string Id { get; set; } = null!;

    public string Discriminator { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UnconfirmedEmail { get; set; }

    public DateTimeOffset? CreateDate { get; set; }

    public DateTimeOffset? LastLoginDate { get; set; }

    public DateTimeOffset? LastPasswordChangedDate { get; set; }

    public bool? PasswordResetFlag { get; set; }

    [Column("RejectedEULA")]
    public bool? RejectedEula { get; set; }

    [Column("RejectedEULAOn")]
    public DateTime? RejectedEulaon { get; set; }

    public int? OrganizationId { get; set; }

    public int? OrganizationLocationId { get; set; }

    public bool? IsActive { get; set; }

    public string? SecurityQuestion { get; set; }

    public string? SecurityAnswer { get; set; }

    public bool? QuestionFlag { get; set; }

    [StringLength(256)]
    public string? UserName { get; set; }

    [StringLength(256)]
    public string? NormalizedUserName { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [StringLength(256)]
    public string? NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public string? MiddleNameInitial { get; set; }

    [ForeignKey("OrganizationId")]
    [InverseProperty("Users")]
    public virtual Organization? Organization { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<UserClaim> UserClaims { get; set; } = new List<UserClaim>();

    [InverseProperty("User")]
    public virtual ICollection<UserLogin> UserLogins { get; set; } = new List<UserLogin>();

    [InverseProperty("User")]
    public virtual ICollection<UserToken> UserTokens { get; set; } = new List<UserToken>();
}
