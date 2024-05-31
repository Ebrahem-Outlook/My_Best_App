using Domain.Core.Premitives;
using Microsoft.EntityFrameworkCore;

namespace Application.Core.Abstructions.Data
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
    }
}
