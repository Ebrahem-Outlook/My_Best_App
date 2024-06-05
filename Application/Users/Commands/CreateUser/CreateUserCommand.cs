using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(string FirstName, string LastName, string Email, string Password) : ICommand<bool>; 