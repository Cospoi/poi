using Marieyr.Yuki.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marieyr.Yuki.Dtos
{
    public class CreateUpdateArticleDto
    {
        [Required]
        [StringLength(128)]
        public string Title { get; set; }
        [Required]
        [StringLength(1024)]
        public string Summer { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public ArticleType Type { get; set; } = ArticleType.Undefined;

    }
}
