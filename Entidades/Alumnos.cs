using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi_Escuela.Entidades
{
    internal class Alumnos
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }

        public Alumnos(string nombre, string apellido, string segundoNombre = "")
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
            SegundoNombre = segundoNombre;
            Apellido = apellido;
        }
    }
}
