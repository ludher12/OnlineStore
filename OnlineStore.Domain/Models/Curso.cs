using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int ProfesorId { get; set; }
        public Profesor? Profesor { get; set; }
        public ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
    }
}
