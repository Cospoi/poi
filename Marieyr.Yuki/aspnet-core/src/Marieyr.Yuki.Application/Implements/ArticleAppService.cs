using Marieyr.Yuki.Dtos;
using Marieyr.Yuki.Entities;
using Marieyr.Yuki.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Marieyr.Yuki.Implements
{
    public class ArticleAppService : 
        CrudAppService<
        Article,
        ArticleDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateArticleDto,
        CreateUpdateArticleDto>,
        IArticleAppService
    {
        public ArticleAppService(IRepository<Article, Guid> repository)
            : base(repository)
        {

        }
    }
}
