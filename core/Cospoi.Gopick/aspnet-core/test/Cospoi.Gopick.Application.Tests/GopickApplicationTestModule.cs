using Volo.Abp.Modularity;

namespace Cospoi.Gopick
{
    [DependsOn(
        typeof(GopickApplicationModule),
        typeof(GopickDomainTestModule)
        )]
    public class GopickApplicationTestModule : AbpModule
    {

    }
}