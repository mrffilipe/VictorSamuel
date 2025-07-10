using VictorSamuel.Domain.Common;

namespace VictorSamuel.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);
    }
}
