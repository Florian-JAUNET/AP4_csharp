namespace LinkHUb_depuis0
{
    partial class FormModo
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            gcbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            gbtPromotion = new Guna.UI2.WinForms.Guna2Button();
            ggbGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            gbtDepromotion = new Guna.UI2.WinForms.Guna2Button();
            gbtBan = new Guna.UI2.WinForms.Guna2Button();
            gckbMdp = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            bsUserList = new BindingSource(components);
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
            gcbUser.TabIndex = 1;
            // 
            // gbtPromotion
            // 
            gbtPromotion.Anchor = AnchorStyles.Top;
            gbtPromotion.BackColor = SystemColors.Control;
            gbtPromotion.BorderRadius = 6;
            gbtPromotion.CustomizableEdges = customizableEdges3;
            gbtPromotion.DisabledState.BorderColor = Color.DarkGray;
            gbtPromotion.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtPromotion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtPromotion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtPromotion.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtPromotion.ForeColor = Color.White;
            gbtPromotion.Location = new Point(23, 43);
            gbtPromotion.Name = "gbtPromotion";
            gbtPromotion.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbtPromotion.Size = new Size(269, 97);
            gbtPromotion.TabIndex = 7;
            gbtPromotion.Text = "Promouvoir moderateur";
            gbtPromotion.Click += gbtPromotion_Click;
            // 
            // ggbGroupBox
            // 
            ggbGroupBox.Anchor = AnchorStyles.Top;
            ggbGroupBox.BorderRadius = 6;
            ggbGroupBox.Controls.Add(gbtDepromotion);
            ggbGroupBox.Controls.Add(gbtBan);
            ggbGroupBox.Controls.Add(gckbMdp);
            ggbGroupBox.Controls.Add(gbtPromotion);
            ggbGroupBox.CustomBorderColor = Color.White;
            ggbGroupBox.CustomizableEdges = customizableEdges10;
            ggbGroupBox.Font = new Font("Sans Serif Collection", 10.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ggbGroupBox.ForeColor = Color.FromArgb(125, 137, 149);
            ggbGroupBox.Location = new Point(400, 173);
            ggbGroupBox.Margin = new Padding(5, 6, 5, 6);
            ggbGroupBox.Name = "ggbGroupBox";
            ggbGroupBox.ShadowDecoration.CustomizableEdges = customizableEdges11;
            ggbGroupBox.Size = new Size(868, 185);
            ggbGroupBox.TabIndex = 8;
            ggbGroupBox.TextAlign = HorizontalAlignment.Center;
            // 
            // gbtDepromotion
            // 
            gbtDepromotion.Anchor = AnchorStyles.Top;
            gbtDepromotion.BackColor = SystemColors.Control;
            gbtDepromotion.BorderRadius = 6;
            gbtDepromotion.CustomizableEdges = customizableEdges5;
            gbtDepromotion.DisabledState.BorderColor = Color.DarkGray;
            gbtDepromotion.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtDepromotion.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtDepromotion.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtDepromotion.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtDepromotion.ForeColor = Color.White;
            gbtDepromotion.Location = new Point(298, 43);
            gbtDepromotion.Name = "gbtDepromotion";
            gbtDepromotion.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbtDepromotion.Size = new Size(269, 97);
            gbtDepromotion.TabIndex = 9;
            gbtDepromotion.Text = "Enlever le role de moderateur";
            gbtDepromotion.Click += gbtDepromotion_Click;
            // 
            // gbtBan
            // 
            gbtBan.Anchor = AnchorStyles.Top;
            gbtBan.BackColor = SystemColors.Control;
            gbtBan.BorderRadius = 6;
            gbtBan.CustomizableEdges = customizableEdges7;
            gbtBan.DisabledState.BorderColor = Color.DarkGray;
            gbtBan.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtBan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtBan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtBan.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtBan.ForeColor = Color.White;
            gbtBan.Location = new Point(573, 43);
            gbtBan.Name = "gbtBan";
            gbtBan.ShadowDecoration.CustomizableEdges = customizableEdges8;
            gbtBan.Size = new Size(269, 97);
            gbtBan.TabIndex = 8;
            gbtBan.Text = "Desactiver le compte";
            gbtBan.Click += gbtBan_Click;
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
            gckbMdp.Location = new Point(1970, 446);
            gckbMdp.Margin = new Padding(5, 6, 5, 6);
            gckbMdp.Name = "gckbMdp";
            gckbMdp.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gckbMdp.Size = new Size(103, 111);
            gckbMdp.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(400, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(647, 69);
            guna2HtmlLabel1.TabIndex = 9;
            guna2HtmlLabel1.Text = "GESTION DES MODERATEUR";
            // 
            // FormModo
            // 
            AutoScaleDimensions = new SizeF(14F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 573);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(ggbGroupBox);
            Controls.Add(gcbUser);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormModo";
            Text = "FormModo";
            Load += FormModo_Load;
            ggbGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox gcbUser;
        private Guna.UI2.WinForms.Guna2Button gbtPromotion;
        public Guna.UI2.WinForms.Guna2GroupBox ggbGroupBox;
        private Guna.UI2.WinForms.Guna2ImageCheckBox gckbMdp;
        private Guna.UI2.WinForms.Guna2Button gbtDepromotion;
        private Guna.UI2.WinForms.Guna2Button gbtBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private BindingSource bsUserList;
    }
}