using Platzi_Escuela.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi_Escuela.Entidades
{
    internal class Cursos
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }
        public List<Alumnos> Alumnos { get; set; }
        public List<Asignaturas> Asignaturas { get; set; }
        public TipoJornada Jornada { get; set; }
        public List<Evaluaciones> Evaluaciones { get; private set; }

        public Cursos(string nombre, TipoJornada jornada)
        {
            Id = Guid.NewGuid().ToString();
            Nombre = nombre;
            Jornada = jornada;
        }

        public void IniciarExamen()
        {
            List<Evaluaciones> evaluaciones = new List<Evaluaciones>();

            foreach (var asig in Asignaturas)
            {
                foreach (var al in Alumnos)
                {
                    Random r = new Random();
                    evaluaciones.Add(new Evaluaciones(al, asig, UtilFunctions.GenerarNota(r)));
                }
            }

            Evaluaciones = evaluaciones;
        }
    }
}
