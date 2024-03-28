using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class TypeLoisir
{
    public int Id { get; set; }

    public string? Libelle { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual ICollection<Typer> Typers { get; set; } = new List<Typer>();
}
