using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Queries.GetUserById
{
    internal sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                User user = await _userRepository.GetById(request.UserId) ?? throw new NullReferenceException();

                return user;
            }
            catch(NullReferenceException)
            {
                return new User();
            }
        }
    }
}
