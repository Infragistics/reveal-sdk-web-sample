using Infragistics.Sdk;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class RevealSdkContext : IRevealSdkContext
    {
        // Use these providers when changing data source with SQL Server:
        // public IRVDataSourceProvider DataSourceProvider => new SqlServerDataSourceProvider();
        // public IRVDataProvider DataProvider => null;
        // public IRVAuthenticationProvider AuthenticationProvider => new SqlServerAuthenticationProvider();

        public IRVDataSourceProvider DataSourceProvider => new InMemoryDataSourceProvider();

        public IRVDataProvider DataProvider => new InMemoryDataProvider();

        public IRVAuthenticationProvider AuthenticationProvider => null;

        public Task<Stream> GetDashboardAsync(string dashboardId)
        {
            var resourceName = $"Demo1.Dashboards.{dashboardId}";
            var assembly = Assembly.GetExecutingAssembly();
            return Task.FromResult(assembly.GetManifestResourceStream(resourceName));
        }

        public Task SaveDashboardAsync(string userId, string dashboardId, Stream dashboardStream)
        {
            throw new NotImplementedException();
        }
    }
}
