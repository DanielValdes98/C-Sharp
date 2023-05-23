using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Empleados
    {
        private string nombre;
        private int id;

        public Empleados(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
