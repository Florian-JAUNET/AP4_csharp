using LinkHUb_depuis0.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace LinkHUb_depuis0
{
    internal static class Modele
    {
        private static LinkhubContext monModel;
        public static void init()
        {
            monModel = new LinkhubContext();
        }

        public static DateTime GetDate(this DateOnly dateOnly)
        {
            return new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day);
        }


        public static int[] StatServiceNb()
        {

                int[] counts = new int[5]; // Tableau pour stocker les comptes pour chaque type de service

                for (int i = 1; i <= 5; i++)
                {
                    counts[i - 1] = monModel.Services.Count(s => s.ServiceType == i);
                }

                return counts;
            
        }


        public static void AjouterSommePourUser(int idDuUser,int Somme)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Users.FirstOrDefault(u => u.IdUser == idDuUser);

            if (utilisateur != null)
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Wallet += Somme;

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
        }
        public static void SupprimerSommePourUser(int idDuUser, int Somme)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Users.FirstOrDefault(u => u.IdUser == idDuUser);

            if (utilisateur != null)
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Wallet -= Somme;

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
        }
        public static void GestionModerateur(int idDuUser, bool modo)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Users.FirstOrDefault(u => u.IdUser == idDuUser);

            if (utilisateur != null)
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Moderateur = modo;

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
        }
        public static void DesactiverCompte(int idDuUser)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Users.FirstOrDefault(u => u.IdUser == idDuUser);

            if (utilisateur != null)
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Password = "desactiver";

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
        }
        public static void SupprimerCompte(int idDuUser)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Users.FirstOrDefault(u => u.IdUser == idDuUser);

            if (utilisateur != null)
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Password = "Deleted-User";
                utilisateur.Email = "Deleted@Deleted.Deleted";
                utilisateur.Wallet = 0;
                utilisateur.Name = "Deleted-User";
                utilisateur.Prenom = "Deleted-User";
                utilisateur.Moderateur = false;

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
        }
        public static void SupprimerService(int IdDuService)
        {
            // Récupère le service avec l'ID spécifié
            var serviceASupprimer = monModel.Services.FirstOrDefault(s => s.IdService == IdDuService);

            if (serviceASupprimer != null)
            {
                // Supprime le service de la base de données
                monModel.Services.Remove(serviceASupprimer);

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
                Console.WriteLine("Service supprimé avec succès!");
            }
            else
            {
                Console.WriteLine("Le service spécifié n'existe pas.");
            }
        }

        public static void ModifierCompte(int idDuUser,string nom,string prenom)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Users.FirstOrDefault(u => u.IdUser == idDuUser);

            if (utilisateur != null && nom.Length <= 150 && prenom.Length <= 150)
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Name = nom;
                utilisateur.Prenom = prenom;

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Veuiller utuliser une longeur correct", 0, 0);
                formPopDGV.Show();
            }
        }

        public static void ModifierService(int idDuService, string titre, string desc,string lieu,string prix)
        {
            // Récupère l'utilisateur avec l'ID idUser
            var utilisateur = monModel.Services.FirstOrDefault(u => u.IdService == idDuService);

            if (utilisateur != null && titre.Length <= 250 && desc.Length <= 250 && lieu.Length <= 250 && prix.All(char.IsDigit))
            {
                // Ajoute Somme à la wallet de l'utilisateur
                utilisateur.Titre = titre;
                utilisateur.DescriptionService = desc;
                utilisateur.Lieu = lieu;
                utilisateur.Prix = Convert.ToInt32(prix);

                // Enregistre les modifications dans la base de données
                monModel.SaveChanges();
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Veuiller utuliser une longeur correct et un nombre pour le prix", 0, 0);
                formPopDGV.Show();
            }
        }



        public static int[] StatUserNbParMois()
        {

            int[] counts = new int[12]; // Tableau pour stocker les comptes pour chaque mois

            // Obtient l'année en cours
            int anneeCourante = DateTime.Now.Year;

            // Itère à travers chaque mois de l'année en cours
            for (int mois = 1; mois <= 12; mois++)
            {

                // Utilise LINQ pour compter le nombre d'utilisateurs pour le mois en cours
                counts[mois - 1] = monModel.Users
                    .ToList() // ou .ToArray()
                    .Count(u => u.DateInscription.Month == mois);
            }

            return counts;

        }
        
        public static List<Admin> getAdmin()
        {
            return monModel.Admins.ToList();
        }
        public static List<AdminLog> getLog()
        {
            return monModel.AdminLogs.ToList();
        }
        public static List<User> getUser()
        {
            return monModel.Users.OrderBy(u => u.Prenom).ToList();
        }


        public static List<Service> getService()
        {
            return monModel.Services.OrderBy(u => u.Titre).Join(
                monModel.ServcieTypes,
                service => service.ServiceType,
                serviceType => serviceType.IdService,
                (service, serviceType) => service).ToList();
        }



    }
}
