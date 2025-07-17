using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.Interfaces;
using OnlineStore.Domain.Models;
using OnlineStore.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Repositories
{
    public class CursoRepository : ICursosRepository
    {
        private readonly OnlineStoeDbContext _context;
        public CursoRepository(OnlineStoeDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Curso curso)
        {
             _context.Cursos.Add(curso);
             await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Curso>> GetAllAsync()
        {
            return await _context.Cursos.ToListAsync();
        }

        public async Task<Curso> GetByIdAsync(int id)
        {
            return await _context.Cursos.FindAsync(id);
        }

        public Task UpdateAsync(Curso curso)
        {
            var cursoExistente = _context.Cursos.Find(curso.Id);
            if (cursoExistente != null)
            {
                cursoExistente.Nombre = curso.Nombre;
                cursoExistente.Descripcion = curso.Descripcion;
                _context.Cursos.Update(cursoExistente);
                return _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Curso not found");
            }
        }
    }
}
