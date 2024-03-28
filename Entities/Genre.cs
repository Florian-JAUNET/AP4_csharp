using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Genre
{
    public int Id { get; set; }

    public string? Libelle { get; set; }

    public virtual ICollection<Livre> Livres { get; set; } = new List<Livre>();
}
