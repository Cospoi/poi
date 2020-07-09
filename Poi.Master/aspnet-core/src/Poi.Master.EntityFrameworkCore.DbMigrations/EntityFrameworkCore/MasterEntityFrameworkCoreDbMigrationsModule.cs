using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Poi.Master.EntityFrameworkCore
{
    [DependsOn(
        typeof(MasterEntityFrameworkCoreModule)
        )]
    public class MasterEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MasterMigrationsDbContext>();
        }
    }
}
