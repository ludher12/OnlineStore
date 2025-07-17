using OnlineStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Application.Interfaces
{
    public interface ICursosRepository
    {
        Task<IEnumerable<Curso>> GetAllAsync();
        Task<Curso> GetByIdAsync(int id);
        Task AddAsync(Curso curso);
        Task UpdateAsync(Curso curso);
    }
}
