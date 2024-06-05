using Application.Core.Abstructions.Data;
using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Commands.UpdateEmail;

internal sealed class UpdateUserEmailCommandHandler : ICommandHandler<UpdateUserEmailCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateUserEmailCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(UpdateUserEmailCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _userRepository.GetById(request.UserId) ?? throw new NullReferenceException();

            user.ChangeEmail(request.Email);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}