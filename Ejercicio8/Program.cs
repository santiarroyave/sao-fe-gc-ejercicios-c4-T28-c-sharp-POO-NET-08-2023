//Queremos representar con programación orientada a objetos, un aula con estudiantes y un profesor.

//Tanto de los estudiantes como de los profesores necesitamos saber su nombre, edad y sexo. De los estudiantes, queremos saber también su calificación actual (entre 0 y 10) y del profesor que materia da.
//Las materias disponibles son matemáticas, filosofía y física.

//Los estudiantes tendrán un 50% de hacer novillos, por lo que si hacen novillos no van a clase pero aunque no vayan quedara registrado en el aula (como que cada uno tiene su sitio).
//El profesor tiene un 20% de no encontrarse disponible (reuniones, baja, etc.)
//Las dos operaciones anteriores deben llamarse igual en Estudiante y Profesor (polimorfismo).


//NOTA: Los datos pueden ser aleatorios (nombres, edad, calificaciones, etc.) siempre y cuando tengan sentido (edad no puede ser 80 en un estudiante o calificación ser 12)

using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****          Ejercicio 8          *****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");

            const int DEF_NUM_ESTUDINTES = 30;
            const int DEF_NUM_PROFES = 15;

            // Generando alumnos y profesores y aulas aleatorios

            Estudiante[] estudiantes = new Estudiante[DEF_NUM_ESTUDINTES];
            Profesor[] profesores = new Profesor[DEF_NUM_PROFES];
            Aula[] aulas = new Aula[6];

            string[] nombres = { "Juan", "Pedro", "Carlos", "Luis", "Alejandro", "Andrés", "Gabriel", "Diego", "José", "Miguel", "María", "Ana", "Laura", "Andrea", "Sofía", "Carolina", "Gabriela", "Natalia", "Valentina", "Isabella" };

            // Rellena la lista de estudiantes con estudiantes random
            for (int i = 0; i < estudiantes.Length; i++)
            {
                string rNombre = nombres[NumRandom(0, 19)];
                int rEdad = NumRandom(16, 25);
                string rSexo = SexoRandom();
                double rNota = NumRandom(0, 10);

                estudiantes[i] = new Estudiante(rNombre, rEdad, rSexo, rNota);
            }

            // Rellena la lista de profes con profes random
            for (int i = 0; i < profesores.Length; i++)
            {
                string rNombre = nombres[NumRandom(0, 19)];
                int rEdad = NumRandom(30, 60);
                string rSexo = SexoRandom();
                string rMateria = MateriaRandom();

                profesores[i] = new Profesor(rNombre, rEdad, rSexo, rMateria);
            }

            // Rellena aulas
            for (int i = 0; i < aulas.Length; i++)
            {
                aulas[i] = new Aula(i, MateriaRandom(), profesores[NumRandom(0, profesores.Length - 1)], estudiantes);
            }

            Console.WriteLine("=============================================================");
            Console.WriteLine("Información de las listas");
            Console.WriteLine("=============================================================");
            foreach (var estudiante in estudiantes)
            {
                estudiante.ToString();
            }
            foreach (var profe in profesores)
            {
                profe.ToString();
            }
            foreach (var aula in aulas)
            {
                aula.ToString();
            }

            Console.WriteLine("=============================================================");
            Console.WriteLine("Alumnos aprobados de las clases que se dan");
            Console.WriteLine("=============================================================");

            for (int i = 0; i < aulas.Length; i++)
            {
                if (aulas[i].SePuedeDarClase() == true)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine($"El aula {i} si puede dar clase.");
                    aulas[i].MostrarAlumnosAprobados();
                }
                else
                {
                    Console.WriteLine($"El aula {i} no puede dar clase");
                }
            }
        }


        //METODOS
        public static int NumRandom(int minimo, int maximo)
        {
            Random random = new Random();
            return random.Next(minimo, maximo + 1);
        }

        public static string SexoRandom()
        {
            Random rnd = new Random();

            if (rnd.NextDouble() > 0.5)
            {
                return "masculino";
            }
            else
            {
                return "femenino";
            }
        }

        public static string MateriaRandom()
        {
            Random rnd = new Random();
            double numRandom = rnd.NextDouble();

            if (numRandom < 0.3)
            {
                return "matemáticas";
            }
            else if (0.3 < numRandom && numRandom < 0.6)
            {
                return "filosofía";
            }
            else
            {
                return "física";
            }
        }
    }
}