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
    public partial class FormService : Form
    {
        #region bariableRegion
        int idServiceSelected = -1;
        #endregion
        #region functionRegion
        private void remplirListeUser()
        {
            try
            {
                // remplir la comboBox des ressources (si modification)
                gcbService.ValueMember = "idservice";    //permet de stocker l'identifiant
                gcbService.DisplayMember = "titre";
                bsServiceList.DataSource = Modele.getService();
                gcbService.DataSource = bsServiceList;
            }
            catch
            {

            }
        }

        #endregion
        public FormService()
        {
            InitializeComponent();
        }

        private void gbtDelete_Click(object sender, EventArgs e)
        {
            if (idServiceSelected != -1)
            {
                Modele.SupprimerService(idServiceSelected);
                FormPopUp formPopDGV = new FormPopUp("", "Service Supprimer !", 0, 0);
                formPopDGV.Show();
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un Service !", 0, 0);
                formPopDGV.Show();
            }
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            remplirListeUser();
        }

        private void gcbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verification que c'est un nombre
            if (gcbService.SelectedValue != null)
            {
                if ((gcbService.SelectedValue.ToString()).All(char.IsDigit) && gcbService.SelectedValue.ToString() != "" && gcbService.SelectedValue != null)
                {

                    int idIndexUserSelected = Convert.ToInt32(gcbService.SelectedValue.ToString());
                    if (idIndexUserSelected >= 0)
                    {

                        try
                        {
                            idServiceSelected = idIndexUserSelected;
                            // récupération de la ressource sélectionnée
                            Service R = (Service)bsServiceList.Current;


                            // mise à jour des champs de la ressource sélectionnée
                            gtbInfoDesc.Text = R.DescriptionService;
                            int servicId = R.ServiceType;
                            gtbInfoTitre.Text = R.Titre;
                            gtbInfoLieu.Text = R.Lieu;
                            gtbInfoPrix.Text = R.Prix.ToString();

                            switch (servicId)
                            {
                                case 1:
                                    gtbInfoType.Text = "evenement";
                                    break;
                                case 2:
                                    gtbInfoType.Text = "echange";
                                    break;
                                case 3:
                                    gtbInfoType.Text = "lecture";
                                    break;
                                case 4:
                                    gtbInfoType.Text = "loisir";
                                    break;
                                case 5:
                                    gtbInfoType.Text = "cinema";
                                    break;
                                default:
                                    gtbInfoType.Text = "evenement";
                                    break;
                            }

                            bool? modo = R.Demande;
                            if (modo == true)
                            {
                                gbtInfoDemande.Text = "Oui";
                            }
                            else
                            {
                                gbtInfoDemande.Text = "Non";
                            }
                        }
                        catch
                        {
                            idServiceSelected = -1;
                        }
                    }
                    else
                    {
                        idServiceSelected = -1;
                    }
                }
                else
                {
                    idServiceSelected = -1;
                }
            }
            else
            {
                idServiceSelected = -1;
            }
        }

        private void bsServiceList_CurrentChanged(object sender, EventArgs e)
        {
            gcbService_SelectedIndexChanged(sender, e);

        }

        private void gbtModification_Click(object sender, EventArgs e)
        {
            if (idServiceSelected != -1)
            {
                Modele.ModifierService(idServiceSelected, gtbInfoTitre.Text, gtbInfoDesc.Text, gtbInfoLieu.Text, gtbInfoPrix.Text);
                FormPopUp formPopDGV = new FormPopUp("", "Service Modifier !", 0, 0);
                formPopDGV.Show();
            }
            else
            {
                FormPopUp formPopDGV = new FormPopUp("", "Selectionner un Service !", 0, 0);
                formPopDGV.Show();
            }
        }
    }
}
