using BCAT.Domain.Books;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Infrastructure.Repositories
{
    internal class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateBookAsync(Book Book)
        {
            _context.Books.Add(Book);
            await _context.SaveChangesAsync();
            return Book;
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var BookToDelete = await GetBookByIdAsync(id);
            if (BookToDelete == null)
            {
                return false;
            }

            _context.Books.Remove(BookToDelete);
            await _context.SaveChangesAsync();
            return true;


        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book?> GetBookByIdAsync(int Id)
        {
           var Book = await _context.Books.FindAsync(Id);
            if (Book == null)
            {

            }
            return Book!;

        }

        public async Task<Book?> UpdateBookAsync(Book Book)
        {
           var BookToUpdate = await GetBookByIdAsync(Book.Id);
            if(BookToUpdate == null)
            {
                return null;
            }

            BookToUpdate.Title = Book.Title;
            BookToUpdate.Content=Book.Content;
            BookToUpdate.DatePublished=Book.DatePublished;
            BookToUpdate.IsPublished = Book.IsPublished;

            _context.Books.Update(BookToUpdate);
            await _context.SaveChangesAsync();

            return BookToUpdate;
        }
    }
}
