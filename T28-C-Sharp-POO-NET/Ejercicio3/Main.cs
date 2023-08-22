using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio3
{
    internal class MainApp
    {
        public static void Main()
        {
            // # Parte 2/2 del ejercicio

            //Ahora, crea una clase clase ejecutable:
            // • Crea un array de Passwords con el tamaño que tu le indiques por teclado.
            // • Crea un bucle que cree un objeto para cada posición del array.
            // • Indica también por teclado la longitud de los Passwords(antes de bucle).
            // • Crea otro array de booleanos donde se almacene si el password del array de Password es o no fuerte(usa el bucle anterior).
            //Al final, muestra la contraseña y si es o no fuerte (usa el bucle anterior). Usa este simple formato:
            //  contraseña1 valor_booleano1
            //  contraseña2 valor_bololeano2

            Console.WriteLine("¿Cuántas contraseñas quieres?");
            int tamaño = int.Parse(Console.ReadLine());
            Password[] passwords = new Password[tamaño];
            bool[] sonFuertes = new bool[tamaño];

            Console.WriteLine("\n¿De que longitud quieres las contraseñas?");
            int longitud = int.Parse(Console.ReadLine());

            Console.WriteLine("\nContraseñas:");
            for (int i = 0; i < passwords.Length; i++)
            {
                passwords[i] = new Password(longitud);
                sonFuertes[i] = passwords[i].EsFuerte();

                Console.WriteLine("{0} {1}", passwords[i].GetPassword(), sonFuertes[i]);
            }
        }
    }
}
