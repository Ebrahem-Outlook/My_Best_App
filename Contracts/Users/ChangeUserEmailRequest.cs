namespace Contracts.Users
{
    public sealed record ChangeUserEmailRequest(Guid UserId, string Email);
}
