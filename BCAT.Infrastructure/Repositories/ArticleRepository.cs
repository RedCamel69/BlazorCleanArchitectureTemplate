using BCAT.Domain.Articles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Infrastructure.Repositories
{
    internal class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Article> CreateArticleAsync(Article article)
        {
            _context.Articles.Add(article);
            await _context.SaveChangesAsync();
            return article;
        }

        public async Task<bool> DeleteArticleAsync(int id)
        {
            var articleToDelete = await GetArticleByIdAsync(id);
            if (articleToDelete == null)
            {
                return false;
            }

            _context.Articles.Remove(articleToDelete);
            await _context.SaveChangesAsync();
            return true;


        }

        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await _context.Articles.ToListAsync();
        }

        public async Task<Article?> GetArticleByIdAsync(int Id)
        {
           var article = await _context.Articles.FindAsync(Id);
            if (article == null)
            {

            }
            return article!;

        }

        public async Task<Article?> UpdateArticleAsync(Article article)
        {
           var articleToUpdate = await GetArticleByIdAsync(article.Id);
            if(articleToUpdate == null)
            {
                return null;
            }

            articleToUpdate.Title = article.Title;
            articleToUpdate.Content=article.Content;
            articleToUpdate.DatePublished=article.DatePublished;
            articleToUpdate.IsPublished = article.IsPublished;

            _context.Articles.Update(articleToUpdate);
            await _context.SaveChangesAsync();

            return articleToUpdate;
        }
    }
}
