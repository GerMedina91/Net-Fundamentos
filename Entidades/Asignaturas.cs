using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi_Escuela.Entidades
{
    internal class Asignaturas
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }

        public Asignaturas(string nombre)
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
        }
    }
}
