using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetAllUser;

internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, List<User>>
{
    private readonly IUserRepository _userRepository;
    
    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            List<User> users = await _userRepository.GetAll() ?? throw new NullReferenceException();

            return users;
        }
        catch (NullReferenceException)
        {
            return new List<User>();
        }
    }
}