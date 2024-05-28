using BCAT.Domain.Books;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BookResponse> 
    {
        private readonly IBookRepository _BookRepository;

        public CreateBookCommandHandler(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }
       
        public async Task<BookResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            //var newBook = new Book
            //{
            //    Title = request.Book!.Title,
            //    Content = request.Book.Content,
            //    DateCreated = DateTime.Now,
            //    DatePublished = DateTime.Now
            //};

            var newBook = request.Adapt<Book>();

            var Book = await _BookRepository.CreateBookAsync(newBook);
            return Book.Adapt<BookResponse>();
        }
    }
}
