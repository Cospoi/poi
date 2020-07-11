using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Marieyr.Yuki.Data
{
    /* This is used if database provider does't define
     * IYukiDbSchemaMigrator implementation.
     */
    public class NullYukiDbSchemaMigrator : IYukiDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}