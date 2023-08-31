namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****          Ejercicio 7          *****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejemplo 1:");
            Console.WriteLine("-----------------------------------------");
            int a = 4;
            int b = 23;
            int c = 13;
            Console.WriteLine("| a = {0}", a);
            Console.WriteLine("| b = {0}", b);
            Console.WriteLine("| c = {0}", c);

            Raices raiz1 = new Raices(a, b, c);

            Console.WriteLine();
            raiz1.ObtenerRaices();

            Console.WriteLine();
            raiz1.ObtenerRaiz();
            Console.WriteLine();


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejemplo 2:");
            Console.WriteLine("-----------------------------------------");
            a = 1;
            b = -2;
            c = 1;
            Console.WriteLine("| a = {0}", a);
            Console.WriteLine("| b = {0}", b);
            Console.WriteLine("| c = {0}", c);

            Raices raiz2 = new Raices(a, b, c);

            Console.WriteLine();
            raiz2.Calcular();
            Console.WriteLine();


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ejemplo 3:");
            Console.WriteLine("-----------------------------------------");
            a = 1;
            b = 2;
            c = 5;
            Console.WriteLine("| a = {0}", a);
            Console.WriteLine("| b = {0}", b);
            Console.WriteLine("| c = {0}", c);

            Raices raiz3 = new Raices(a, b, c);

            Console.WriteLine();
            raiz3.Calcular();
        }
    }
}