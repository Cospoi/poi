using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Poi.Master.Data;
using Volo.Abp.DependencyInjection;

namespace Poi.Master.EntityFrameworkCore
{
    public class EntityFrameworkCoreMasterDbSchemaMigrator
        : IMasterDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMasterDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MasterMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MasterMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}