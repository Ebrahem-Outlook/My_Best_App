using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.UpdateName;

public sealed record UpdateUserNameCommand(Guid UserId, string FirstName, string LastName) : ICommand<bool>;