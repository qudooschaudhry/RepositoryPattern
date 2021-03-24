using LMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LMS.Infrastructure.Repositories
{
    public interface IRepository<T> where T : IRootAggregate, new()
    {
        Task<T> GetById(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
        Task Add(T entity, CancellationToken cancellationToken);
        Task Save(T entity, CancellationToken cancellationToken);
        Task Delete(T entity, CancellationToken cancellationToken);
    }
}
