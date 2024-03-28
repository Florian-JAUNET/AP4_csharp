namespace LinkHUb_depuis0
{
    partial class FormPopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopUp));
            rtbText = new RichTextBox();
            SuspendLayout();
            // 
            // rtbText
            // 
            rtbText.BorderStyle = BorderStyle.None;
            rtbText.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rtbText.Location = new Point(12, 12);
            rtbText.Name = "rtbText";
            rtbText.Size = new Size(530, 233);
            rtbText.TabIndex = 0;
            rtbText.Text = "";
            // 
            // FormPopUp
            // 
            AutoScaleDimensions = new SizeF(14F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 257);
            Controls.Add(rtbText);
            Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "!";
            TopMost = true;
            Load += FormPopUp_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbText;
    }
}