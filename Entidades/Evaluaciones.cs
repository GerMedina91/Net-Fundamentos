using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi_Escuela.Entidades
{
    internal class Evaluaciones
    {
        public string Id { get; private set; }
        public Alumnos Alumno { get; set; }
        public Asignaturas Asignatura { get; set; }
        public decimal Puntaje { get; set; }
        public Evaluaciones(Alumnos alumno, Asignaturas asignatura, decimal puntaje)
        {
            Id = Guid.NewGuid().ToString();
            Alumno = alumno;
            Asignatura = asignatura;
            Puntaje = puntaje;
        }
    }
}
