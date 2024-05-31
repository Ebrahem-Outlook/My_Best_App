namespace Contracts.Users
{
    public sealed record ChangeUserNameRequest(Guid UserId, string FirstName, string LastName);
}
