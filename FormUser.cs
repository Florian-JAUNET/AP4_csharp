using LinkHUb_depuis0.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkHUb_depuis0.Entities;

namespace LinkHUb_depuis0
{
    public partial class FormUser : Form
    {
        #region bariableRegion
        int idUserSelected = -1;
        #endregion
        #region functionRegion
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

        #endregion

        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            remplirListeUser();
        }

        private void gcbUser_SelectedIndexChanged(object sender, EventArgs e)
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
                            idUserSelected = idIndexUserSelected;
                            // récupération de la ressource sélectionnée
                            User R = (User)bsUserList.Current;

                            // mise à jour des champs de la ressource sélectionnée
                            gtbInfoNom.Text = R.Name;
                            gtbInfoPrenom.Text = R.Prenom;
                            gtbInfoEmail.Text = R.Email;
                            gtbInfoWallet.Text = R.Wallet.ToString();
                            bool modo = R.Moderateur;
                            if (modo)
                            {
                                gtbInfoModo.Text = "Moderateur";
                            }
                            else
                            {
                                gtbInfoModo.Text = "Simple utilisateur";
                            }
                        }
                        catch
                        {
                            idUserSelected = -1;
                        }
                    }
                    else
                    {
                        idUserSelected = -1;
                    }
                }
                else
                {
                    idUserSelected = -1;
                }
            }
            else
            {
                idUserSelected = -1;
            }


        }

        private void bsUserList_CurrentChanged(object sender, EventArgs e)
        {
            gcbUser_SelectedIndexChanged(sender, e);
        }

        private void gbtDelete_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur, cette action est irreversible ?", "Confirmation de suppression", MessageBoxButtons.OKCancel);
            if (idUserSelected != -1)
            {
                if (resultat == DialogResult.OK)
                {
                    Modele.SupprimerCompte(idUserSelected);
                    FormPopUp formPopDGV = new FormPopUp("", "Utilisateur supprimer !", 0, 0);
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur !", 0, 0);
                formPopDGV.Show();
            }
        }

        private void gbtDesactiver_Click(object sender, EventArgs e)
        {
            if (idUserSelected != -1)
            {
                Modele.DesactiverCompte(idUserSelected);
                FormPopUp formPopDGV = new FormPopUp("", "Utilisateur Desactiver !", 0, 0);
                formPopDGV.Show();
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur !", 0, 0);
                formPopDGV.Show();
            }
        }

        private void gbtModification_Click(object sender, EventArgs e)
        {
            if (idUserSelected != -1)
            {
                Modele.ModifierCompte(idUserSelected,gtbInfoNom.Text,gtbInfoPrenom.Text);
                FormPopUp formPopDGV = new FormPopUp("", "Utilisateur Modifier !", 0, 0);
                formPopDGV.Show();
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur !", 0, 0);
                formPopDGV.Show();
            }
        }
    }
}
