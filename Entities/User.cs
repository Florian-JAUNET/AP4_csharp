using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class User
{
    public int IdUser { get; set; }

    public string Name { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public float Wallet { get; set; }

    public bool Moderateur { get; set; }

    public string? Password { get; set; }

    public string Email { get; set; } = null!;

    public DateOnly DateInscription { get; set; }

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<Commentaire> Commentaires { get; set; } = new List<Commentaire>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual ICollection<Service> IdServices { get; set; } = new List<Service>();
}
