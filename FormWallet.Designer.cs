namespace LinkHUb_depuis0
{
    partial class FormWallet
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWallet));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gcbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            ggbGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            gckbMdp = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            gtbEuro = new Guna.UI2.WinForms.Guna2TextBox();
            gbtAjouter = new Guna.UI2.WinForms.Guna2Button();
            bsUserList = new BindingSource(components);
            gbtEnlever = new Guna.UI2.WinForms.Guna2Button();
            ggbGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsUserList).BeginInit();
            SuspendLayout();
            // 
            // gcbUser
            // 
            gcbUser.BackColor = Color.Transparent;
            gcbUser.BorderRadius = 5;
            gcbUser.CustomizableEdges = customizableEdges1;
            gcbUser.DrawMode = DrawMode.OwnerDrawFixed;
            gcbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            gcbUser.FocusedColor = Color.FromArgb(94, 148, 255);
            gcbUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gcbUser.Font = new Font("Segoe UI", 10F);
            gcbUser.ForeColor = Color.FromArgb(68, 88, 112);
            gcbUser.ItemHeight = 30;
            gcbUser.Location = new Point(12, 15);
            gcbUser.Name = "gcbUser";
            gcbUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gcbUser.Size = new Size(348, 36);
            gcbUser.TabIndex = 0;
            gcbUser.SelectedIndexChanged += gcbUser_SelectedIndexChanged;
            // 
            // ggbGroupBox
            // 
            ggbGroupBox.Anchor = AnchorStyles.Top;
            ggbGroupBox.BorderRadius = 6;
            ggbGroupBox.Controls.Add(gckbMdp);
            ggbGroupBox.Controls.Add(gtbEuro);
            ggbGroupBox.CustomBorderColor = Color.White;
            ggbGroupBox.CustomizableEdges = customizableEdges6;
            ggbGroupBox.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ggbGroupBox.ForeColor = Color.FromArgb(125, 137, 149);
            ggbGroupBox.Location = new Point(382, 15);
            ggbGroupBox.Margin = new Padding(5, 6, 5, 6);
            ggbGroupBox.Name = "ggbGroupBox";
            ggbGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges7;
            ggbGroupBox.Size = new Size(591, 543);
            ggbGroupBox.TabIndex = 5;
            ggbGroupBox.Text = "Ajout d'argent au wallet d'un utilisateur";
            ggbGroupBox.TextAlign = HorizontalAlignment.Center;
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
            gckbMdp.Location = new Point(1686, 446);
            gckbMdp.Margin = new Padding(5, 6, 5, 6);
            gckbMdp.Name = "gckbMdp";
            gckbMdp.ShadowDecoration.CustomizableEdges = customizableEdges3;
            gckbMdp.Size = new Size(103, 111);
            gckbMdp.TabIndex = 7;
            // 
            // gtbEuro
            // 
            gtbEuro.Anchor = AnchorStyles.Top;
            gtbEuro.Animated = true;
            gtbEuro.BackColor = Color.White;
            gtbEuro.BorderRadius = 6;
            gtbEuro.CustomizableEdges = customizableEdges4;
            gtbEuro.DefaultText = "";
            gtbEuro.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtbEuro.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtbEuro.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtbEuro.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtbEuro.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbEuro.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gtbEuro.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbEuro.Location = new Point(25, 197);
            gtbEuro.Margin = new Padding(12, 17, 12, 17);
            gtbEuro.Name = "gtbEuro";
            gtbEuro.PasswordChar = '\0';
            gtbEuro.PlaceholderText = "En EURO";
            gtbEuro.SelectedText = "";
            gtbEuro.ShadowDecoration.CustomizableEdges = customizableEdges5;
            gtbEuro.Size = new Size(537, 123);
            gtbEuro.TabIndex = 0;
            // 
            // gbtAjouter
            // 
            gbtAjouter.Anchor = AnchorStyles.Top;
            gbtAjouter.BackColor = SystemColors.Control;
            gbtAjouter.BorderRadius = 6;
            gbtAjouter.CustomizableEdges = customizableEdges8;
            gbtAjouter.DisabledState.BorderColor = Color.DarkGray;
            gbtAjouter.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtAjouter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtAjouter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtAjouter.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtAjouter.ForeColor = Color.White;
            gbtAjouter.Location = new Point(1001, 461);
            gbtAjouter.Name = "gbtAjouter";
            gbtAjouter.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gbtAjouter.Size = new Size(269, 97);
            gbtAjouter.TabIndex = 3;
            gbtAjouter.Text = "Ajouter";
            gbtAjouter.Click += gbtAjouter_Click;
            // 
            // gbtEnlever
            // 
            gbtEnlever.Anchor = AnchorStyles.Top;
            gbtEnlever.BackColor = SystemColors.Control;
            gbtEnlever.BorderRadius = 6;
            gbtEnlever.CustomizableEdges = customizableEdges10;
            gbtEnlever.DisabledState.BorderColor = Color.DarkGray;
            gbtEnlever.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtEnlever.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtEnlever.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtEnlever.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtEnlever.ForeColor = Color.White;
            gbtEnlever.Location = new Point(1001, 348);
            gbtEnlever.Name = "gbtEnlever";
            gbtEnlever.ShadowDecoration.CustomizableEdges = customizableEdges11;
            gbtEnlever.Size = new Size(269, 97);
            gbtEnlever.TabIndex = 6;
            gbtEnlever.Text = "Enlever";
            gbtEnlever.Click += gbtEnlever_Click;
            // 
            // FormWallet
            // 
            AutoScaleDimensions = new SizeF(14F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 573);
            Controls.Add(gbtEnlever);
            Controls.Add(ggbGroupBox);
            Controls.Add(gbtAjouter);
            Controls.Add(gcbUser);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormWallet";
            Text = "FormWallet";
            Load += FormWallet_Load;
            ggbGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox gcbUser;
        public Guna.UI2.WinForms.Guna2GroupBox ggbGroupBox;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gckbMdp;
        private Guna.UI2.WinForms.Guna2TextBox gtbEuro;
        private Guna.UI2.WinForms.Guna2Button gbtAjouter;
        private BindingSource bsUserList;
        private Guna.UI2.WinForms.Guna2Button gbtEnlever;
    }
}