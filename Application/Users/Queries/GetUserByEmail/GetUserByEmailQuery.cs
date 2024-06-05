using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetUserByEmail;

public sealed record GetUserByEmailQuery(string Email) : IQuery<User>;