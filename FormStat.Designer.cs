namespace LinkHUb_depuis0
{
    partial class FormStat
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
            oxyStat1 = new OxyPlot.WindowsForms.PlotView();
            oxyStat2 = new OxyPlot.WindowsForms.PlotView();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // oxyStat1
            // 
            oxyStat1.Anchor = AnchorStyles.Top;
            oxyStat1.BackColor = SystemColors.ControlLightLight;
            oxyStat1.Location = new Point(12, 141);
            oxyStat1.Name = "oxyStat1";
            oxyStat1.PanCursor = Cursors.Hand;
            oxyStat1.Size = new Size(837, 401);
            oxyStat1.TabIndex = 0;
            oxyStat1.Text = "plotView1";
            oxyStat1.ZoomHorizontalCursor = Cursors.SizeWE;
            oxyStat1.ZoomRectangleCursor = Cursors.SizeNWSE;
            oxyStat1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // oxyStat2
            // 
            oxyStat2.Anchor = AnchorStyles.Top;
            oxyStat2.BackColor = SystemColors.ControlLightLight;
            oxyStat2.Location = new Point(855, 141);
            oxyStat2.Name = "oxyStat2";
            oxyStat2.PanCursor = Cursors.Hand;
            oxyStat2.Size = new Size(415, 401);
            oxyStat2.TabIndex = 1;
            oxyStat2.Text = "plotView1";
            oxyStat2.ZoomHorizontalCursor = Cursors.SizeWE;
            oxyStat2.ZoomRectangleCursor = Cursors.SizeNWSE;
            oxyStat2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Sans Serif Collection", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(12, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(337, 69);
            guna2HtmlLabel1.TabIndex = 10;
            guna2HtmlLabel1.Text = "STATISTIQUES";
            // 
            // FormStat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 554);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(oxyStat2);
            Controls.Add(oxyStat1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormStat";
            Text = "FormStat";
            Load += FormStat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView oxyStat1;
        private OxyPlot.WindowsForms.PlotView oxyStat2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}