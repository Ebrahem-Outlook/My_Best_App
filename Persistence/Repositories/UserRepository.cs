using Application.Core.Abstructions.Data;
using Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly IDbContext _dbContext;

        public UserRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(User user)
        {
            _dbContext.Set<User>().Add(user);
        }

        public void Delete(User user)
        {
            _dbContext.Set<User>().Remove(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbContext.Set<User>().ToListAsync();
        }

        public async Task<User> GetByEmail(string email)
        {
            return await _dbContext.Set<User>().FirstOrDefaultAsync(user => user.Email == email) ?? throw new NullReferenceException(); 
        }

        public async Task<User> GetById(Guid id)
        {
            return await _dbContext.Set<User>().FirstOrDefaultAsync(user => user.Id == id) ?? throw new NullReferenceException();
        }

        public void Update(User user)
        {
            _dbContext.Set<User>().Update(user);
        }
    }
}
