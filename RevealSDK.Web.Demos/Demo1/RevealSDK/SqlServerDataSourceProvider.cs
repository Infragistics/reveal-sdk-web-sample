using Infragistics.Sdk;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class SqlServerDataSourceProvider : IRVDataSourceProvider
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
            var sqlServerDS = new RVSqlServerDataSource();
            sqlServerDS.Host = "0.0.0.0"; // Provide host
            sqlServerDS.Database = "Database"; // Provide database
            
            var sqlServerDsi = new RVSqlServerDataSourceItem(sqlServerDS);
            sqlServerDsi.Database = "Database"; // Provide database
            sqlServerDsi.Table = "Marketing"; // Provide table

            return sqlServerDsi;
        }
    }
}
