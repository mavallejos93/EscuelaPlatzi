using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPlatzi.Entidad
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public List<Evaluacion> Evaluaciones { get; set; }

        public Alumno()
        {
            this.UniqueId = System.Guid.NewGuid().ToString();
            this.Evaluaciones = new List<Evaluacion>() { };
        }
    }
}
