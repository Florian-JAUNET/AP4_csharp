namespace LinkHUb_depuis0
{
    partial class FormLog
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            rtbTextLog = new RichTextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            gbtActualise = new Guna.UI2.WinForms.Guna2CircleButton();
            SuspendLayout();
            // 
            // rtbTextLog
            // 
            rtbTextLog.Anchor = AnchorStyles.Top;
            rtbTextLog.BorderStyle = BorderStyle.None;
            rtbTextLog.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rtbTextLog.Location = new Point(12, 73);
            rtbTextLog.Name = "rtbTextLog";
            rtbTextLog.Size = new Size(1258, 488);
            rtbTextLog.TabIndex = 1;
            rtbTextLog.Text = "";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(12, -2);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(132, 69);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "LOGS";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // gbtActualise
            // 
            gbtActualise.Anchor = AnchorStyles.Top;
            gbtActualise.BackColor = SystemColors.ButtonHighlight;
            gbtActualise.BackgroundImageLayout = ImageLayout.Stretch;
            gbtActualise.DisabledState.BorderColor = Color.DarkGray;
            gbtActualise.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtActualise.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtActualise.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtActualise.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbtActualise.ForeColor = Color.White;
            gbtActualise.Image = Properties.Resources.icons8_restart_50;
            gbtActualise.ImageSize = new Size(50, 50);
            gbtActualise.Location = new Point(1141, 111);
            gbtActualise.Name = "gbtActualise";
            gbtActualise.ShadowDecoration.CustomizableEdges = customizableEdges1;
            gbtActualise.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gbtActualise.Size = new Size(65, 60);
            gbtActualise.TabIndex = 7;
            gbtActualise.Click += gbtActualise_Click;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(14F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 573);
            Controls.Add(gbtActualise);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(rtbTextLog);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormLog";
            Text = "FormLog";
            Load += FormLog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbTextLog;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2CircleButton gbtActualise;
    }
}