using Marieyr.Yuki.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Marieyr.Yuki.Dtos
{
    public class ArticleDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string Summer { get; set; }

        public string Content { get; set; }

        public ArticleType Type { get; set; }

        public int ViewCount { get; set; }

        public int FontCount { get; set; }
    }
}
