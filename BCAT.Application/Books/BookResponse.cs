using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books
{
    //general Book DTO
    public record struct BookResponse
    {
        public int Id;
        public string Title;
        public string? Content;
        public DateTime DatePublished;
        bool IsPublished;
    }
}
