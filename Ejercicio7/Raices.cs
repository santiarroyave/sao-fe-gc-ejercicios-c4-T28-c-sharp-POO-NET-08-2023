using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    //Vamos a realizar una clase llamada Raices, donde representaremos los valores de una ecuación de 2º grado.
    internal class Raices
    {
        //Tendremos los 3 coeficientes como atributos, llamémosles a, b y c.
        int a;
        int b;
        int c;

        //Hay que insertar estos 3 valores para construir el objeto.
        public Raices(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //Las operaciones que se podrán hacer son las siguientes:
        //• obtenerRaices(): imprime las 2 posibles soluciones
        public void ObtenerRaices()
        {
            if (TieneRaices())
            {
                Calcular();
            }
            else
            {
                Console.WriteLine("La ecuación no tiene soluciones reales.");
            }
        }

        //• obtenerRaiz(): imprime única raíz, que será cuando solo tenga una solución posible.
        public void ObtenerRaiz()
        {
            if (TieneRaiz())
            {
                Calcular();
            }
            else
            {
                Console.WriteLine("Esta ecuación no tiene una raiz única.");
            }
        }

        //• getDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene la siguiente formula, (b ^ 2)-4*a*c
        public double GetDiscriminate()
        {
            double discriminate = (b * b) - 4 * a * c;
            return discriminate;
        }

        //• tieneRaices(): devuelve un booleano indicando si tiene dos soluciones, para que esto ocurra, el discriminante debe ser mayor o igual que 0.
        public bool TieneRaices()
        {
            return GetDiscriminate() > 0;
        }

        //• tieneRaiz(): devuelve un booleano indicando si tiene una única solución, para que esto ocurra, el discriminante debe ser igual que 0.
        public bool TieneRaiz()
        {
            return GetDiscriminate() == 0;
        }

        //• calcular(): mostrara por consola las posibles soluciones que tiene nuestra ecuación, en caso de no existir solución, mostrarlo también.
        //Formula ecuación 2º grado: (-b ± √((b ^ 2) - (4 * a * c)))/ (2 * a)
        //Solo varia el signo delante de -b
        public void Calcular()
        {
            double discriminate = GetDiscriminate();

            if (TieneRaices())
            {
                double raiz1 = (-b + Math.Sqrt(discriminate)) / (2 * a);
                double raiz2 = (-b - Math.Sqrt(discriminate)) / (2 * a);

                Console.WriteLine($"Solución 1: {raiz1}");
                Console.WriteLine($"Solución 2: {raiz2}");

            }
            else if (TieneRaiz())
            {
                double raizUnica = -b / (2 * a);
                Console.WriteLine($"Solución única: {raizUnica}");
            }
            else
            {
                Console.WriteLine("Las raíces son imaginarias.");
            }
        }
    }
}
