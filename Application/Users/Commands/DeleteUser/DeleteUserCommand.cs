using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.DeleteUser;

public sealed record DeleteUserCommand(Guid UserId) : ICommand<bool>;