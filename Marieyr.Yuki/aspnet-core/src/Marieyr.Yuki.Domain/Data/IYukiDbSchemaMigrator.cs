using System.Threading.Tasks;

namespace Marieyr.Yuki.Data
{
    public interface IYukiDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
