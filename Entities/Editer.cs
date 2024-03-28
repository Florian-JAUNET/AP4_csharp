using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Editer
{
    public int IdService { get; set; }

    public int Id { get; set; }

    public virtual Auteur IdNavigation { get; set; } = null!;
}
