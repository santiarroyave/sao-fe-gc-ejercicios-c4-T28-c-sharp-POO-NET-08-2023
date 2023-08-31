namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****          Ejercicio 6          *****");
            Console.WriteLine("*****************************************");
            Console.WriteLine("*****************************************");
            //En el fichero main, crear 2 objetos Libro (los valores que se quieran) y mostrarlos por pantalla.
            Libro libro1 = new Libro();
            Libro libro2 = new Libro();

            libro1.SetTitulo("Metas");
            libro1.SetAutor("Brian Tracy");
            libro1.SetIsbn("978-8495787590");
            libro1.SetNumPaginas(307);

            libro2.SetTitulo("Aprendiendo de los mejores");
            libro2.SetAutor("Francisco Alcaide Hernández");
            libro2.SetIsbn("978-8415678014");
            libro2.SetNumPaginas(360);

            libro1.ToString();
            libro2.ToString();


            //Por último, indicar cuál de los 2 tiene más páginas.
            Console.WriteLine();
            Console.Write("El libro con más páginas es: ");

            if (libro1.GetNumPaginas() > libro2.GetNumPaginas())
            {
                Console.WriteLine("{0} con {1} páginas.", libro1.GetTitulo(), libro1.GetNumPaginas());
            }
            else if (libro2.GetNumPaginas() > libro1.GetNumPaginas())
            {
                Console.WriteLine("{0} con {1} páginas.", libro2.GetTitulo(), libro2.GetNumPaginas());
            }
            else
            {
                Console.WriteLine("Los dos libros tienen el mismo número de páginas.");
            }
        }
    }
}