using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cospoi.Gopick.Data;
using Volo.Abp.DependencyInjection;

namespace Cospoi.Gopick.EntityFrameworkCore
{
    public class EntityFrameworkCoreGopickDbSchemaMigrator
        : IGopickDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreGopickDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the GopickMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<GopickMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}