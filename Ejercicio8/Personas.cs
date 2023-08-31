using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    abstract internal class Personas
    {
        protected string nombre;
        protected int edad;
        protected string sexo;

        public Personas(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string GetNombre() { return nombre; }
        public int GetEdad() { return edad; }
        protected string GetSexo() { return sexo; }

        public abstract bool EstaDisponible();
    }
}
