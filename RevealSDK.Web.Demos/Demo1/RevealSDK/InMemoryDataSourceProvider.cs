using Infragistics.Sdk;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class InMemoryDataSourceProvider : IRVDataSourceProvider
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
            return new RVInMemoryDataSourceItem("Marketing");
        }
    }
}
