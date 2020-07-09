using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Cospoi.Gopick.EntityFrameworkCore
{
    public static class GopickDbContextModelCreatingExtensions
    {
        public static void ConfigureGopick(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(GopickConsts.DbTablePrefix + "YourEntities", GopickConsts.DbSchema);

            //    //...
            //});
        }
    }
}