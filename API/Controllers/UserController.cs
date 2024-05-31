using Application.Users.Commands.CreateUser;
using Application.Users.Queries.GetAllUser;
using Application.Users.Queries.GetUserByEmail;
using Application.Users.Queries.GetUserById;
using Contracts.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            return Ok(await _mediator.Send(new CreateUserCommand(request.FirstName, request.LastName, request.Email, request.Password)));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllUsersQuery()));
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetById(Guid userId)
        {
            return Ok(await _mediator.Send(new GetUserByIdQuery(userId)));
        }

        [HttpGet("Email")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            return Ok(await _mediator.Send(new GetUserByEmailQuery(email)));
        }
    }
}
