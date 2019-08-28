using Demo1.Models;
using Infragistics.Sdk;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class InMemoryDataProvider : IRVDataProvider
    {
        public Task<IRVInMemoryData> GetData(string userId, RVInMemoryDataSourceItem dataSourceItem)
        {
            var datasetId = dataSourceItem.DatasetId;
            if (datasetId == "Marketing")
            {
                var data = new List<MarketingInfo>()
                {
                    new MarketingInfo(new DateTime(2019,  1, 1), 714.60, 316.44, 0.12, 6.26, 3157.98, 6080.00, 1796.20, 1409.44, 180.71, "Americas", "Topaz", 125, 0.65, 0.19),
                    new MarketingInfo(new DateTime(2019,  1, 5), 574.22, 510.04, 0.59, 10.21, 1301.39, 7527.00, 1748.08, 1355.64, 240.76, "Japan", "Paradot", 421, 0.71, 0.16),
                    new MarketingInfo(new DateTime(2019,  1, 19), 683.64, 239.15, 0.28, 13.40, 1632.19, 11395.00, 1821.19, 1154.92, 318.74, "EMEA", "Sapphire", 510, 0.79, 0.13),
                    new MarketingInfo(new DateTime(2019,  1, 8), 193.14, 610.29, 0.19, 17.81, 891.16, 16134.00, 1293.81, 1059.82, 249.25, "India", "Paradot", 322, 0.87, 0.07),
                    new MarketingInfo(new DateTime(2019,  1, 14), 245.85, 265.81, 0.49, 3.74, 2534.60, 12107.00, 950.05, 1101.96, 453.98, "India", "Aquamarine", 175, 0.86, 0.07),
                    new MarketingInfo(new DateTime(2019,  1, 22), 541.01, 244.69, 0.23, 9.88, 2926.82, 18254.00, 901.55, 1089.60, 430.01, "EMEA", "Diamond", 220, 0.9, 0.04),
                    new MarketingInfo(new DateTime(2019,  2, 24), 742.28, 632.00, 0.48, 5.17, 802.40, 18337.00, 1260.84, 1122.47, 393.61, "Americas", "Aquamarine", 364, 0.88, 0.06),
                    new MarketingInfo(new DateTime(2019,  2, 28), 304.11, 581.95, 0.36, 9.13, 3738.46, 5490.00, 1964.76, 1081.17, 198.80, "Japan", "Paradot", 406, 0.64, 0.23),
                    new MarketingInfo(new DateTime(2019,  2, 14), 521.76, 644.17, 0.36, 7.60, 1577.75, 2205.00, 1562.82, 1274.22, 353.55, "Japan", "Paradot", 453, 0.44, 0.31),
                    new MarketingInfo(new DateTime(2019,  2, 2), 641.53, 185.98, 0.52, 7.47, 829.74, 2390.00, 1412.68, 963.95, 396.40, "EMEA", "Ruby", 387, 0.5, 0.3),
                    new MarketingInfo(new DateTime(2019,  2, 4), 317.28, 626.36, 0.43, 14.63, 2215.42, 7231.00, 1521.36, 1253.34, 440.28, "EMEA", "Paradot", 173, 0.72, 0.15),
                    new MarketingInfo(new DateTime(2019,  2, 20), 281.99, 664.01, 0.59, 15.12, 2317.75, 19228.00, 1831.72, 1082.90, 188.95, "Japan", "Aquamarine", 288, 0.87, 0.08),
                    new MarketingInfo(new DateTime(2019,  3, 24), 478.96, 229.02, 0.59, 2.03, 2651.86, 12628.00, 1897.20, 964.92, 460.75, "APAC", "Paradot", 158, 0.82, 0.12),
                    new MarketingInfo(new DateTime(2019,  3, 22), 432.48, 176.66, 0.58, 10.60, 2806.68, 12687.00, 1553.08, 1102.86, 206.73, "Japan", "Topaz", 380, 0.83, 0.1),
                    new MarketingInfo(new DateTime(2019,  3, 6), 467.20, 367.03, 0.47, 3.78, 2929.75, 4474.00, 1499.85, 1007.76, 246.24, "India", "Sapphire", 262, 0.64, 0.21),
                    new MarketingInfo(new DateTime(2019,  3, 4), 160.29, 409.02, 0.26, 12.48, 2851.68, 12177.00, 1395.06, 1327.04, 200.52, "India", "Ruby", 449, 0.82, 0.09),
                    new MarketingInfo(new DateTime(2019,  3, 27), 637.16, 239.13, 0.35, 13.31, 3550.41, 2680.00, 1721.95, 1023.73, 242.07, "APAC", "Ruby", 206, 0.49, 0.32),
                    new MarketingInfo(new DateTime(2019,  3, 2), 170.79, 265.84, 0.28, 10.97, 1157.39, 5577.00, 1173.30, 1405.94, 335.18, "Japan", "Paradot", 416, 0.68, 0.14)

                };

                return Task.FromResult<IRVInMemoryData>(new RVInMemoryData<MarketingInfo>(data));
            }
            else
            {
                throw new Exception("Invalid data requested");
            }
        }
    }
}
