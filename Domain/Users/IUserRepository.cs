namespace Domain.Users
{
    public interface IUserRepository
    {
        // Commands
        void Add(User user);
        void Update(User user);
        void Delete(User user);

        // Queries
        Task<List<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<User> GetByEmail(string email);
    }
}
