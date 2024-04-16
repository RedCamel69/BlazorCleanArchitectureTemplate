using BCAT.Domain.Articles;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Articles.CreateArticle
{
    public class CreateArticleCommand : IRequest<ArticleResponse>
    {
        //public ArticleResponse? Article { get; set; }
        public int Id { get; set; }
        public required string Title { get; set; } 
        public string? Content { get; set; }
        public DateTime DatePublished { get; set; } 
        public bool IsPublished { get; set; } 
    }
}
