using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class ServcieType
{
    public int IdService { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
