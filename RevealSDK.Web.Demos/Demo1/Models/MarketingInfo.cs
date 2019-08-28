using Infragistics.Sdk;
using System;

namespace Demo1.Models
{
    public class MarketingInfo
    {
        [RVSchemaColumn("Date", RVSchemaColumnType.Date)]
        public DateTime? Date { get; set; }
        public double Spend { get; set; }
        public double Budget { get; set; }
        public double CTR { get; set; }
        [RVSchemaColumn("Avg. CPC")]
        public double AvgCPC { get; set; }
        public double Traffic { get; set; }
        [RVSchemaColumn("Paid Traffic")]
        public double PaidTraffic { get; set; }
        [RVSchemaColumn("Organic Traffic")]
        public double OrganicTraffic { get; set; }
        [RVSchemaColumn("Other Traffic")]
        public double OtherTraffic { get; set; }
        public double Conversions { get; set; }
        public string Territory { get; set; }
        public string CampaignID { get; set; }
        [RVSchemaColumn("New Seats")]
        public double NewSeats { get; set; }
        [RVSchemaColumn("Paid %")]
        public double PaidRatio { get; set; }
        [RVSchemaColumn("Organic %")]
        public double OrganicRatio { get; set; }

        public MarketingInfo(DateTime? date, double spend, double budget, double ctr, double avgCPC, double traffic, double paidTraffic, double organicTraffic, double otherTraffic, double conversions, string territory, string campaignID, double newSeats, double paidRatio, double organicRatio)
        {
            Date = date;
            Spend = spend;
            Budget = budget;
            CTR = ctr;
            AvgCPC = avgCPC;
            Traffic = traffic;
            PaidTraffic = paidTraffic;
            OrganicTraffic = organicTraffic;
            OtherTraffic = otherTraffic;
            Conversions = conversions;
            Territory = territory;
            CampaignID = campaignID;
            NewSeats = newSeats;
            PaidRatio = paidRatio;
            OrganicRatio = organicRatio;
        }
    }
}
