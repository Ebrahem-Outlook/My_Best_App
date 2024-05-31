using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetAllUser
{
    public record GetAllUsersQuery() : IQuery<List<User>>;
}
