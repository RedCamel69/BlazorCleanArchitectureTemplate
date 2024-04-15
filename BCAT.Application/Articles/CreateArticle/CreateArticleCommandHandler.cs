using BCAT.Domain.Articles;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Articles.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand, ArticleResponse> 
    {
        private readonly IArticleRepository _articleRepository;

        public CreateArticleCommandHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
       
        public async Task<ArticleResponse> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            //var newArticle = new Article
            //{
            //    Title = request.Article!.Title,
            //    Content = request.Article.Content,
            //    DateCreated = DateTime.Now,
            //    DatePublished = DateTime.Now
            //};

            var newArticle = request.Adapt<Article>();

            var article = await _articleRepository.CreateArticleAsync(newArticle);
            return article.Adapt<ArticleResponse>();
        }
    }
}
