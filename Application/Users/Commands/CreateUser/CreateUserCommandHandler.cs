using Application.Core.Abstructions.Data;
using Domain.Users;
using MediatR;

namespace Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var user = User.Create(request.FirstName, request.LastName, request.Email, request.Password);

            _userRepository.Add(user);

            await _unitOfWork.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch(Exception)
        {
            return false;
        }
    }
}