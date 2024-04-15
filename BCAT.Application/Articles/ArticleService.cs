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
        public List<Article> GetAllArticles()
        {
            return new List<Article>
            {
                new Article()
                {
                    Id = 1,
                    Title = "First Test",
                    Content = "This is the first Test Article"
                },
                new Article()
                {
                    Id = 2,
                    Title = "Second Test",
                    Content = "This is the second Test Article"
                }
            };
        }
    }
}
