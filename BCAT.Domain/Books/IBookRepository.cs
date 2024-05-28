using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Domain.Books
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooksAsync();

        Task<Book?> GetBookByIdAsync(int Id);

        Task<Book> CreateBookAsync(Book Book);

        Task<Book?> UpdateBookAsync(Book Book);

        Task<bool> DeleteBookAsync(int id);
    }
}
