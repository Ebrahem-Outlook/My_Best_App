using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.UpdateEmail;

public sealed record UpdateUserEmailCommand(Guid UserId, string Email) : ICommand<bool>;