using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Platzi_Escuela.Entidades
{
    internal class Escuela
    {
        private string id;

        public string Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TipoEscuela{ get; set; }
        public List<Cursos> Cursos { get; set; }

        public Escuela(string nombre, int añoCreacion, TipoEscuela tipoEscuela,string pais = "Argentina", string ciudad = "Buenos Aires")
        {
            Nombre = nombre;
            AñoCreacion = añoCreacion;
            TipoEscuela = tipoEscuela;
            Pais = pais;
            Ciudad = ciudad;
            this.id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"Escuela: {Nombre} - {char.ToUpper(TipoEscuela.ToString()[0]) + TipoEscuela.ToString().Substring(1)} - desde {AñoCreacion} \nPais: {Pais} \nCiudad: {Ciudad}";
        }
    }
}
