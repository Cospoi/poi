using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Poi.Master.Data
{
    /* This is used if database provider does't define
     * IMasterDbSchemaMigrator implementation.
     */
    public class NullMasterDbSchemaMigrator : IMasterDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}