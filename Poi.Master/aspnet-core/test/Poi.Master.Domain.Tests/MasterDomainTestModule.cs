using Poi.Master.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Poi.Master
{
    [DependsOn(
        typeof(MasterEntityFrameworkCoreTestModule)
        )]
    public class MasterDomainTestModule : AbpModule
    {

    }
}