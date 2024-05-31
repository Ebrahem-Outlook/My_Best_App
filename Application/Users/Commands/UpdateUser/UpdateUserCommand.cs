using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.UpdateUser
{
    public record UpdateUserCommand(Guid UserId, string FirstName, string LastName) : ICommand<bool>;
}
