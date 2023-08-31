using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Profesor : Personas
    {
        string materia;
        protected string[] materias = { "matemáticas", "filosofía", "física" };

        public Profesor(string nombre, int edad, string sexo, string materia) : base(nombre, edad, sexo)
        {
            this.materia = materia;
        }

        public string GetMateria() { return materia; }
        public override bool EstaDisponible()
        {

            // Se considera disponible si devuelve true
            Random rnd = new Random();
            double random = rnd.NextDouble();
            if (random < 0.8)
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
            Console.WriteLine("Profe: {0}, {1} años, sexo {2}. Materia: {3}", nombre, edad, sexo, materia);
        }
    }
}
