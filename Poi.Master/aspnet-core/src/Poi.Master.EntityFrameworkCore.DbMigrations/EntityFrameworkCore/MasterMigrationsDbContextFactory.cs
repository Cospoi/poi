using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Poi.Master.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class MasterMigrationsDbContextFactory : IDesignTimeDbContextFactory<MasterMigrationsDbContext>
    {
        public MasterMigrationsDbContext CreateDbContext(string[] args)
        {
            MasterEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<MasterMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new MasterMigrationsDbContext(builder.Options);
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
