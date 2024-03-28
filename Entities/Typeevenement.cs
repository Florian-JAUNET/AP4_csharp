using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Typeevenement
{
    public int Id { get; set; }

    public string Libelle { get; set; } = null!;

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
