﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApp.Models;

[Table("User")]
[Index("Email", Name = "UQ__User__AB6E6164EE048079", IsUnique = true)]
[Index("Username", Name = "UQ__User__F3DBC572C68CFD55", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("username")]
    [StringLength(30)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Display(Name = "First Name")]
    [Column("first_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    [Column("last_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [Column("password")]
    [StringLength(60)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime CreatedAt { get; set; }

    [InverseProperty("User")]
    public virtual AppAdmin? AppAdmin { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<ContentAdmin> ContentAdmins { get; set; } = new List<ContentAdmin>();

    [InverseProperty("User")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;
}
