using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Livre
{
    public int Id { get; set; }

    public string Titre { get; set; } = null!;

    public int? IdGenre { get; set; }

    public virtual Genre? IdGenreNavigation { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
