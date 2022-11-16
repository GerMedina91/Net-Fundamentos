using Platzi_Escuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi_Escuela.App
{
    internal class CoreEscuela
    {
        public Escuela Escuela { get; set; }

        public void InitEscuela()
        {
            Escuela = new Escuela("Tecnica n°3", 1979, TipoEscuela.secundaria);

            Escuela.Cursos = GenerarCursos();
        }

        private List<Cursos> GenerarCursos()
        {

            List<Cursos> cursos = new List<Cursos>()
            {
                new Cursos("301", TipoJornada.mañana),
                new Cursos("305", TipoJornada.mañana),
                new Cursos("421", TipoJornada.tarde),
                new Cursos("105", TipoJornada.tarde),
                new Cursos("203", TipoJornada.noche),
                new Cursos("404", TipoJornada.noche),
            };


            Random random = new Random();
            foreach (var cur in cursos)
            {
                int cantidadAlumnos = random.Next(10, 35);
                cur.Alumnos = GenerarAlumnos(cantidadAlumnos);
                cur.Asignaturas = GenerarAsignaturas();
            }

            return cursos;
        }

        private List<Asignaturas> GenerarAsignaturas()
        {
            return new List<Asignaturas>() {
                new Asignaturas("Matematica"),
                new Asignaturas("Fisica"),
                new Asignaturas("Letras"),
                new Asignaturas("Geografia"),
                new Asignaturas("Historia")
            };
        }


        private List<Alumnos> GenerarAlumnos(int cantidad)
        {
            string[] nombre = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] segundoNombre = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
            string[] apellido = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };


            var listaAlumnos = from n1 in nombre
                      from n2 in segundoNombre
                      from ap in apellido
                      select new Alumnos(n1,ap,n2);


            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }

        public string ImprimirEvaluaciones(Cursos curso)
        {
            curso.IniciarExamen();

            string evaluaciones = $"EVALUACIONES DEL CURSO {curso.Nombre}\n";

            foreach (var ex in curso.Evaluaciones)
            {
                evaluaciones += $"Alumno: {ex.Alumno.Nombre} {ex.Alumno.Apellido}, Asignatura: {ex.Asignatura.Nombre}, Nota: {ex.Puntaje}\n";
            }

            return evaluaciones;
        }
    }
}
