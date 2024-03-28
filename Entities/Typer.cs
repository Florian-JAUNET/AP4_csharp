using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Typer
{
    public int IdService { get; set; }

    public int Id { get; set; }

    public virtual TypeLoisir IdNavigation { get; set; } = null!;
}
