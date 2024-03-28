namespace LinkHUb_depuis0
{
    partial class FormConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ggbMenuNav = new Guna.UI2.WinForms.Guna2GroupBox();
            gckbMdp = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            ConnectAdmin = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            gbtMdp = new Guna.UI2.WinForms.Guna2TextBox();
            gbtId = new Guna.UI2.WinForms.Guna2TextBox();
            gbtClose = new Guna.UI2.WinForms.Guna2CircleButton();
            ggbMenuNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ggbMenuNav
            // 
            ggbMenuNav.Anchor = AnchorStyles.Top;
            ggbMenuNav.BorderRadius = 4;
            ggbMenuNav.Controls.Add(gckbMdp);
            ggbMenuNav.Controls.Add(ConnectAdmin);
            ggbMenuNav.Controls.Add(pictureBox1);
            ggbMenuNav.Controls.Add(gbtMdp);
            ggbMenuNav.Controls.Add(gbtId);
            ggbMenuNav.CustomBorderColor = Color.White;
            ggbMenuNav.CustomizableEdges = customizableEdges8;
            ggbMenuNav.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ggbMenuNav.ForeColor = Color.FromArgb(125, 137, 149);
            ggbMenuNav.Location = new Point(97, 12);
            ggbMenuNav.Name = "ggbMenuNav";
            ggbMenuNav.ShadowDecoration.CustomizableEdges = customizableEdges9;
            ggbMenuNav.Size = new Size(1080, 444);
            ggbMenuNav.TabIndex = 4;
            ggbMenuNav.TextAlign = HorizontalAlignment.Center;
            // 
            // gckbMdp
            // 
            gckbMdp.Anchor = AnchorStyles.Top;
            gckbMdp.BackColor = Color.White;
            gckbMdp.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            gckbMdp.Image = Properties.Resources.icons8_binoculars_50;
            gckbMdp.ImageOffset = new Point(0, 0);
            gckbMdp.ImageRotate = 0F;
            gckbMdp.ImageSize = new Size(50, 50);
            gckbMdp.Location = new Point(945, 241);
            gckbMdp.Name = "gckbMdp";
            gckbMdp.ShadowDecoration.CustomizableEdges = customizableEdges1;
            gckbMdp.Size = new Size(59, 60);
            gckbMdp.TabIndex = 7;
            gckbMdp.CheckedChanged += guna2ImageCheckBox1_CheckedChanged;
            // 
            // ConnectAdmin
            // 
            ConnectAdmin.Anchor = AnchorStyles.Top;
            ConnectAdmin.BackColor = SystemColors.ButtonHighlight;
            ConnectAdmin.BorderRadius = 6;
            ConnectAdmin.CustomizableEdges = customizableEdges2;
            ConnectAdmin.DisabledState.BorderColor = Color.DarkGray;
            ConnectAdmin.DisabledState.CustomBorderColor = Color.DarkGray;
            ConnectAdmin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ConnectAdmin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ConnectAdmin.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConnectAdmin.ForeColor = Color.White;
            ConnectAdmin.Location = new Point(158, 334);
            ConnectAdmin.Name = "ConnectAdmin";
            ConnectAdmin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            ConnectAdmin.Size = new Size(770, 75);
            ConnectAdmin.TabIndex = 3;
            ConnectAdmin.Text = "Connexion";
            ConnectAdmin.Click += ConnectAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = SystemColors.HighlightText;
            pictureBox1.Image = Properties.Resources.LinkHub;
            pictureBox1.Location = new Point(372, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // gbtMdp
            // 
            gbtMdp.Anchor = AnchorStyles.Top;
            gbtMdp.Animated = true;
            gbtMdp.BackColor = Color.White;
            gbtMdp.BorderRadius = 6;
            gbtMdp.CustomizableEdges = customizableEdges4;
            gbtMdp.DefaultText = "";
            gbtMdp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gbtMdp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gbtMdp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gbtMdp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gbtMdp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gbtMdp.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtMdp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gbtMdp.Location = new Point(158, 241);
            gbtMdp.Margin = new Padding(5, 7, 5, 7);
            gbtMdp.Name = "gbtMdp";
            gbtMdp.PasswordChar = '\0';
            gbtMdp.PlaceholderText = "Mot de passe";
            gbtMdp.SelectedText = "";
            gbtMdp.ShadowDecoration.CustomizableEdges = customizableEdges5;
            gbtMdp.Size = new Size(770, 60);
            gbtMdp.TabIndex = 1;
            gbtMdp.TextChanged += gbtMdp_TextChanged;
            // 
            // gbtId
            // 
            gbtId.Anchor = AnchorStyles.Top;
            gbtId.Animated = true;
            gbtId.BackColor = Color.White;
            gbtId.BorderRadius = 6;
            gbtId.CustomizableEdges = customizableEdges6;
            gbtId.DefaultText = "";
            gbtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gbtId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gbtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gbtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gbtId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gbtId.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gbtId.Location = new Point(158, 148);
            gbtId.Margin = new Padding(5, 7, 5, 7);
            gbtId.Name = "gbtId";
            gbtId.PasswordChar = '\0';
            gbtId.PlaceholderText = "Email";
            gbtId.SelectedText = "";
            gbtId.ShadowDecoration.CustomizableEdges = customizableEdges7;
            gbtId.Size = new Size(770, 60);
            gbtId.TabIndex = 0;
            // 
            // gbtClose
            // 
            gbtClose.Anchor = AnchorStyles.Top;
            gbtClose.BackgroundImageLayout = ImageLayout.Stretch;
            gbtClose.DisabledState.BorderColor = Color.DarkGray;
            gbtClose.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtClose.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtClose.ForeColor = Color.White;
            gbtClose.Image = Properties.Resources.icons8_close_50;
            gbtClose.ImageSize = new Size(50, 50);
            gbtClose.Location = new Point(604, 462);
            gbtClose.Name = "gbtClose";
            gbtClose.ShadowDecoration.CustomizableEdges = customizableEdges10;
            gbtClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gbtClose.Size = new Size(82, 80);
            gbtClose.TabIndex = 5;
            gbtClose.Click += gbtClose_Click;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(14F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 554);
            Controls.Add(gbtClose);
            Controls.Add(ggbMenuNav);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormConnexion";
            Text = "FormConnexion";
            Load += FormConnexion_Load;
            ggbMenuNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Guna.UI2.WinForms.Guna2GroupBox ggbMenuNav;
        private Guna.UI2.WinForms.Guna2TextBox gbtMdp;
        private Guna.UI2.WinForms.Guna2TextBox gbtId;
        private Guna.UI2.WinForms.Guna2Button ConnectAdmin;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton gbtClose;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gckbMdp;
    }
}