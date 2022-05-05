using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPlatzi.Entidad
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public Asignatura() => UniqueId = System.Guid.NewGuid().ToString();
    }
}
