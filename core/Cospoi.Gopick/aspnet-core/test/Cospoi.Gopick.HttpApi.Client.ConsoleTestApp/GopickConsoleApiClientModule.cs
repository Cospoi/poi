using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Cospoi.Gopick.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(GopickHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class GopickConsoleApiClientModule : AbpModule
    {
        
    }
}
