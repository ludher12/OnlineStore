using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Models
{
    public class Alumno
    {
        public int AlumnoId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
