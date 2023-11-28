using Application.DTOs;
using Application.Services.Read.Authors;
using MediatR;

namespace Application.Repositories.Query.Authors
{
    public class GetAuthorsQueryHandler : IRequestHandler<GetAllAuthorsQuery, IEnumerable<AuthorDTO>>
    {

        private readonly IReadAuthorService _readAuthorService;

        public GetAuthorsQueryHandler(IReadAuthorService readAuthorService)
        {
            _readAuthorService = readAuthorService;
        }

        public async Task<IEnumerable<AuthorDTO>> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var result = await _readAuthorService.GetAllAuthorsAsync();

            return result.ToList();
        }
    }
}
