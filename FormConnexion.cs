using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace LinkHUb_depuis0
{
    public partial class FormConnexion : Form
    {
        int devMode = 1;
        #region variableRegion
        private Menu parentForm;
        #endregion
        #region functionRegion

        //menu open form

        //hide all menu of menu
        public void visibilityMenuNav(bool visible)
        {

        }

        #endregion
        public FormConnexion(Menu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void ConnectAdmin_Click(object sender, EventArgs e)
        {
            bool connexionAvecID1 = Modele.getAdmin().Any(x => x.EMail == gbtId.Text && x.HashMdp == gbtMdp.Text);
            try
            {
                if (connexionAvecID1 || devMode == 1)
                {
                    this.Close();
                    parentForm.visibilityMenuNav(true); // Appelle la méthode visibilityMenuNav si parentForm est de type Menu
                }
                else
                {
                    FormPopUp formPopDGV = new FormPopUp("","Erreur lors de l'identification",0,0);
                    formPopDGV.Show();
                }
            }
            catch (Exception xeu)
            {
                FormPopUp formPopDGV = new FormPopUp("", "Erreur lors de l'identification", 0, 0);
                formPopDGV.Show();
            }
        }

        private void gbtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (gckbMdp.Checked)
            {
                // Si le bouton radio est coché, afficher le mot de passe, sinon le masquer.
                gbtMdp.UseSystemPasswordChar = false;
            }
            else
            {
                gbtMdp.UseSystemPasswordChar = true;

            }
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            gbtMdp.UseSystemPasswordChar = true;
        }

        private void gbtMdp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
