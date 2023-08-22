using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio2
{
    internal class MainApp
    {
        public static void Main()
        {
            // # Parte 2/2 del ejercicio

            //Ahora, crea una clase ejecutable que haga lo siguiente:
            //• Pide por teclado el nombre, la edad, sexo, peso y altura.
            Console.WriteLine("Escribe un nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nEscribe la edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscribe 'H' si eres hombre o 'M' si eres mujer:");
            char sexo = Console.ReadLine()[0];

            Console.WriteLine("\nEscribe el peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEscribe la altura");
            double altura = double.Parse(Console.ReadLine());

            //• Crea 3 objetos de la clase anterior
            // - el primer objeto obtendrá las anteriores variables pedidas por teclado
            // - el segundo objeto obtendrá todos los anteriores menos el peso y la altura
            // - el último por defecto, para este último utiliza los métodos set para darle a los atributos un valor.
            Persona persona1 = new Persona(nombre, edad, sexo, peso, altura);
            Persona persona2 = new Persona(nombre, edad, sexo);
            Persona persona3 = new Persona();

            persona3.SetNombre("Santi");
            persona3.SetSexo('h');
            persona3.SetEdad(40);
            persona3.SetPeso(70);
            persona3.SetAltura(170);

            //• Para cada objeto, deberá comprobar si esta en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
            persona1.CalcularIMC();
            persona2.CalcularIMC();
            persona3.CalcularIMC();

            //• Indicar para cada objeto si es mayor de edad.
            persona1.EsMayorDeEdad();
            persona2.EsMayorDeEdad();
            persona3.EsMayorDeEdad();

            //• Por último, mostrar la información de cada objeto.
            persona1.ToString();
            persona2.ToString();
            persona3.ToString();
        }
    }
}
