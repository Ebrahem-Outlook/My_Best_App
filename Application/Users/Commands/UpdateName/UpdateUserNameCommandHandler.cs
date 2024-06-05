using Application.Core.Abstructions.Data;
using Application.Core.Abstructions.Messaging;
using Domain.Users;

namespace Application.Users.Commands.UpdateName;

internal sealed class UpdateUserNameCommandHandler : ICommandHandler<UpdateUserNameCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateUserNameCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(UpdateUserNameCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = await _userRepository.GetById(request.UserId) ?? throw new NullReferenceException();

            user.ChangeName(request.FirstName, request.LastName);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}