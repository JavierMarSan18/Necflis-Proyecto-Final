using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necflis
{
    class cCliente
    {
        public int id;
        public string nombre;
        public string direccion;
        public int edad;

        public cCliente(int id)
        {
            this.id = id;
        }

        public cCliente(int id, string nombre, string direccion, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }

        public cCliente(string nombre, string direccion, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
        }
    }
}
