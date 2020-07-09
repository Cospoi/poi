using Cospoi.Gopick.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Cospoi.Gopick.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(GopickEntityFrameworkCoreDbMigrationsModule),
        typeof(GopickApplicationContractsModule)
        )]
    public class GopickDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
