using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio4
{
    internal class Electrodomestico
    {
        //Crearemos una supeclase llamada Electrodomestico con las siguientes características:
        // • Sus atributos son precio base, color, consumo energético (letras entre A y F) y peso. Indica que se podrán heredar.
        // • Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de 100 € y el peso de 5 kg. Usa constantes para ello.
        // • Los colores disponibles son blanco, negro, rojo, azul y gris. No importa si el nombre esta en mayúsculas o en minúsculas.

        protected double precioBase;
        protected String color;
        protected char consumoEnergetico;
        protected double peso;

        protected const String COLOR_DEFECTO = "blanco";
        protected const char CONSUMO_ENERGETICO_DEFECTO = 'F';
        protected const double PRECIO_BASE_DEFECTO = 100.0;
        protected const double PESO_DEFECTO = 5.0;

        protected readonly String[] COLORES_DISPONIBLES = { "blanco", "negro", "rojo", "azul", "gris" };

        //Los constructores que se implementaran serán
        //✓ Un constructor por defecto.
        //✓ Un constructor con el precio y peso. El resto por defecto.
        //✓ Un constructor con todos los atributos.

        public Electrodomestico()
        {
            precioBase = PRECIO_BASE_DEFECTO;
            color = COLOR_DEFECTO;
            consumoEnergetico = CONSUMO_ENERGETICO_DEFECTO;
            peso = PESO_DEFECTO;
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            color = COLOR_DEFECTO;
            consumoEnergetico = CONSUMO_ENERGETICO_DEFECTO;
        }

        public Electrodomestico(double precioBase, String color, char consumoEnergetico, double peso)
        {
            this.precioBase = precioBase;
            this.color = ComprobarColor(color);
            this.color = color;
            this.consumoEnergetico = ComprobarConsumoEnergetico(consumoEnergetico);
            this.peso = peso;
        }

        //Los métodos que implementara serán:
        //• Métodos get de todos los atributos.
        //• comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no sera visible.
        //• comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. Se invocara al crear el objeto y no sera visible.
        //• precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también.

        // Métodos get de todos los atributos
        public double GetPrecioBase()
        {
            return precioBase;
        }

        public String GetColor()
        {
            return color;
        }

        public char GetConsumoEnergetico()
        {
            return consumoEnergetico;
        }

        public double GetPeso()
        {
            return peso;
        }

        private char ComprobarConsumoEnergetico(char consumo)
        {
            if (consumo >= 'A' && consumo <= 'F')
            {
                return consumo;
            }
            else
            {
                return CONSUMO_ENERGETICO_DEFECTO;
            }
        }

        private String ComprobarColor(String color)
        {
            String colorValido = color.ToLower();
            foreach (var colorDisponible in COLORES_DISPONIBLES)
            {
                if (colorDisponible.Equals(colorValido))
                {
                    return colorValido;
                }
            }
            return COLOR_DEFECTO;
        }

        //Esta es la lista de precios:

        //| Letra | Precio |
        //| --- | --- |
        //| A | 100€ |
        //| B | 80€ |
        //| C | 60€ |
        //| D | 50€ |
        //| E | 30€ |
        //| F | 10€ |

        //| Tamaño | Precio |
        //| --- | --- |
        //| Entre 0 y 19 kg | 10€ |
        //| Entre 20 y 49 kg | 50€ |
        //| Entre 50 y 79 kg | 80€ |
        //| Mayor que 80 kg | 100€ |
        public void PrecioFinal()
        {

            switch (consumoEnergetico)
            {
                case 'A':
                    precioBase += 100;
                    break;
                case 'B':
                    precioBase += 80;
                    break;
                case 'C':
                    precioBase += 60;
                    break;
                case 'D':
                    precioBase += 50;
                    break;
                case 'E':
                    precioBase += 30;
                    break;
                case 'F':
                    precioBase += 10;
                    break;
            }

            if (peso >= 0 && peso < 20)
            {
                precioBase += 10;
            }
            else if (peso >= 20 && peso < 50)
            {
                precioBase += 50;
            }
            else if (peso >= 50 && peso < 80)
            {
                precioBase += 80;
            }
            else if (peso >= 80)
            {
                precioBase += 100;
            }
        }
    }
}
