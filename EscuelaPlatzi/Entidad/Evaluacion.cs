using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPlatzi.Entidad
{
    public class Evaluacion
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        public Evaluacion() => UniqueId = System.Guid.NewGuid().ToString();
    }
}
