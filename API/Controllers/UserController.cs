using Application.Users.Commands.CreateUser;
using Application.Users.Commands.DeleteUser;
using Application.Users.Commands.UpdateEmail;
using Application.Users.Commands.UpdateName;
using Application.Users.Commands.UpdatePassword;
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

        // Insert

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserRequest request)
        {
            return Ok(await _mediator.Send(new CreateUserCommand(request.FirstName, request.LastName, request.Email, request.Password)));
        }

        // Get

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

        // Update

        [HttpPut("Name")]
        public async Task<IActionResult> Update(ChangeUserNameRequest request)
        {
            return Ok(await _mediator.Send(new UpdateUserNameCommand(request.UserId, request.FirstName, request.LastName)));
        }

        [HttpPut("Email")]
        public async Task<IActionResult> Update(ChangeUserEmailRequest request)
        {
            return Ok(await _mediator.Send(new UpdateUserEmailCommand(request.UserId, request.Email)));
        }

        [HttpPut("Password")]
        public async Task<IActionResult> Update(ChangeUserPasswordRequest request)
        {
            return Ok(await _mediator.Send(new UpdateUserPasswordCommand(request.UserId, request.Password)));
        }

        // Delete
        [HttpDelete("Id")]
        public async Task<IActionResult> Remove(DeleteUserRequest request)
        {
            return Ok(await _mediator.Send(new DeleteUserCommand(request.UserId)));
        }
    }
}