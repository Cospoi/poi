﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Marieyr.Yuki.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class YukiMigrationsDbContextFactory : IDesignTimeDbContextFactory<YukiMigrationsDbContext>
    {
        public YukiMigrationsDbContext CreateDbContext(string[] args)
        {
            YukiEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<YukiMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new YukiMigrationsDbContext(builder.Options);
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
