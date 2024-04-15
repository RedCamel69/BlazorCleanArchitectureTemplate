using BCAT.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Articles
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {

            _articleRepository = articleRepository;

        }

        public async Task<List<Article>> GetAllArticles()
        {
            return await _articleRepository.GetAllArticlesAsync();
            //return new List<Article>
            //{
            //    new Article()
            //    {
            //        Id = 1,
            //        Title = "First Test",
            //        Content = "This is the first Test Article"
            //    },
            //    new Article()
            //    {
            //        Id = 2,
            //        Title = "Second Test",
            //        Content = "This is the second Test Article"
            //    }
            //};
        }
    }
}
