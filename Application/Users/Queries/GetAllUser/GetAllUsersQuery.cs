using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetAllUser;

public sealed record GetAllUsersQuery() : IQuery<List<User>>;