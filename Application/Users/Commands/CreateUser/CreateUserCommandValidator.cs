using FluentValidation;

namespace Application.Users.Commands.CreateUser
{
    public sealed class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().NotNull();

            RuleFor(x => x.LastName).NotEmpty().NotNull();

            RuleFor(x => x.Email).NotEmpty().NotNull();

            RuleFor(x => x.Password).NotEmpty().NotNull();
        }
    }
}
