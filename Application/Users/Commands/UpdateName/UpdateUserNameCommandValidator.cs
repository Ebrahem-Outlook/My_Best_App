using FluentValidation;

namespace Application.Users.Commands.UpdateName;

internal sealed class UpdateUserNameCommandValidator : AbstractValidator<UpdateUserNameCommand>
{
    public UpdateUserNameCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().NotNull();

        RuleFor(x => x.FirstName).NotEmpty().NotNull();

        RuleFor(x => x.LastName).NotEmpty().NotNull();
    }
}