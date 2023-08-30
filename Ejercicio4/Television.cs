using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T28_C_Sharp_POO_NET.Ejercicio4;

namespace Ejercicio4
{
    internal class Television : Electrodomestico
    {
        //Crearemos una subclase llamada Television con las siguientes características:
        //• Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), ademas de los atributos heredados.
        //• Por defecto, la resolución sera de 20 pulgadas y el sintonizador sera false.
        int resolucion;
        bool sintonizadorTDT;

        const int DEF_RESOLUCION = 20;
        const bool DEF_SINTONIZADOR_TDT = false;

        //Los constructores que se implementaran serán:
        //✓ Un constructor por defecto.
        //✓ Un constructor con el precio y peso. El resto por defecto.
        //✓ Un constructor con la resolución, sintonizador TDT y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
        public Television()
        {
            resolucion = DEF_RESOLUCION;
            sintonizadorTDT = DEF_SINTONIZADOR_TDT;
        }

        public Television(double precioBase, double peso) :base(precioBase, peso)
        {
            resolucion = DEF_RESOLUCION;
            sintonizadorTDT = DEF_SINTONIZADOR_TDT;
        }

        public Television(int resolucion, bool sintonizadorTDT, double precioBase, String color, char consumoEnergetico, double peso) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.resolucion = resolucion;
            this.sintonizadorTDT= sintonizadorTDT;
        }

        //Los métodos que se implementara serán:
        //• Método get de resolución y sintonizador TDT.
        //• precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementara el precio un 30% y si tiene un sintonizador TDT incorporado, aumentara 50 €. Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.
        public int GetResolucion()
        {
            return resolucion;
        }

        public bool GetSintonizadorTDT()
        {
            return sintonizadorTDT;
        }

        public void PrecioFinal()
        {
            base.PrecioFinal();

            if (resolucion > 40)
            {
                Console.WriteLine("Tamaño superior a 40 pulgadas");
                Console.WriteLine("Incremento del 30%: {0} EUR", 0.3 * precioBase);
                precioBase += 0.3 * precioBase;
            }

            if (sintonizadorTDT == true)
            {
                Console.WriteLine("Sintonizador TDT");
                Console.WriteLine("- Incremento 50€");
                precioBase += 50;
            }
        }
    }
}
