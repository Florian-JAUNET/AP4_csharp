using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Admin
{
    public int IdAdmin { get; set; }

    public string EMail { get; set; } = null!;

    public string HashMdp { get; set; } = null!;
}
