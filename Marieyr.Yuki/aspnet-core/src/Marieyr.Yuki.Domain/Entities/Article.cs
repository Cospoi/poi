using Marieyr.Yuki.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Marieyr.Yuki.Entities
{
    /// <summary>
    /// 文章表
    /// </summary>
    public class Article : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Summer { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public ArticleType Type { get; set; }
        /// <summary>
        /// 查看次数
        /// </summary>
        public int ViewCount { get; set; }
        /// <summary>
        /// 文章字数
        /// </summary>
        public int FontCount { get; set; }

        protected Article()
        {
        }
        public Article(Guid id, string title, DateTime publishDate, ArticleType type) : base(id)
        {
            Title = title;
            CreationTime = publishDate;
            Type = type;
        }
    }
}
