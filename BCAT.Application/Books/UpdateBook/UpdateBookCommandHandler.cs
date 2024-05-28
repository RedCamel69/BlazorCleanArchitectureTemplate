using BCAT.Domain.Books;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.UpdateBook
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, BookResponse?> 
    {
        private readonly IBookRepository _BookRepository;

    public UpdateBookCommandHandler(IBookRepository BookRepository)
    {
        _BookRepository = BookRepository;
    }

        public async Task<BookResponse?> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var updateBook = request.Adapt<Book>();
            var Book = await _BookRepository.UpdateBookAsync(updateBook);
            if(Book == null)
            {
                return null;
            }
            return Book.Adapt<BookResponse>();
        }
    }
}
