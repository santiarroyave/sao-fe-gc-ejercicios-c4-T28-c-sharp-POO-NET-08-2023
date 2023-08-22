using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio3
{
    internal class Password
    {
        // # Parte 1/2 del ejercicio

        //3) Haz una clase llamada Password que siga las siguientes condiciones:
        // • Que tenga los atributos longitud y contraseña. Por defecto, la longitud sera de 8.
        private int longitud;
        private string password;

        private int defLongitud = 8;

        // • Los constructores serán los siguiente:
        //  ✓ Un constructor por defecto.
        //  ✓ Un constructor con la longitud que nosotros le pasemos. Generara una contraseña aleatoria con esa longitud.
        public Password()
        {
            longitud = defLongitud;
            password = GenerarPassword(longitud);
        }

        public Password(int longitud)
        {
            password = GenerarPassword(longitud);
        }


        //Los métodos que implementa serán:
        // • esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debetener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
        public bool EsFuerte()
        {
            int cantidadMayusculas = 0;
            int cantidadMinusculas = 0;
            int cantidadNumeros = 0;

            foreach (char caracter in password)
            {
                // Cuenta las mayusculas
                if (char.IsUpper(caracter))
                {
                    cantidadMayusculas++;
                }

                // Cuenta las minusculas
                if (char.IsLower(caracter))
                {
                    cantidadMinusculas++;
                }

                // Cuenta los números
                if (char.IsDigit(caracter))
                {
                    cantidadNumeros++;
                }
            }

            // Comprueba si es fuerte o no
            if (cantidadMayusculas > 2 && cantidadMinusculas > 1 && cantidadNumeros > 5)
            {
                return true;
            }

            return false;
        }

        // • generarPassword(): genera la contraseña del objeto con la longitud que tenga.
        public string GenerarPassword(int longitud)
        {
            string password = "";

            Random random = new Random();
            for (int i = 0; i < longitud; i++)
            {
                // Numero random para elegir que tipo de caracter incluir a la contraseña
                int randomTemp = random.Next(0, 3);

                if (randomTemp == 2)
                {
                    // Mayusculas
                    password += (char)random.Next(65, 91);
                }
                else if (randomTemp == 1)
                {
                    // Minusculas
                    password += (char)random.Next(97, 123);
                }
                else
                {
                    // Números
                    password += random.Next(0,9);
                }
            }

            return password;
        }

        // • Método get para contraseña y longitud.
        public string GetPassword()
        {
            return password;
        }
        public int GetLongitud()
        {
            return longitud;
        }

        // • Método set para longitud.
        public void SetLongitud(int longitud)
        {
            this.longitud = longitud;
        }
    }
    // #El ejercicio continua en la Clase Main del Ejercicio 3
}
