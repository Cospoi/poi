using Marieyr.Yuki.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Marieyr.Yuki.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(YukiEntityFrameworkCoreDbMigrationsModule),
        typeof(YukiApplicationContractsModule)
        )]
    public class YukiDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
