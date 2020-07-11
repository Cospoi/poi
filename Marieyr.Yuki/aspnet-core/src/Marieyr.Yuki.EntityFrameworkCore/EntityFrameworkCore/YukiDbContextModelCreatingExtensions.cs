using Marieyr.Yuki.Entities;
using Marieyr.Yuki.Enum;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;

namespace Marieyr.Yuki.EntityFrameworkCore
{
    public static class YukiDbContextModelCreatingExtensions
    {
        public static void ConfigureYuki(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(YukiConsts.DbTablePrefix + "YourEntities", YukiConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Article>(b =>
            {
                b.ConfigureByConvention();
                b.ToTable("Articles");
                b.Property(p => p.Title).HasMaxLength(128).IsRequired(true);
                b.Property(p => p.Summer).HasMaxLength(1024);
                b.Property(p => p.ViewCount).HasDefaultValue(0);
                b.Property(p => p.FontCount).HasDefaultValue(0);
                b.Property(p => p.Type).HasDefaultValue(ArticleType.Undefined);
            });
        }
    }
}