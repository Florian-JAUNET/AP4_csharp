using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class AdminLog
{
    public string Log { get; set; } = null!;

    public DateOnly Datelog { get; set; }

    public int Idlog { get; set; }
}
