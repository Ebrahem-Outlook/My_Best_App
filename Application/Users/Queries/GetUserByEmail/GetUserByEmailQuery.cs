using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetUserByEmail
{
    public record GetUserByEmailQuery(string Email) : IQuery<User>;
}
