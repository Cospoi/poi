using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Marieyr.Yuki.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(YukiHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class YukiConsoleApiClientModule : AbpModule
    {
        
    }
}
