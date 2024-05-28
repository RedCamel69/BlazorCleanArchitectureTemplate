using BCAT.Domain.Books;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.CreateBook
{
    public class CreateBookCommand : IRequest<BookResponse>
    {
        //public BookResponse? Book { get; set; }
        public int Id { get; set; }
        public required string Title { get; set; } 
        public string? Content { get; set; }
        public DateTime DatePublished { get; set; } 
        public bool IsPublished { get; set; } 
    }
}
