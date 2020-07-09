using System.Threading.Tasks;

namespace Cospoi.Gopick.Data
{
    public interface IGopickDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
