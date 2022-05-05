using System.Collections.Generic;

namespace EscuelaPlatzi.Entidad
{
    public class Escuela
    {
        public string UniqueId { get; private set; } = System.Guid.NewGuid().ToString();

        string nombre;
        public string Nombre
        {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñodeCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        //public Curso[] Cursos { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int año, TiposEscuela tipo, string pais = "", string ciudad = "")
        {
            Nombre = nombre;
            AñodeCreacion = año;
            Pais = pais;
            Ciudad = ciudad;

        }


        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\" , Tipo: {TipoEscuela} \nPais: {Pais} , Ciudad: {Ciudad}";
        }
    }

}
