using System;
using System.Drawing;
using T28_C_Sharp_POO_NET.Ejercicio4;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****          Ejercicio 4          *****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");

            //Ahora crea una clase ejecutable que realice lo siguiente:
            //• Crea un array de Electrodomesticos de 10 posiciones.
            //• Asigna a cada posición un objeto de las clases anteriores con los valores que desees.

            Electrodomestico[] electrodomesticos = new Electrodomestico[10];

            electrodomesticos[0] = new Electrodomestico(30, 100);
            electrodomesticos[1] = new Television(50, true, 200, "negro", 'B', 20);
            electrodomesticos[2] = new Lavadora(8, 130, "gris", 'C', 60);
            electrodomesticos[3] = new Television();
            electrodomesticos[4] = new Television();
            electrodomesticos[5] = new Lavadora();
            electrodomesticos[6] = new Electrodomestico();
            electrodomesticos[7] = new Electrodomestico();
            electrodomesticos[8] = new Lavadora();
            electrodomesticos[9] = new Television();
            //Television(int resolucion, bool sintonizadorTDT, double precioBase, String color, char consumoEnergetico, double peso)
            //Lavadora(int carga, double precioBase, String color, char consumoEnergetico, double peso)


            //• Ahora, recorre este array y ejecuta el método precioFinal().
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Mostrando información individual de cada Electrodomestico con el precio final");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                if (electrodomesticos[i] is Electrodomestico)
                {
                    // Obtenemos y mostramos el nombre de tipo de clase    
                    electrodomesticos[i].PrecioFinal();
                    Console.WriteLine("| {0}", electrodomesticos[i].GetType().Name);

                    // Mostramos informacion de los precios
                    double precioFinal = electrodomesticos[i].GetPrecioBase();
                    Console.WriteLine("| - Precio final: {0} EUR", precioFinal);
                    Console.WriteLine("| - Consumo energético: {0}", electrodomesticos[i].GetConsumoEnergetico());
                    Console.WriteLine("| - Color: {0}", electrodomesticos[i].GetColor());
                    Console.WriteLine("| - Peso: {0} kg", electrodomesticos[i].GetPeso());
                    Console.WriteLine();
                }
            }

            //• Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, el de las lavadoras por otro y la suma de los Electrodomesticos (puedes crear objetos Electrodomestico, pero recuerda que Television y Lavadora también son electrodomésticos). Recuerda el uso operador instanceof.
            //Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 y una televisión de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 para televisión.
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Mostrando precios por tipo de clase y una suma total");
            Console.WriteLine("-----------------------------------------");

            string nombreTipoClase = "";
            double sumaTotal = 0;
            double sumaParcial = 0;

            // Mostrando precios de los objetos tipo Electrodomestico
            Console.WriteLine("Precio de cada electrodoméstico:");
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                nombreTipoClase = electrodomesticos[i].GetType().Name;

                // Discriminamos por tipo de clase
                if (nombreTipoClase == "Electrodomestico")
                {
                    // Imprimimos precio de la clase de este tipo
                    Console.WriteLine("| - {0} EUR", electrodomesticos[i].GetPrecioBase());

                    // Vamos sumando todos los precios
                    sumaTotal += electrodomesticos[i].GetPrecioBase();
                    sumaParcial += electrodomesticos[i].GetPrecioBase();
                }
            }

            // Mostramos la suma total de esta clase en concreto
            Console.WriteLine("| - Total: {0} EUR", sumaParcial);
            sumaParcial = 0;
            Console.WriteLine("----------------------");



            // Mostrando precios de los objetos tipo Lavadora
            Console.WriteLine("Precio de cada Lavadora:");
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                nombreTipoClase = electrodomesticos[i].GetType().Name;

                // Discriminamos por tipo de clase
                if (nombreTipoClase == "Lavadora")
                {
                    // Imprimimos precio de la clase de este tipo
                    Console.WriteLine("| - {0} EUR", electrodomesticos[i].GetPrecioBase());

                    // Vamos sumando todos los precios
                    sumaTotal += electrodomesticos[i].GetPrecioBase();
                    sumaParcial += electrodomesticos[i].GetPrecioBase();
                }
            }

            // Mostramos la suma total de esta clase en concreto
            Console.WriteLine("| - Total: {0} EUR", sumaParcial);
            sumaParcial = 0;
            Console.WriteLine("----------------------");



            // Mostrando precios de los objetos tipo Television
            Console.WriteLine("Precio de cada Television:");
            for (int i = 0; i < electrodomesticos.Length; i++)
            {
                nombreTipoClase = electrodomesticos[i].GetType().Name;

                // Discriminamos por tipo de clase
                if (nombreTipoClase == "Television")
                {
                    // Imprimimos precio de la clase de este tipo
                    Console.WriteLine("| - {0} EUR", electrodomesticos[i].GetPrecioBase());

                    // Vamos sumando todos los precios
                    sumaTotal += electrodomesticos[i].GetPrecioBase();
                    sumaParcial += electrodomesticos[i].GetPrecioBase();
                }
            }

            // Mostramos la suma total de esta clase en concreto
            Console.WriteLine("| - Total: {0} EUR", sumaParcial);
            sumaParcial = 0;
            Console.WriteLine("----------------------");



            // Mostrando precio total
            Console.WriteLine("Suma total de los electrodomesticos: {0} EUR", sumaTotal);
            Console.WriteLine("| - Total: {0} EUR", sumaParcial);
            sumaParcial = 0;
            Console.WriteLine("-----------------------------------------");
        }
    }
}