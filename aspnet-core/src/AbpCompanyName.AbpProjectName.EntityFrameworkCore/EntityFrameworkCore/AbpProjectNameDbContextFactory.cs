using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpCompanyName.AbpProjectName.Configuration;
using AbpCompanyName.AbpProjectName.Web;

namespace AbpCompanyName.AbpProjectName.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpProjectNameDbContextFactory : IDesignTimeDbContextFactory<ITGroupDbContext>
    {
        public ITGroupDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ITGroupDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpProjectNameDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpProjectNameConsts.ConnectionStringName));

            return new ITGroupDbContext(builder.Options);
        }
    }
}
