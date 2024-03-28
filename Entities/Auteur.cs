using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Auteur
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public virtual ICollection<Editer> Editers { get; set; } = new List<Editer>();
}
