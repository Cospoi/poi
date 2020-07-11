using Marieyr.Yuki.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Marieyr.Yuki.Interfaces
{
    public interface IArticleAppService :
        ICrudAppService<
            ArticleDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateArticleDto,
            CreateUpdateArticleDto>
    {
    }
}
