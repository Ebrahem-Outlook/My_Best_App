using FluentValidation;

namespace Application.Users.Commands.UpdateEmail;

internal sealed class UpdateUserEmailCommandValidator : AbstractValidator<UpdateUserEmailCommand>
{
    public UpdateUserEmailCommandValidator()
    {
        RuleFor(x => x.UserId).NotNull().NotEmpty();

        RuleFor(x => x.Email).NotNull().NotEmpty();
    }
}