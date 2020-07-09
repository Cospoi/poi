using Volo.Abp.Modularity;

namespace Poi.Master
{
    [DependsOn(
        typeof(MasterApplicationModule),
        typeof(MasterDomainTestModule)
        )]
    public class MasterApplicationTestModule : AbpModule
    {

    }
}