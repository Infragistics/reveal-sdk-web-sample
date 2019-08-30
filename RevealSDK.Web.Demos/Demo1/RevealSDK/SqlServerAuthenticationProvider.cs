using Infragistics.Sdk;
using System.Threading.Tasks;

namespace Demo1.RevealSDK
{
    public class SqlServerAuthenticationProvider : IRVAuthenticationProvider
    {
        public Task<IRVDataSourceCredential> ResolveCredentialsAsync(string userId, RVDashboardDataSource dataSource)
        {
            RVUsernamePasswordDataSourceCredential userCredential = null;
            if (dataSource is RVSqlServerDataSource)
            {
                userCredential = new RVUsernamePasswordDataSourceCredential("username", "password", "domain"); // Provide credentials
            }

            return Task.FromResult<IRVDataSourceCredential>(userCredential);
        }
    }
}
