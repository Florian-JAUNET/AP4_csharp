using System;
using System.Collections.Generic;

namespace LinkHUb_depuis0.Entities;

public partial class Service
{
    public int IdService { get; set; }

    public int IdUser { get; set; }

    public string DescriptionService { get; set; } = null!;

    public string? Lieu { get; set; }

    public DateOnly? DateRdv { get; set; }

    public int? NbPlacesDispo { get; set; }

    public bool? Demande { get; set; }

    public int? NbPersonneJoined { get; set; }

    public int? TypeEvenement { get; set; }

    public string? ArriverCovoiturage { get; set; }

    public double? Prix { get; set; }

    public int? TypeLoisir { get; set; }

    public int ServiceType { get; set; }

    public int? LivreLecture { get; set; }

    public string Titre { get; set; } = null!;

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();

    public virtual ICollection<Commentaire> Commentaires { get; set; } = new List<Commentaire>();

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual Livre? LivreLectureNavigation { get; set; }

    public virtual ServcieType ServiceTypeNavigation { get; set; } = null!;

    public virtual Typeevenement? TypeEvenementNavigation { get; set; }

    public virtual TypeLoisir? TypeLoisirNavigation { get; set; }

    public virtual ICollection<User> IdUsers { get; set; } = new List<User>();
}
