using Marieyr.Yuki.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Marieyr.Yuki
{
    [DependsOn(
        typeof(YukiEntityFrameworkCoreTestModule)
        )]
    public class YukiDomainTestModule : AbpModule
    {

    }
}