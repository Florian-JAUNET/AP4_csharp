using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class LivreAuteur
{
    public int? IdLivre { get; set; }

    public int? IdAuteur { get; set; }

    public virtual Auteur? IdAuteurNavigation { get; set; }

    public virtual Livre? IdLivreNavigation { get; set; }
}
