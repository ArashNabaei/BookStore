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
            await _unitOfWork.SaveChangesAsync();
            
        }

        public async Task DeleteAuthorAsync(int id)
        {
            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.AuthorRepository.DeleteAuthorAsync(id);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }
        }

        public async Task UpdateAuthorAsync(int id, AuthorDTO authorDTO)
        {
            var author = new Author
            {
                Id = authorDTO.Id,
                Username = authorDTO.Username,
                Password = authorDTO.Password
            };

            try
            {
                await _unitOfWork.BeginTransactionAsync();
                await _unitOfWork.AuthorRepository.UpdateAuthorAsync(id, author);
                await _unitOfWork.SaveChangesAsync();
                await _unitOfWork.CommitTransactionAsync();
            }
            catch
            {
                await _unitOfWork.RollbackTransactionAsync();
            }
        }
    }

}
