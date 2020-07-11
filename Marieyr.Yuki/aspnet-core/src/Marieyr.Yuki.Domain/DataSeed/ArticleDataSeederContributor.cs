using Marieyr.Yuki.Entities;
using Marieyr.Yuki.Enum;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace Marieyr.Yuki.DataSeed
{
    public class ArticleDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Article, Guid> _articlesRepository;
        private readonly IGuidGenerator _guidGenerator;

        public ArticleDataSeederContributor(
            IRepository<Article, Guid> articlesRepository,
            IGuidGenerator guidGenerator)
        {
            _articlesRepository = articlesRepository;
            _guidGenerator = guidGenerator;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _articlesRepository.GetCountAsync() > 0)
            {
                return;
            }
            await _articlesRepository.InsertAsync(
                new Article(
                    id: _guidGenerator.Create(),
                    title: "这是一篇文章",
                    type: ArticleType.Essay,
                    publishDate: new DateTime(1995, 06, 14)
                    )
                );
            await _articlesRepository.InsertAsync(
               new Article(
                   id: _guidGenerator.Create(),
                   title: "这是也是一篇文章",
                   type: ArticleType.Essay,
                   publishDate: new DateTime(1995, 06, 14)
                   )
               );
            await _articlesRepository.InsertAsync(
              new Article(
                  id: _guidGenerator.Create(),
                  title: "这是还是一篇文章",
                  type: ArticleType.Essay,
                  publishDate: new DateTime(1995, 06, 14)
                  )
              );
        }
    }
}
