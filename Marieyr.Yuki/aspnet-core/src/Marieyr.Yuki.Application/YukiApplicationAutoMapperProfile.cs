using AutoMapper;
using Marieyr.Yuki.Dtos;
using Marieyr.Yuki.Entities;

namespace Marieyr.Yuki
{
    public class YukiApplicationAutoMapperProfile : Profile
    {
        public YukiApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Article, ArticleDto>();
            CreateMap<CreateUpdateArticleDto, Article>();
        }
    }
}
