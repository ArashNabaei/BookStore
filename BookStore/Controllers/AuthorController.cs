using Application.Repositories.Command.Authors.Create;
using Application.Repositories.Command.Authors.Delete;
using Application.Repositories.Command.Authors.Update;
using Application.Repositories.Query.Authors;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly ISender _mediator;

        public AuthorController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllAuthors")]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _mediator.Send(new GetAllAuthorsQuery());

            return Ok(authors);
        }

        [HttpGet("GetAuthor/{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var query = new GetAuthorByIdQuery(id);

            var author = await _mediator.Send(query);

            return Ok(author);

        }

        [HttpPost("CreateAuthor")]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("DeleteAuthor/{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var deleteCommand = new DeleteAuthorCommand(id);
            await _mediator.Send(deleteCommand);
            
            return Ok();
        }

        [HttpPut("UpdateAuthor/{id}")]
        public async Task<IActionResult> UpdateAuthor(int id, UpdateAuthorCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await _mediator.Send(command);

            return Ok();
        }

        [HttpGet("getBooksOfAuthor/{authorId}")]
        public async Task<IActionResult> GetBooksOfAuthorById(int authorId)
        {
            var query = new GetBooksOfAuthorByIdQuery { Id = authorId };
            var result = await _mediator.Send(query);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }

    }
}
