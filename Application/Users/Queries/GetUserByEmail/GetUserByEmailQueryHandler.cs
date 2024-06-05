using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetUserByEmail;

internal sealed class GetUserByEmailQueryHandler : IQueryHandler<GetUserByEmailQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userRepository.GetByEmail(request.Email) ?? throw new NullReferenceException();

            return user;
        }
        catch(NullReferenceException)
        {
            return new User();
        }
    }
}