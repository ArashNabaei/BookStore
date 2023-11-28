using Application.DTOs;
using Application.Services.Read.Authors;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories.Query.Authors
{
    public class GetBooksOfAuthorByIdQueryHandler : IRequestHandler<GetBooksOfAuthorByIdQuery, IEnumerable<BookDTO>>
    {

        private readonly IReadAuthorService _readAuthorService;

        public GetBooksOfAuthorByIdQueryHandler(IReadAuthorService readAuthorService)
        {
            _readAuthorService = readAuthorService;
        }

        public async Task<IEnumerable<BookDTO>> Handle(GetBooksOfAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _readAuthorService.GetBooksOfAuhorByIdAsync(request.Id);

            return result.ToList();
        }


    }
}
