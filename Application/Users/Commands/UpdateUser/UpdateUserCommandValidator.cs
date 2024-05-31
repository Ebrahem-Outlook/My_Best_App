using FluentValidation;

namespace Application.Users.Commands.UpdateUser
{
    public sealed class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().NotNull();

            RuleFor(x => x.FirstName).NotEmpty().NotNull();

            RuleFor(x => x.LastName).NotEmpty().NotNull();
        }
    }
}
