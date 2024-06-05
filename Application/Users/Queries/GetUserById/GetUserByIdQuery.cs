using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetUserById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<User>;