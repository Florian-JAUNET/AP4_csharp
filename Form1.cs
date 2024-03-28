using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.Eventing.Reader;

namespace LinkHUb_depuis0
{
    public partial class Menu : Form
    {
        #region Region-fonction
        //menu open form
        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipale.Controls.Add(formEnfant);
            panelPrincipale.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        //hide all menu of menu
        public void visibilityMenuNav(bool visible)
        {
            ggbMenuNav.Visible = visible;
            gbtClose.Visible = visible;
            guna2CircleButton1.Visible = visible;
        }
        public void DisconnectAdmin()
        {
            visibilityMenuNav(false);
            openChildForm(new FormConnexion(this));
        }
        #endregion

        public Menu()
        {
            InitializeComponent();
            openChildForm(new FormConnexion(this));

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            visibilityMenuNav(false);
        }

        private void gbtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbtMenuWallet_Click(object sender, EventArgs e)
        {
            openChildForm(new FormWallet());

        }

        private void gbtMenuLogs_Click(object sender, EventArgs e)
        {
            openChildForm(new FormLog());
        }

        private void gbtMenuModo_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModo());
        }

        private void gbtMenuUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUser());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DisconnectAdmin();
        }

        private void gbtMenuStat_Click(object sender, EventArgs e)
        {
            openChildForm(new FormStat());
        }

        private void gbtMenuService_Click(object sender, EventArgs e)
        {
            openChildForm(new FormService());

        }
    }
}
