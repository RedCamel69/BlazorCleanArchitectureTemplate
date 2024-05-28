using BCAT.Application.Books.UpdateBook;
using BCAT.Domain.Books;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCAT.Application.Books.DeleteBook
{
    public  class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, bool>
    {
        private readonly IBookRepository _BookRepository;

        public DeleteBookCommandHandler(IBookRepository BookRepository)
        {
            _BookRepository = BookRepository;
        }

        public async Task<bool> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            return await _BookRepository.DeleteBookAsync(request.Id);
        }

    }
}
