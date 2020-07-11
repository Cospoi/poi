using Volo.Abp.Modularity;

namespace Marieyr.Yuki
{
    [DependsOn(
        typeof(YukiApplicationModule),
        typeof(YukiDomainTestModule)
        )]
    public class YukiApplicationTestModule : AbpModule
    {

    }
}