using FluentValidation;

namespace Application.Users.Commands.UpdatePassword;

internal sealed class UpdateUserPasswordCommandValidator : AbstractValidator<UpdateUserPasswordCommand>
{
    public UpdateUserPasswordCommandValidator()
    {
        RuleFor(x => x.UserId).NotNull().NotEmpty();

        RuleFor(x => x.Password).NotNull().NotEmpty();
    }
}