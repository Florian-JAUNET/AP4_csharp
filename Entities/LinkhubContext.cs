using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LinkHUb_depuis0.Entities;

public partial class LinkhubContext : DbContext
{
    public LinkhubContext()
    {
    }

    public LinkhubContext(DbContextOptions<LinkhubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AdminLog> AdminLogs { get; set; }

    public virtual DbSet<Auteur> Auteurs { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<Commentaire> Commentaires { get; set; }

    public virtual DbSet<Editer> Editers { get; set; }

    public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Livre> Livres { get; set; }

    public virtual DbSet<LivreAuteur> LivreAuteurs { get; set; }

    public virtual DbSet<ServcieType> ServcieTypes { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<TypeLoisir> TypeLoisirs { get; set; }

    public virtual DbSet<Typeevenement> Typeevenements { get; set; }

    public virtual DbSet<Typer> Typers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.114.2;port=3306;user=lmascher;password=hJfmd@$#w2@sBQYV;database=linkhub", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.4-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.IdAdmin).HasName("PRIMARY");

            entity
                .ToTable("ADMIN")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.EMail, "eMail").IsUnique();

            entity.Property(e => e.IdAdmin)
                .HasColumnType("int(6)")
                .HasColumnName("idAdmin");
            entity.Property(e => e.EMail).HasColumnName("eMail");
            entity.Property(e => e.HashMdp)
                .HasMaxLength(255)
                .HasColumnName("hashMdp");
        });

        modelBuilder.Entity<AdminLog>(entity =>
        {
            entity.HasKey(e => e.Idlog).HasName("PRIMARY");

            entity.ToTable("ADMIN_LOGS");

            entity.Property(e => e.Idlog)
                .HasColumnType("int(11)")
                .HasColumnName("IDLOG");
            entity.Property(e => e.Datelog)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnName("DATELOG");
            entity.Property(e => e.Log)
                .HasMaxLength(255)
                .HasDefaultValueSql("'ERROR DE LOG'")
                .HasColumnName("LOG");
        });

        modelBuilder.Entity<Auteur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("AUTEUR")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Nom)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("NOM");
            entity.Property(e => e.Prenom)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("PRENOM");
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("CHATS")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IdService, "I_FK_CHATS_SERVICE");

            entity.HasIndex(e => e.IdUser, "I_FK_CHATS_UTILISATEUR");

            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.IdService)
                .HasColumnType("int(2)")
                .HasColumnName("ID_SERVICE");
            entity.Property(e => e.IdUser)
                .HasColumnType("int(2)")
                .HasColumnName("ID_USER");
            entity.Property(e => e.Texte)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("TEXTE");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.Chats)
                .HasForeignKey(d => d.IdService)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHATS_SERVICE");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Chats)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_CHATS_UTILISATEUR");
        });

        modelBuilder.Entity<Commentaire>(entity =>
        {
            entity.HasKey(e => e.IdCommentaire).HasName("PRIMARY");

            entity
                .ToTable("COMMENTAIRES")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IdService, "I_FK_COMMENTAIRES_SERVICE");

            entity.HasIndex(e => e.IdUser, "I_FK_COMMENTAIRES_UTILISATEUR");

            entity.Property(e => e.IdCommentaire)
                .HasColumnType("smallint(1)")
                .HasColumnName("ID_COMMENTAIRE");
            entity.Property(e => e.Contenu)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("CONTENU");
            entity.Property(e => e.IdService)
                .HasColumnType("int(2)")
                .HasColumnName("ID_SERVICE");
            entity.Property(e => e.IdUser)
                .HasColumnType("int(2)")
                .HasColumnName("ID_USER");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.Commentaires)
                .HasForeignKey(d => d.IdService)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMMENTAIRES_SERVICE");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Commentaires)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_COMMENTAIRES_UTILISATEUR");
        });

        modelBuilder.Entity<Editer>(entity =>
        {
            entity.HasKey(e => new { e.IdService, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("EDITER")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.Id, "I_FK_EDITER_AUTEUR");

            entity.HasIndex(e => e.IdService, "I_FK_EDITER_LECTURE");

            entity.Property(e => e.IdService)
                .HasColumnType("int(2)")
                .HasColumnName("ID_SERVICE");
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Editers)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EDITER_AUTEUR");
        });

        modelBuilder.Entity<EfmigrationsHistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity
                .ToTable("__EFMigrationsHistory")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("GENRE")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Libelle)
                .HasMaxLength(50)
                .HasColumnName("LIBELLE");
        });

        modelBuilder.Entity<Livre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("Livre")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IdGenre, "dgfhjk");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdGenre)
                .HasColumnType("int(11)")
                .HasColumnName("idGenre");
            entity.Property(e => e.Titre)
                .HasMaxLength(150)
                .HasColumnName("titre");

            entity.HasOne(d => d.IdGenreNavigation).WithMany(p => p.Livres)
                .HasForeignKey(d => d.IdGenre)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("dgfhjk");
        });

        modelBuilder.Entity<LivreAuteur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Livre_Auteur")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IdAuteur, "gfchvbjnm,");

            entity.HasIndex(e => e.IdLivre, "trdyfghvbn");

            entity.Property(e => e.IdAuteur)
                .HasColumnType("int(11)")
                .HasColumnName("idAuteur");
            entity.Property(e => e.IdLivre)
                .HasColumnType("int(11)")
                .HasColumnName("idLivre");

            entity.HasOne(d => d.IdAuteurNavigation).WithMany()
                .HasForeignKey(d => d.IdAuteur)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("gfchvbjnm,");

            entity.HasOne(d => d.IdLivreNavigation).WithMany()
                .HasForeignKey(d => d.IdLivre)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("trdyfghvbn");
        });

        modelBuilder.Entity<ServcieType>(entity =>
        {
            entity.HasKey(e => e.IdService).HasName("PRIMARY");

            entity
                .ToTable("SERVCIE_TYPE")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.IdService)
                .HasColumnType("int(11)")
                .HasColumnName("idService");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .HasColumnName("nom");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.IdService).HasName("PRIMARY");

            entity
                .ToTable("SERVICE")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IdUser, "I_FK_SERVICE_UTILISATEUR");

            entity.HasIndex(e => e.LivreLecture, "LivreLecture");

            entity.HasIndex(e => e.TypeEvenement, "typeevent");

            entity.HasIndex(e => e.TypeLoisir, "typeloisir");

            entity.HasIndex(e => e.ServiceType, "typeservice");

            entity.Property(e => e.IdService)
                .HasColumnType("int(11)")
                .HasColumnName("ID_SERVICE");
            entity.Property(e => e.ArriverCovoiturage)
                .HasMaxLength(255)
                .HasColumnName("Arriver_covoiturage");
            entity.Property(e => e.DateRdv).HasColumnName("DATE_RDV");
            entity.Property(e => e.Demande)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEMANDE");
            entity.Property(e => e.DescriptionService).HasColumnName("DESCRIPTION_SERVICE");
            entity.Property(e => e.IdUser)
                .HasColumnType("int(2)")
                .HasColumnName("ID_USER");
            entity.Property(e => e.Lieu)
                .HasMaxLength(255)
                .HasColumnName("LIEU");
            entity.Property(e => e.LivreLecture)
                .HasColumnType("int(11)")
                .HasColumnName("Livre_lecture");
            entity.Property(e => e.NbPersonneJoined)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(3)")
                .HasColumnName("nb_personne_joined");
            entity.Property(e => e.NbPlacesDispo)
                .HasColumnType("int(2)")
                .HasColumnName("NB_PLACES_DISPO");
            entity.Property(e => e.Prix).HasDefaultValueSql("'0'");
            entity.Property(e => e.ServiceType)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("Service_type");
            entity.Property(e => e.Titre)
                .HasMaxLength(32)
                .HasColumnName("titre");
            entity.Property(e => e.TypeEvenement)
                .HasColumnType("int(11)")
                .HasColumnName("Type_evenement");
            entity.Property(e => e.TypeLoisir)
                .HasColumnType("int(11)")
                .HasColumnName("Type_loisir");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICE_UTILISATEUR");

            entity.HasOne(d => d.LivreLectureNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.LivreLecture)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("LivreLecture");

            entity.HasOne(d => d.ServiceTypeNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.ServiceType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("typeservice");

            entity.HasOne(d => d.TypeEvenementNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.TypeEvenement)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("typeevent");

            entity.HasOne(d => d.TypeLoisirNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.TypeLoisir)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("typeloisir");
        });

        modelBuilder.Entity<TypeLoisir>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("TYPE_LOISIRS")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Libelle)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("LIBELLE");
        });

        modelBuilder.Entity<Typeevenement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("TYPEEVENEMENT")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(2)")
                .HasColumnName("ID");
            entity.Property(e => e.Libelle)
                .HasMaxLength(32)
                .IsFixedLength()
                .HasColumnName("LIBELLE");
        });

        modelBuilder.Entity<Typer>(entity =>
        {
            entity.HasKey(e => new { e.IdService, e.Id })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity
                .ToTable("TYPER")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.HasIndex(e => e.IdService, "I_FK_TYPER_LOISIRS");

            entity.HasIndex(e => e.Id, "I_FK_TYPER_TYPE_LOISIRS");

            entity.Property(e => e.IdService)
                .HasColumnType("int(2)")
                .HasColumnName("ID_SERVICE");
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("ID");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Typers)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TYPER_TYPE_LOISIRS");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity
                .ToTable("USER")
                .HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_general_ci");

            entity.Property(e => e.IdUser)
                .HasColumnType("int(5)")
                .HasColumnName("ID_USER");
            entity.Property(e => e.DateInscription).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("'nomail@nomail.nomail'")
                .HasColumnName("EMAIL");
            entity.Property(e => e.Moderateur).HasColumnName("MODERATEUR");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("'Utilisateur'")
                .IsFixedLength()
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Prenom)
                .HasMaxLength(32)
                .HasDefaultValueSql("'USER'")
                .IsFixedLength()
                .HasColumnName("PRENOM");

            entity.HasMany(d => d.IdServices).WithMany(p => p.IdUsers)
                .UsingEntity<Dictionary<string, object>>(
                    "Participer",
                    r => r.HasOne<Service>().WithMany()
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PARTICIPER_SERVICE"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PARTICIPER_UTILISATEUR"),
                    j =>
                    {
                        j.HasKey("IdUser", "IdService")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("PARTICIPER")
                            .HasCharSet("utf8mb4")
                            .UseCollation("utf8mb4_general_ci");
                        j.HasIndex(new[] { "IdService" }, "I_FK_PARTICIPER_SERVICE");
                        j.HasIndex(new[] { "IdUser" }, "I_FK_PARTICIPER_UTILISATEUR");
                        j.IndexerProperty<int>("IdUser")
                            .HasColumnType("int(2)")
                            .HasColumnName("ID_USER");
                        j.IndexerProperty<int>("IdService")
                            .HasColumnType("int(2)")
                            .HasColumnName("ID_SERVICE");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
