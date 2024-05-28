using BCAT.Application.Books.GetBooks;
using BCAT.Domain.Books;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.GetBookById
{
    
      public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookResponse?>
    {
        private readonly IBookRepository _BookRepository;

        public GetBookByIdQueryHandler(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }
        public async Task<BookResponse?> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var Book = await _BookRepository.GetBookByIdAsync(request.Id);
            if(Book == null)
            {
                return null;
            }
            
            return Book.Adapt<BookResponse>();
        }
    }
}
