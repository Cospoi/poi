using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Poi.Master.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MasterHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MasterConsoleApiClientModule : AbpModule
    {
        
    }
}
