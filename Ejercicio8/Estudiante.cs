using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Estudiante : Personas
    {
        double calificacion;

        public Estudiante(string nombre, int edad, string sexo, double calificacion) : base(nombre, edad, sexo)
        {
            this.calificacion = calificacion;
        }

        public override bool EstaDisponible(){

            // Se considera disponible si devuelve true
            Random rnd = new Random();
            double random = rnd.NextDouble();
            if (random < 0.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ToString()
        {
            Console.WriteLine("- {0}, {1} años, sexo {2}. Nota: {3}", nombre, edad, sexo, calificacion);
        }
    }
}
