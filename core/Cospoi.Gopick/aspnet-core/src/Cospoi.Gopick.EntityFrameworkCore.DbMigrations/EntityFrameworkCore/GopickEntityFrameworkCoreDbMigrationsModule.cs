using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Cospoi.Gopick.EntityFrameworkCore
{
    [DependsOn(
        typeof(GopickEntityFrameworkCoreModule)
        )]
    public class GopickEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<GopickMigrationsDbContext>();
        }
    }
}
