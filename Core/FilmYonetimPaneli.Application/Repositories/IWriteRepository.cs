using FilmYonetimPaneli.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> data);
        bool Remove(T model);
        bool RemoveRange(List<T> data);
        Task<bool> RemoveAsync(int id);
        bool Update(T model);
        Task<int> SaveAsync();
 
    }
}
