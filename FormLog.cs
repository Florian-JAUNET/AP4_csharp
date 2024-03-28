using Microsoft.EntityFrameworkCore.Query;
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
    public partial class FormLog : Form
    {
        #region functionRegion
        public string getLogstring()
        {
            string logsTexte = "";
            var listLog = Modele.getLog();
            foreach (var item in listLog)
            {
                logsTexte += $"{item.Datelog:dd-MM-yyyy} - {item.Log}\n";
            }
            return logsTexte;
        }


        #endregion
        public FormLog()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            rtbTextLog.Text = getLogstring();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gbtActualise_Click(object sender, EventArgs e)
        {
            rtbTextLog.Text = getLogstring();
        }
    }
}
