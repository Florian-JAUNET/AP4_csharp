using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;
using LiveCharts.Wpf.Points;
using OxyPlot;

namespace LinkHUb_depuis0
{
    public partial class FormStat : Form
    {
        public FormStat()
        {
            InitializeComponent();
        }

        private void FormStat_Load(object sender, EventArgs e)
        {
            //recuperation des donnees : 
            int[] pieStats = Modele.StatServiceNb();
            int[] grafStats = Modele.StatUserNbParMois();
            //-------------


            #region initialisation-des-stats
            // Crée tes données de stats (exemple)
            var stats = new List<DataPoint>
{
    new DataPoint(1, grafStats[0]),
    new DataPoint(2, grafStats[1]),
    new DataPoint(3, grafStats[2]),
    new DataPoint(4, grafStats[3]),
    new DataPoint(5, grafStats[4]),
    new DataPoint(6, grafStats[5]),
    new DataPoint(7, grafStats[6]),
    new DataPoint(8, grafStats[7]),
    new DataPoint(9, grafStats[8]),
    new DataPoint(10, grafStats[9]),
    new DataPoint(11, grafStats[10]),
    new DataPoint(12, grafStats[11]),
    // Ajoute d'autres données ici...
};

            // Crée un modèle de graphique
            var plotModel = new OxyPlot.PlotModel();
            var lineSeries = new OxyPlot.Series.LineSeries
            {
                ItemsSource = stats,
                DataFieldX = "NbUtilisateur",
                DataFieldY = "Mois",
            };
            plotModel.Series.Add(lineSeries);

            // Associe ton modèle de graphique à l'objet OxyPlotWinForms
            oxyStat1.Model = plotModel;
            

            //SECOND-----------------
            // Crée tes données pour le camembert (exemple)
            var stats2 = new List<OxyPlot.Series.PieSlice>
{
    new OxyPlot.Series.PieSlice("Evenement", pieStats[0]),
    new OxyPlot.Series.PieSlice("Echange", pieStats[1]),
    new OxyPlot.Series.PieSlice("Lecture", pieStats[2]),
    new OxyPlot.Series.PieSlice("Loisir", pieStats[3]),
    new OxyPlot.Series.PieSlice("Cinema", pieStats[4]),
    // Ajoute d'autres catégories ici...
};

            // Crée un modèle de graphique
            var plotModel2 = new OxyPlot.PlotModel();
            var pieSeries2 = new OxyPlot.Series.PieSeries
            {
                Slices = stats2,
                Diameter = 0.9, // Taille du camembert (entre 0 et 1)
                StartAngle = 20, // Angle de départ du camembert (en degrés)
                InsideLabelPosition = 0.8, // Position des étiquettes à l'intérieur du camembert (entre 0 et 1)
                OutsideLabelFormat = null, // Format des étiquettes à l'extérieur du camembert (null pour ne pas afficher)
                StrokeThickness = 4, // Épaisseur de la bordure du camembert
            };
            plotModel2.Series.Add(pieSeries2);

            // Associe ton modèle de graphique à l'objet OxyPlotWinForms
            oxyStat2.Model = plotModel2;
            #endregion

        }
    }
}
