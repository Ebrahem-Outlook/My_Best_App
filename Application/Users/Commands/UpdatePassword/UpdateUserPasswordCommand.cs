using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.UpdatePassword;

public sealed record UpdateUserPasswordCommand(Guid UserId, string Password) : ICommand<bool>;