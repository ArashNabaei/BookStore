using Application.Repositories.Command.Publishers.Create;
using Application.Repositories.Command.Publishers.Delete;
using Application.Repositories.Command.Publishers.Update;
using Application.Repositories.Query.Publishers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {

        private readonly ISender _mediator;

        public PublisherController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllPublishers")]
        public async Task<IActionResult> GetAllPublishers()
        {
            var publishers = await _mediator.Send(new GetAllPublishersQuery());

            return Ok(publishers);
        }

        [HttpGet("GetPublisher/{id}")]
        public async Task<IActionResult> GetPublisherById(int id)
        {
            var query = new GetPublisherByIdQuery(id);

            var publisher = await _mediator.Send(query);

            return Ok(publisher);

        }

        [HttpPost("CreatePublisher")]
        public async Task<IActionResult> CreatePublisher(CreatePublisherCommand command)
        {
            await _mediator.Send(command);

            return Ok();
        }

        [HttpDelete("DeletePublisher/{id}")]
        public async Task<IActionResult> DeletePublisher(int id)
        {
            var deleteCommand = new DeletePublisherCommand(id);
            await _mediator.Send(deleteCommand);
            
            return Ok();
        }

        [HttpPut("UpdatePublisher{id}")]
        public async Task<IActionResult> UpdatePublisher(int id, UpdatePublisherCommand command)
        {
            if (id != command.Id)
                return BadRequest();

            await _mediator.Send(command);

            return Ok();
        }

    }
}
