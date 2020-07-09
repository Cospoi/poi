using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Poi.Master.EntityFrameworkCore
{
    public static class MasterDbContextModelCreatingExtensions
    {
        public static void ConfigureMaster(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MasterConsts.DbTablePrefix + "YourEntities", MasterConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}