using Infragistics.Sdk;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class RevealSdkContext : IRevealSdkContext
    {
        public IRVDataSourceProvider DataSourceProvider => throw new NotImplementedException();

        public IRVDataProvider DataProvider => throw new NotImplementedException();

        public IRVAuthenticationProvider AuthenticationProvider => throw new NotImplementedException();

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
