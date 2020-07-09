using Cospoi.Gopick.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cospoi.Gopick
{
    [DependsOn(
        typeof(GopickEntityFrameworkCoreTestModule)
        )]
    public class GopickDomainTestModule : AbpModule
    {

    }
}