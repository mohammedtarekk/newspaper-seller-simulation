using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();            
            Cost = 0;
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        public decimal Cost;

        ///////////// IMPLEMENTATION /////////////
        private void Calc_Cummlative_for_days()
        {
            DayTypeDistributions[0].CummProbability = DayTypeDistributions[0].Probability;
            DayTypeDistributions[0].MinRange = 1;
            DayTypeDistributions[0].MaxRange = Convert.ToInt32(DayTypeDistributions[0].CummProbability * 100);
            for (int i = 1; i < DayTypeDistributions.Count; i++)
            {
                DayTypeDistributions[i].CummProbability = DayTypeDistributions[i].Probability + DayTypeDistributions[i - 1].CummProbability;
                DayTypeDistributions[i].MinRange = Convert.ToInt32(DayTypeDistributions[i - 1].MaxRange) + 1;
                DayTypeDistributions[i].MaxRange = Convert.ToInt32(DayTypeDistributions[i].CummProbability * 100);
            }
        }

        private void Calc_Cummlative_for_demands()
        {
            // calculate for good days
            DemandDistributions[0].DayTypeDistributions[0].CummProbability = DemandDistributions[0].DayTypeDistributions[0].Probability;
            DemandDistributions[0].DayTypeDistributions[0].MinRange = 1;
            DemandDistributions[0].DayTypeDistributions[0].MaxRange = Convert.ToInt32(DemandDistributions[0].DayTypeDistributions[0].CummProbability * 100);
            for (int i = 1; i < DemandDistributions.Count; i++)
            {
                DemandDistributions[i].DayTypeDistributions[0].CummProbability = DemandDistributions[i].DayTypeDistributions[0].Probability + DemandDistributions[i - 1].DayTypeDistributions[0].CummProbability;
                DemandDistributions[i].DayTypeDistributions[0].MinRange = Convert.ToInt32(DemandDistributions[i - 1].DayTypeDistributions[0].MaxRange) + 1;
                DemandDistributions[i].DayTypeDistributions[0].MaxRange = Convert.ToInt32(DemandDistributions[i].DayTypeDistributions[0].CummProbability * 100);
            }

            // calculate for fair days
            DemandDistributions[0].DayTypeDistributions[1].CummProbability = DemandDistributions[0].DayTypeDistributions[1].Probability;
            DemandDistributions[0].DayTypeDistributions[1].MinRange = 1;
            DemandDistributions[0].DayTypeDistributions[1].MaxRange = Convert.ToInt32(DemandDistributions[0].DayTypeDistributions[1].CummProbability * 100);
            for (int i = 1; i < DemandDistributions.Count; i++)
            {
                DemandDistributions[i].DayTypeDistributions[1].CummProbability = DemandDistributions[i].DayTypeDistributions[1].Probability + DemandDistributions[i - 1].DayTypeDistributions[1].CummProbability;
                DemandDistributions[i].DayTypeDistributions[1].MinRange = Convert.ToInt32(DemandDistributions[i - 1].DayTypeDistributions[1].MaxRange) + 1;
                DemandDistributions[i].DayTypeDistributions[1].MaxRange = Convert.ToInt32(DemandDistributions[i].DayTypeDistributions[1].CummProbability * 100);
            }

            // calculate for poor days
            DemandDistributions[0].DayTypeDistributions[2].CummProbability = DemandDistributions[0].DayTypeDistributions[2].Probability;
            DemandDistributions[0].DayTypeDistributions[2].MinRange = 1;
            DemandDistributions[0].DayTypeDistributions[2].MaxRange = Convert.ToInt32(DemandDistributions[0].DayTypeDistributions[2].CummProbability * 100);
            for (int i = 1; i < DemandDistributions.Count; i++)
            {
                DemandDistributions[i].DayTypeDistributions[2].CummProbability = DemandDistributions[i].DayTypeDistributions[2].Probability + DemandDistributions[i - 1].DayTypeDistributions[2].CummProbability;
                DemandDistributions[i].DayTypeDistributions[2].MinRange = Convert.ToInt32(DemandDistributions[i - 1].DayTypeDistributions[2].MaxRange) + 1;
                DemandDistributions[i].DayTypeDistributions[2].MaxRange = Convert.ToInt32(DemandDistributions[i].DayTypeDistributions[2].CummProbability * 100);
            }
        }

        public Enums.DayType Get_Day_Type(List<DayTypeDistribution> t, int n)
        {
            foreach (var dayDist in t)
            {
                if (n <= dayDist.MaxRange && n >= dayDist.MinRange)
                    return dayDist.DayType;
            }
            return Enums.DayType.Good; // mlhash lazma
        }

        public int Get_Demand(List<DemandDistribution> demands, int n, string dayType)
        {
            foreach (var demand in demands)
            {
                if(dayType == "Good")
                {
                    if (n <= demand.DayTypeDistributions[0].MaxRange && n >= demand.DayTypeDistributions[0].MinRange)
                        return demand.Demand;
                }
                else if(dayType == "Fair")
                {
                    if (n <= demand.DayTypeDistributions[1].MaxRange && n >= demand.DayTypeDistributions[1].MinRange)
                        return demand.Demand;
                }
                else if (dayType == "Poor")
                {
                    if (n <= demand.DayTypeDistributions[2].MaxRange && n >= demand.DayTypeDistributions[2].MinRange)
                        return demand.Demand;
                }
            }
            return 0;
        }

        public void Initialize_Inputs()
        {
            Cost = NumOfNewspapers * PurchasePrice;
            Calc_Cummlative_for_days();
            Calc_Cummlative_for_demands();
        }

        public void Start_Process()
        {
            int c = 0;
            Random rand = new Random();
            SimulationCase row;
            while(c < NumOfRecords)
            {
                row = new SimulationCase();

                row.DayNo = c + 1;
                row.RandomNewsDayType = rand.Next(1, 101);
                row.NewsDayType = Get_Day_Type(DayTypeDistributions, row.RandomNewsDayType);
                row.RandomDemand = rand.Next(1, 101);
                row.Demand = Get_Demand(DemandDistributions, row.RandomDemand, row.NewsDayType.ToString());
                row.DailyCost = Cost;
                row.SalesProfit = row.Demand * SellingPrice;
                if (row.Demand > NumOfNewspapers)
                {
                    row.SalesProfit = NumOfNewspapers * SellingPrice;
                    row.LostProfit = (row.Demand - NumOfNewspapers) * (SellingPrice - PurchasePrice);
                    PerformanceMeasures.DaysWithMoreDemand++;
                }
                if (row.Demand < NumOfNewspapers)
                {
                    row.ScrapProfit = (NumOfNewspapers - row.Demand) * ScrapPrice;
                    PerformanceMeasures.DaysWithUnsoldPapers++;
                }                  
                row.DailyNetProfit = row.SalesProfit - row.DailyCost - row.LostProfit + row.ScrapProfit;

                // rest of performance calculations
                PerformanceMeasures.TotalCost += row.DailyCost;
                PerformanceMeasures.TotalSalesProfit += row.SalesProfit;
                PerformanceMeasures.TotalScrapProfit += row.ScrapProfit;
                PerformanceMeasures.TotalLostProfit += row.LostProfit;
                PerformanceMeasures.TotalNetProfit += row.DailyNetProfit;

                SimulationTable.Add(row);
                c++;
            }
        }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
    }
}
