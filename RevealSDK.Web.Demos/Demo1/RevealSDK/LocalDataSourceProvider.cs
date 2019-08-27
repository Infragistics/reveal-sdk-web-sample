using Infragistics.Sdk;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class LocalDataSourceProvider : IRVDataSourceProvider
    {
        public Task<RVDataSourceItem> ChangeDashboardFilterDataSourceItemAsync(string userId, string dashboardId, RVDashboardFilter filter, RVDataSourceItem dataSourceItem)
        {
            return Task.FromResult<RVDataSourceItem>(ChangeDataSourceItem(dataSourceItem));
        }

        public Task<RVDataSourceItem> ChangeVisualizationDataSourceItemAsync(string userId, string dashboardId, RVVisualization visualization, RVDataSourceItem dataSourceItem)
        {
            return Task.FromResult<RVDataSourceItem>(ChangeDataSourceItem(dataSourceItem));
        }

        private RVDataSourceItem ChangeDataSourceItem(RVDataSourceItem dataSourceItem)
        {
            var excelItem = dataSourceItem as RVExcelDataSourceItem;
            var wrItem = excelItem?.ResourceItem as RVWebResourceDataSourceItem;
            if (wrItem != null && wrItem.Url.EndsWith("Samples.xlsx"))
            {
                var localItem = new RVLocalFileDataSourceItem();
                localItem.Uri = "local:/Marketing.xlsx";
                excelItem.ResourceItem = localItem;
                return excelItem;
            }
            else
            {
                return null;
            }
        }
    }
}
