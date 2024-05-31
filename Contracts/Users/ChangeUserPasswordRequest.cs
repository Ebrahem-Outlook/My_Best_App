namespace Contracts.Users
{
    public sealed record ChangeUserPasswordRequest(Guid UserId, string Password);
}
