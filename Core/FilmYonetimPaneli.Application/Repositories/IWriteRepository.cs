using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FilmYonetimPaneli.Application.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : class
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddAsync(List<T> model);
        Task<bool> Remove(T model);
        Task<bool> Remove(int id);
        Task<bool> UpdateAsync(T model);
 
    }
}
