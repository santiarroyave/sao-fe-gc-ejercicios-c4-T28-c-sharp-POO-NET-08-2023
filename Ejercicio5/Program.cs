using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****          Ejercicio 5          *****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");

            //Ahora crea una aplicación ejecutable y realiza lo siguiente:
            //• Crea dos arrays, uno de Series y otro de Videojuegos, de 5 posiciones cada uno.
            //• Crea un objeto en cada posición del array, con los valores que desees, puedes usar distintos constructores.
            Serie[] series = new Serie[5];
            Videojuego[] videojuegos = new Videojuego[5];

            videojuegos[0] = new Videojuego("Minecraft", 10, "Tipo Abierto", "Mojang");
            videojuegos[1] = new Videojuego("Mario Bros", 10, "Coches", "Mojang");
            videojuegos[2] = new Videojuego("Far Cry 6", 10, "Aventura", "Ubisoft");
            videojuegos[3] = new Videojuego("Fall Guys", 10, "Battle royale", "Mediatonic");
            videojuegos[4] = new Videojuego("Fortnite", 10, "Battle royale", "Epic Games");

            series[0] = new Serie("Peaky Blinders", "Steven Knight");
            series[1] = new Serie("Cómo defender a un asesino", "Pete Nowalk");
            series[2] = new Serie("Prison Break", "Paul Scheuring");
            series[3] = new Serie("Juego de Tronos", "George R. R. Martin");
            series[4] = new Serie("The Flash", "Gardner Fox");

            // Añadiendo numero temporada series
            series[0].SetNumeroTemporadas(6);
            series[1].SetNumeroTemporadas(6);
            series[2].SetNumeroTemporadas(5);
            series[3].SetNumeroTemporadas(8);
            series[4].SetNumeroTemporadas(9);

            // Mostrando arrays
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Mostrando array de los videojuegos");
            Console.WriteLine("-----------------------------------------");
            foreach (var videojuego in videojuegos)
            {
                Console.WriteLine(videojuego.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Mostrando array de las series");
            Console.WriteLine("-----------------------------------------");
            foreach (var serie in series)
            {
                Console.WriteLine(serie.ToString());
                Console.WriteLine();
            }

            //• Entrega algunos Videojuegos y Series con el método entregar().
            //• Cuenta cuantos Series y Videojuegos hay entregados. Al contarlos, devuélvelos.
            //• Por último, indica el Videojuego tiene más horas estimadas y la serie con mas temporadas. Muestralos en pantalla con toda su información (usa el método toString()).
            videojuegos[1].Entregar();
            videojuegos[4].Entregar();

            series[1].Entregar();
            series[3].Entregar();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Videojuegos entregados:");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < videojuegos.Length; i++)
            {
                if (videojuegos[i].IsEntregado() == true)
                {
                    Console.WriteLine(videojuegos[i].ToString());
                    Console.WriteLine();
                }
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Series entregados:");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i].IsEntregado() == true)
                {
                    Console.WriteLine(series[i].ToString());
                    Console.WriteLine();
                }
            }


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Videojuego con más horas:");
            Console.WriteLine("-----------------------------------------");
            Videojuego videojuegoConMasHoras = videojuegos[0];
            foreach (var videojuego in videojuegos)
            {
                if (videojuego.CompareTo(videojuegoConMasHoras) != -1)
                {
                    videojuegoConMasHoras = videojuego;
                };
            }
            Console.WriteLine("{0}", videojuegoConMasHoras.ToString());
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Serie con más temporadas:");
            Console.WriteLine("-----------------------------------------");
            Serie seriesConMasTemporadas = series[0];
            foreach (var serie in series)
            {
                if (serie.CompareTo(seriesConMasTemporadas) != -1)
                {
                    seriesConMasTemporadas = serie;
                };
            }
            Console.WriteLine("{0}", videojuegoConMasHoras.ToString());
        }
    }
}