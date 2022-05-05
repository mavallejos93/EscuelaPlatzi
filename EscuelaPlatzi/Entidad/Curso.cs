using System.Collections.Generic;

namespace EscuelaPlatzi.Entidad
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso() => UniqueId = System.Guid.NewGuid().ToString();
    }
}