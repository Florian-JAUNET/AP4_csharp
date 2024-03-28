using Microsoft.EntityFrameworkCore;
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
    public partial class FormWallet : Form
    {
        #region VariableRegion

        #endregion
        #region FonctionRegion
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
        public FormWallet()
        {
            InitializeComponent();
        }

        private void FormWallet_Load(object sender, EventArgs e)
        {
            remplirListeUser();
        }

        private void gcbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbtAjouter_Click(object sender, EventArgs e)
        {
            Console.WriteLine(gcbUser.SelectedValue);

            string sommeAjoutWallet = gtbEuro.Text;
            //verification que c'est un nombre
            if (gcbUser.SelectedValue != null)
            {
                if (sommeAjoutWallet.All(char.IsDigit) && (gcbUser.SelectedValue.ToString()).All(char.IsDigit) && gcbUser.SelectedValue.ToString() != "" && sommeAjoutWallet != "")
                {

                    int idIndexUserSelected = Convert.ToInt32(gcbUser.SelectedValue.ToString());
                    if (idIndexUserSelected >= 0)
                    {
                        int sommmeAjoutWalletInt = Convert.ToInt32(sommeAjoutWallet);
                        try
                        {
                            Modele.AjouterSommePourUser(idIndexUserSelected, sommmeAjoutWalletInt);
                            FormPopUp formPopDGV = new FormPopUp("SUCCES", "Utulisateur payer ! ", 0, 0);
                            formPopDGV.Show();
                        }
                        catch
                        {
                            FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                            formPopDGV.Show();
                        }
                    }
                    else
                    {
                        FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                        formPopDGV.Show();
                    }
                }
                else
                {
                    FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                formPopDGV.Show();
            }
        }

        private void gbtEnlever_Click(object sender, EventArgs e)
        {
            string sommeAjoutWallet = gtbEuro.Text;
            //verification que c'est un nombre
            if (gcbUser.SelectedValue != null)
            {
                if (sommeAjoutWallet.All(char.IsDigit) && (gcbUser.SelectedValue.ToString()).All(char.IsDigit) && gcbUser.SelectedValue.ToString() != "" && sommeAjoutWallet != "")
                {

                    int idIndexUserSelected = Convert.ToInt32(gcbUser.SelectedValue.ToString());
                    if (idIndexUserSelected >= 0)
                    {
                        int sommmeAjoutWalletInt = Convert.ToInt32(sommeAjoutWallet);
                        try
                        {
                            Modele.SupprimerSommePourUser(idIndexUserSelected, sommmeAjoutWalletInt);
                            FormPopUp formPopDGV = new FormPopUp("SUCCES", "Utulisateur crediter ! ", 0, 0);
                            formPopDGV.Show();
                        }
                        catch
                        {
                            FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                            formPopDGV.Show();
                        }
                    }
                    else
                    {
                        FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                        formPopDGV.Show();
                    }
                }
                else
                {
                    FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un utilisateur et ecriver la somme a ajouter", 0, 0);
                formPopDGV.Show();
            }
        }
    }
}
