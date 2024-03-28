using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkHUb_depuis0
{
    public partial class FormModo : Form
    {
        private void remplirListeUser()
        {
            try
            {
                // remplir la comboBox des ressources (si modification)
                gcbUser.ValueMember = "idUser";    //permet de stocker l'identifiant
                gcbUser.DisplayMember = "PRENOM";
                bsUserList.DataSource = Modele.getUser();
                gcbUser.DataSource = bsUserList;
            }
            catch
            {

            }
        }
        public FormModo()
        {
            InitializeComponent();
        }

        private void gbtPromotion_Click(object sender, EventArgs e)
        {
            //verification que c'est un nombre
            if (gcbUser.SelectedValue != null)
            {
                if ((gcbUser.SelectedValue.ToString()).All(char.IsDigit) && gcbUser.SelectedValue.ToString() != "" && gcbUser.SelectedValue != null)
                {

                    int idIndexUserSelected = Convert.ToInt32(gcbUser.SelectedValue.ToString());
                    if (idIndexUserSelected >= 0)
                    {

                        try
                        {
                            Modele.GestionModerateur(idIndexUserSelected, true);
                            FormPopUp formPopDGV = new FormPopUp("SUCCES", "Utulisateur a present moderateur ! ", 0, 0);
                            formPopDGV.Show();
                        }
                        catch
                        {
                            FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                            formPopDGV.Show();
                        }
                    }
                    else
                    {
                        FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                        formPopDGV.Show();
                    }
                }
                else
                {
                    FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                formPopDGV.Show();
            }


        }

        private void gbtDepromotion_Click(object sender, EventArgs e)
        {

            //verification que c'est un nombre
            if (gcbUser.SelectedValue != null)
            {
                if ((gcbUser.SelectedValue.ToString()).All(char.IsDigit) && gcbUser.SelectedValue.ToString() != "" && gcbUser.SelectedValue != null)
                {

                    int idIndexUserSelected = Convert.ToInt32(gcbUser.SelectedValue.ToString());
                    if (idIndexUserSelected >= 0)
                    {

                        try
                        {
                            Modele.GestionModerateur(idIndexUserSelected, false);
                            FormPopUp formPopDGV = new FormPopUp("SUCCES", "Utulisateur a present enlevr de l'equipe de moderation ! ", 0, 0);
                            formPopDGV.Show();
                        }
                        catch
                        {
                            FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                            formPopDGV.Show();
                        }
                    }
                    else
                    {
                        FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                        formPopDGV.Show();
                    }
                }
                else
                {
                    FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                formPopDGV.Show();
            }
        }

        private void gbtBan_Click(object sender, EventArgs e)
        {

            //verification que c'est un nombre
            if (gcbUser.SelectedValue != null)
            {
                if ((gcbUser.SelectedValue.ToString()).All(char.IsDigit) && gcbUser.SelectedValue.ToString() != "" && gcbUser.SelectedValue != null)
                {

                    int idIndexUserSelected = Convert.ToInt32(gcbUser.SelectedValue.ToString());
                    if (idIndexUserSelected >= 0)
                    {

                        try
                        {
                            Modele.DesactiverCompte(idIndexUserSelected);
                            FormPopUp formPopDGV = new FormPopUp("SUCCES", "Utulisateur a present desactiver ! ", 0, 0);
                            formPopDGV.Show();
                        }
                        catch
                        {
                            FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                            formPopDGV.Show();
                        }
                    }
                    else
                    {
                        FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                        formPopDGV.Show();
                    }
                }
                else
                {
                    FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur", 0, 0);
                formPopDGV.Show();
            }
        }

        private void FormModo_Load(object sender, EventArgs e)
        {
            remplirListeUser();
        }
    }
}
