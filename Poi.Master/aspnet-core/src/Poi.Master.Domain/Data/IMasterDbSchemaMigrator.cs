using System.Threading.Tasks;

namespace Poi.Master.Data
{
    public interface IMasterDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
