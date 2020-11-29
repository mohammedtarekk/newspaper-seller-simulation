using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TotalCost.Text = Form1.sys.PerformanceMeasures.TotalCost.ToString();
            TotalSalesProfit.Text = Form1.sys.PerformanceMeasures.TotalSalesProfit.ToString();
            TotalLostProfit.Text = Form1.sys.PerformanceMeasures.TotalLostProfit.ToString();
            TotalScrapProfit.Text = Form1.sys.PerformanceMeasures.TotalScrapProfit.ToString();
            TotalNetProfit.Text = Form1.sys.PerformanceMeasures.TotalNetProfit.ToString();
            DaysWithMoreDemand.Text = Form1.sys.PerformanceMeasures.DaysWithMoreDemand.ToString();
            DaysWithUnsoldPapers.Text = Form1.sys.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
        }
    }
}
