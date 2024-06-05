using FluentValidation;

namespace Application.Users.Queries.GetUserByEmail;

internal sealed class GetUserByEmailQueryValidator : AbstractValidator<GetUserByEmailQuery>
{
    public GetUserByEmailQueryValidator()
    {
        RuleFor(x => x.Email).NotEmpty().NotNull();
    }
}