using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.GetBookById
{
    public class GetBookByIdQuery : IRequest<BookResponse?>
    {
        public int Id { get; set; }
    }
}
