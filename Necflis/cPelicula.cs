using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necflis
{
    class cPelicula
    {
        public string nombre;
        public string tipo;
        public string genero;
        public string sinopsis;

        public cPelicula(string nombre, string tipo, string genero, string sinopsis)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.genero = genero;
            this.sinopsis = sinopsis;
        }

        public cPelicula(string nombre, string genero)
        {
            this.nombre = nombre;
            this.genero = genero;
        }
    }
}
