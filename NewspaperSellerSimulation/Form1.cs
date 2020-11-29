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
    public partial class Form1 : Form
    {
        public static SimulationSystem sys;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sys = new SimulationSystem();

            // pass inputs to the system object
            sys.NumOfNewspapers = Convert.ToInt32(numOfNewspapers_txt.Text);
            sys.NumOfRecords = Convert.ToInt32(numOfRecords_txt.Text);
            sys.PurchasePrice = Convert.ToDecimal(purchasePrice_txt.Text);
            sys.SellingPrice = Convert.ToDecimal(sellingPrice_txt.Text);
            sys.ScrapPrice = Convert.ToDecimal(scrapPrice_txt.Text);

            DayTypeDistribution goodDist, fairDist, poorDist;

            goodDist = new DayTypeDistribution {
                DayType = Enums.DayType.Good,
                Probability = Convert.ToDecimal(good_txt.Text)
            };
            sys.DayTypeDistributions.Add(goodDist);

            fairDist = new DayTypeDistribution
            {
                DayType = Enums.DayType.Fair,
                Probability = Convert.ToDecimal(fair_txt.Text)
            };
            sys.DayTypeDistributions.Add(fairDist);

            poorDist = new DayTypeDistribution
            {
                DayType = Enums.DayType.Poor,
                Probability = Convert.ToDecimal(poor_txt.Text)
            };
            sys.DayTypeDistributions.Add(poorDist);

            int numOfdemandDists = demandDists_dgv.Rows.Count - 1;
            DemandDistribution demandDist;
            DayTypeDistribution dayDist;
            for (int i = 0; i < numOfdemandDists; i++)
            {
                demandDist = new DemandDistribution();
                demandDist.Demand = Convert.ToInt32(demandDists_dgv.Rows[i].Cells[0].Value);

                for(int j = 0; j < sys.DayTypeDistributions.Count; j++)
                {
                    dayDist = new DayTypeDistribution();
                    dayDist.DayType = sys.DayTypeDistributions[j].DayType;
                    dayDist.Probability = Convert.ToDecimal(demandDists_dgv.Rows[i].Cells[j+1].Value);

                    demandDist.DayTypeDistributions.Add(dayDist);
                }

                sys.DemandDistributions.Add(demandDist);
            }


            // call process functions
            sys.Initialize_Inputs();
            sys.Start_Process();

            // fill gui with result data
            results_dgv.Rows.Clear();
            foreach(var record in sys.SimulationTable)
                results_dgv.Rows.Add(record.DayNo, record.RandomNewsDayType, record.NewsDayType.ToString(), record.RandomDemand, record.Demand, record.SalesProfit, record.LostProfit, record.ScrapProfit, record.DailyNetProfit);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string testresult = TestingManager.Test(sys, Constants.FileNames.TestCase1);
            MessageBox.Show(testresult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
