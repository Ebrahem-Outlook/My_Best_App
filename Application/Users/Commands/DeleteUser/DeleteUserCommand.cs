using Application.Core.Abstructions.Messaging;

namespace Application.Users.Commands.DeleteUser
{
    public record DeleteUserCommand(Guid UserId) : ICommand<bool>;
}
