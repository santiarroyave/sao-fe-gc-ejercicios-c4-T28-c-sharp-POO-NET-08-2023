using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//El aula debe tener un identificador numérico, el número máximo de estudiantes y para que esta destinada (matemáticas, filosofía o física). Piensa que más atributos necesita.

//Un aula para que se pueda dar clase necesita que el profesor esté disponible, que el profesor de la materia correspondiente en el aula correspondiente (un profesor de filosofía no puede dar en un aula de matemáticas) y que haya más del 50% de alumnos.

//El objetivo es crear un aula de alumnos y un profesor y determinar si puede darse clase, teniendo en cuenta las condiciones antes dichas.

//Si se puede dar clase mostrar cuantos alumnos y alumnas (por separado) están aprobados de momento (imaginad que les están entregando las notas).

namespace Ejercicio8
{
    internal class Aula
    {
        //id: number;
        //maxEstudiantes: number;
        //aulaDestinada: tMateria;
        //profesor: Profesor;
        //profesorDisponible: boolean;
        //alumnos: Estudiante[];

        int id;
        int maxEstudiantes;
        string materia;
        Profesor profesor;
        bool profesorDisponible;
        Estudiante[] alumnos;

        protected string[] materias = { "matemáticas", "filosofía", "física" };
        const int DEF_MAX_STUDENT = 30;

        public Aula(int id, string materia, Profesor profesor, Estudiante[] alumnos)
        {
            this.id = id;
            this.maxEstudiantes = DEF_MAX_STUDENT;
            this.materia = materia;
            this.profesor = profesor;
            this.profesorDisponible = profesor.EstaDisponible();
            this.alumnos = alumnos;
        }

        public void ToString()
        {
            Console.WriteLine("Aula {0}. Capacidad {1}. Materia {2}. Profesor {3} {4}", id, maxEstudiantes, materia, profesor, profesorDisponible);
        }

        public bool SePuedeDarClase()
        {
            if (profesorDisponible)
            {
                if (ProfeCorrecto() == true)
                {
                    if (AlumnosQueAsisten() >= maxEstudiantes / 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ProfeCorrecto()
        {
            if (profesor.GetMateria() == materia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AlumnosQueAsisten() {
            int contador = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (alumnos[i].EstaDisponible() == true)
                {
                    contador++;
                }
            }

            return contador;
        }

        public void MostrarAlumnosAprobados()
        {
            Console.WriteLine("| [Alumnas aprobadas]:");
            int contador = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {
                //if (alumnos[i].GetSexo())
                //{
                    
                //}
            }
        }
    }
}
