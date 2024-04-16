using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Domain.Articles
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllArticlesAsync();

        Task<Article?> GetArticleByIdAsync(int Id);

        Task<Article> CreateArticleAsync(Article article);

        Task<Article?> UpdateArticleAsync(Article article);
    }
}
