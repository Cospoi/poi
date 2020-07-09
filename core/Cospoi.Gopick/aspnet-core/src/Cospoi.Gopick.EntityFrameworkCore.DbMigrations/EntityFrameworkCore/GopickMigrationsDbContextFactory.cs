using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cospoi.Gopick.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class GopickMigrationsDbContextFactory : IDesignTimeDbContextFactory<GopickMigrationsDbContext>
    {
        public GopickMigrationsDbContext CreateDbContext(string[] args)
        {
            GopickEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<GopickMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new GopickMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
