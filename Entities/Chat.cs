using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Chat
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public int IdService { get; set; }

    public string Texte { get; set; } = null!;

    public virtual Service IdServiceNavigation { get; set; } = null!;

    public virtual User? IdUserNavigation { get; set; }
}
