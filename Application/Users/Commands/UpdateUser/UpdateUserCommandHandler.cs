using Application.Core.Abstructions.Data;
using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Commands.UpdateUser
{
    internal sealed class UpdateUserCommandHandler : ICommandHandler<UpdateUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetById(request.UserId) ?? throw new NullReferenceException();

            user.ChangeName(request.FirstName, request.LastName);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
