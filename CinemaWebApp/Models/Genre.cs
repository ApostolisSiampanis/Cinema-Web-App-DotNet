﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApp.Models;

[Table("Genre")]
[Index("Name", Name = "UQ__Genre__72E12F1BFCA9FA5B", IsUnique = true)]
public partial class Genre
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Display(Name = "Genre")]
    [Column("name")]
    [StringLength(20)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [InverseProperty("Genre")]
    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
