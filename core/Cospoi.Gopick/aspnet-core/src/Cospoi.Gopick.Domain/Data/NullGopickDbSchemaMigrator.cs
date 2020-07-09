using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cospoi.Gopick.Data
{
    /* This is used if database provider does't define
     * IGopickDbSchemaMigrator implementation.
     */
    public class NullGopickDbSchemaMigrator : IGopickDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}