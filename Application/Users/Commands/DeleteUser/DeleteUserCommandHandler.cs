using Application.Core.Abstructions.Data;
using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Commands.DeleteUser
{
    internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetById(request.UserId) ?? throw new NullReferenceException();

            _userRepository.Delete(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
