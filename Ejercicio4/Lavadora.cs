using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio4
{
    internal class Lavadora : Electrodomestico
    {
        //Crearemos una subclase llamada Lavadora con las siguientes características:
        //• Su atributo es carga, ademas de los atributos heredados.
        //• Por defecto, la carga es de 5 kg. Usa una constante para ello.
        int carga;
        const int DEF_CARGA = 5;

        //Los constructores que se implementaran serán:
        //✓ Un constructor por defecto.
        //✓ Un constructor con el precio y peso. El resto por defecto.
        //✓ Un constructor con la carga y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clase padre.
        public Lavadora()
        {
            carga = DEF_CARGA;
        }

        public Lavadora(double precioBase, double peso) :base(precioBase, peso)
        {
            carga = DEF_CARGA;
        }

        public Lavadora(int carga, double precioBase, String color, char consumoEnergetico, double peso) :base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        //Los métodos que se implementara serán:
        //• Método get de carga.
        //• precioFinal():, si tiene una carga mayor de 30 kg, aumentara el precio 50 €, sino es así no se incrementara el precio. Llama al método padre y añade el código necesario. Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar al precio.
        public int GetCarga()
        {
            return carga;
        }

        public void PrecioFinal()
        {
            base.PrecioFinal();

            if (carga > 30)
            {
                Console.WriteLine("Pesa más de 30kg");
                Console.WriteLine("- Incremento 50€");
                precioBase += 50;
            }
        }
    }
}
