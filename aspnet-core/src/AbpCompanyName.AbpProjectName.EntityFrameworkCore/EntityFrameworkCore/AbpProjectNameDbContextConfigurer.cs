using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpCompanyName.AbpProjectName.EntityFrameworkCore
{
    public static class AbpProjectNameDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ITGroupDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ITGroupDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
