using BCAT.Domain.Books;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.GetBooks
{
    public class GetBooksQuery : IRequest<List<BookResponse>>
    {
    }
}
