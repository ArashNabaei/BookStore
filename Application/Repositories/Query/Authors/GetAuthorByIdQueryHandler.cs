using Application.DTOs;
using Application.Services.Read.Authors;
using MediatR;

namespace Application.Repositories.Query.Authors
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, AuthorDTO>
    {

        private readonly IReadAuthorService _readauthorService;

        public GetAuthorByIdQueryHandler(IReadAuthorService readauthorService)
        {
            _readauthorService = readauthorService;
        }

        public async Task<AuthorDTO> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var author = await _readauthorService.GetAuthorByIdAsync(request.Id);

            return author;
        }
    }
}
