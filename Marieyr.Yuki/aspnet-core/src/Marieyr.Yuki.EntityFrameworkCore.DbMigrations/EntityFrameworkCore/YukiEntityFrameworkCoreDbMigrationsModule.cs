using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Marieyr.Yuki.EntityFrameworkCore
{
    [DependsOn(
        typeof(YukiEntityFrameworkCoreModule)
        )]
    public class YukiEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<YukiMigrationsDbContext>();
        }
    }
}
