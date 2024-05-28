using BCAT.Domain.Books;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.GetBooks
{
    public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, List<BookResponse>>
    {
        private readonly IBookRepository _BookRepository;

        public GetBooksQueryHandler(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }
        public async Task<List<BookResponse>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
        {
            var Books = await _BookRepository.GetAllBooksAsync();
            return Books.Adapt<List<BookResponse>>();
        }
    }
}
