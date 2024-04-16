using BCAT.Domain.Articles;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Articles.UpdateArticle
{
    public class UpdateArticleCommandHandler : IRequestHandler<UpdateArticleCommand, ArticleResponse?> 
    {
        private readonly IArticleRepository _articleRepository;

    public UpdateArticleCommandHandler(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

        public async Task<ArticleResponse?> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            var updateArticle = request.Adapt<Article>();
            var article = await _articleRepository.UpdateArticleAsync(updateArticle);
            if(article == null)
            {
                return null;
            }
            return article.Adapt<ArticleResponse>();
        }
    }
}
