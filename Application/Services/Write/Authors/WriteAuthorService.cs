using Application.DTOs;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services.Write.Authors
{
    public class WriteAuthorService : IWriteAuthorService
    {

        private readonly IUnitOfWork _unitOfWork;

        public WriteAuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAuthorAsync(AuthorDTO authorDTO)
        {
            var author = new Author
            {
                Id = authorDTO.Id,
                Username = authorDTO.Username,
                Password = authorDTO.Password
            };

            await _unitOfWork.AuthorRepository.CreateAuthorAsync(author);
            await _unitOfWork.Save();
            
        }

        public async Task DeleteAuthorAsync(int id)
        {
            await _unitOfWork.AuthorRepository.DeleteAuthorAsync(id);
            await _unitOfWork.Save();
        }

    }

}
