using Application.Core.Abstructions.Data;
using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Commands.UpdatePassword;

internal sealed class UpdateUserPasswordCommandHandler : ICommandHandler<UpdateUserPasswordCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateUserPasswordCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(UpdateUserPasswordCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _userRepository.GetById(request.UserId) ?? throw new NullReferenceException();

            user.ChangePassword(request.Password);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch(Exception)
        {
            return false;
        }
    }
}