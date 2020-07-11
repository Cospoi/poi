using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Marieyr.Yuki.Data;
using Volo.Abp.DependencyInjection;

namespace Marieyr.Yuki.EntityFrameworkCore
{
    public class EntityFrameworkCoreYukiDbSchemaMigrator
        : IYukiDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreYukiDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the YukiMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<YukiMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}