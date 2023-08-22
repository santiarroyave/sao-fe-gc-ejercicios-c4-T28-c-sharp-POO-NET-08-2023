using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio2
{
    internal class Persona
    {
        // # Parte 1/2 del ejercicio

        //2) Haz una clase llamada Persona que siga las siguientes condiciones:
        //Sus atributos son: nombre, edad, DNI, sexo(H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo.
        //Si quieres añadir algún atributo puedes hacerlo.
        //Por defecto, todos los atributos menos el DNI serán valores por defecto según su tipo (0 números, cadena vacía para String, etc.). Sexo sera hombre por defecto, usa una constante para ello.

        private string nombre;
        private int edad;
        private string dni;
        private char sexo; // H hombre, M mujer
        private double peso;
        private double altura;

        private string defNombre = "";
        private int defEdad = 0;
        private const char DEF_SEXO = 'H';
        private double defPeso = 0;
        private double defAltura = 0;


        //Se implantaran varios constructores:
        //• Un constructor por defecto.
        //• Un constructor con el nombre, edad y sexo, el resto por defecto.
        //• Un constructor con todos los atributos como parámetro.
        public Persona()
        {
            nombre = defNombre;
            edad = defEdad;
            sexo = DEF_SEXO;
            peso = defPeso;
            altura = defAltura;
            dni = GeneraDNI();
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = Char.ToUpper(sexo);
            peso = defPeso;
            altura = defAltura;
            dni = GeneraDNI();

            ComprobarSexo(this.sexo);
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = Char.ToUpper(sexo);
            this.peso = peso;
            this.altura = altura;
            dni = GeneraDNI();

            ComprobarSexo(this.sexo);
        }


        //Los métodos que se implementaran son:

        // • calcularIMC(): calculara si la persona esta en su peso ideal (peso en kg/(altura^2 en m)),
        // - si esta fórmula devuelve un valor menor que 20, la función devuelve un -1,
        // - si devuelve un número entre 20 y 25 (incluidos), significa que esta por debajo de su peso ideal la función devuelve un 0
        // - si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1.
        // Te recomiendo que uses constantes para devolver estos valores.
        public int CalcularIMC()
        {
            double alturaMetros = altura / 100;

            double imc = peso / (alturaMetros * alturaMetros);
            const int bajoPeso = -1;
            const int pesoIdeal = 0;
            const int sobrepeso = 1;

            Console.WriteLine(); // Añade espacio
            if (imc < 20)
            {
                Console.WriteLine("{0} está por debajo de su peso ideal.\n", nombre);
                return bajoPeso;
            }
            else if (imc >= 20 && imc <= 25)
            {
                Console.WriteLine("{0} está en su peso ideal.\n", nombre);
                return pesoIdeal;
            }
            else
            {
                Console.WriteLine("{0} tiene sobrepeso.\n", nombre);
                return sobrepeso;
            }
            Console.WriteLine(); // Añade espacio
        }

        // • esMayorDeEdad() : indica si es mayor de edad, devuelve un booleano.
        public bool EsMayorDeEdad()
        {
            if (this.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // • comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Si no es correcto, sera H. No sera visible al exterior.
        public void ComprobarSexo(char sexo)
        {
            if (sexo == 'H' || sexo == 'M')
            {
                // Correcto
            }
            else
            {
                this.sexo = 'H';
            }
        }
        // • toString(): devuelve toda la información del objeto.
        public string ToString()
        {
            Console.WriteLine("Persona: \n- Nombre: {0} \n- Edad: {1} \n- DNI: {2} \n- Sexo: {3} \n- Peso: {4} \n- Altura: {5}\n", nombre, edad, dni, sexo, peso, altura);

            return string.Format("Persona: \n- Nombre: {0} \n- Edad: {1} \n- DNI: {2} \n- Sexo: {3} \n- Peso: {4} \n- Altura: {5}", nombre, edad, dni, sexo, peso, altura);
        }

        // • generaDNI(): genera un número aleatorio de 8 cifras, genera a partir de este su número su letra correspondiente. Este método sera invocado cuando se construya el objeto.
        //Puedes dividir el método para que te sea más fácil. No será visible al exterior.
        private string GeneraDNI()
        {
            string tablaLetras = "TRWAGMYFPDXBNJZSQVHLCKE";
            string dni = "";
            string letra = "";
            int indiceLetra = -1;

            Random random = new Random();
            
            // Genera los numeros aleatorios
            for (int i = 0; i < 8; i++)
            {
                dni += random.Next(1, 9);
            }

            // Obtiene el indice del numero
            indiceLetra = int.Parse(dni) % 23;

            // Busca la letra con el indice anterior y se la añade al DNI
            dni += tablaLetras[indiceLetra];

            return dni;
        }

        //• Métodos set de cada parámetro, excepto de DNI
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetSexo(char sexo)
        {
            this.sexo = Char.ToUpper(sexo);
            ComprobarSexo(this.sexo);
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        public void SetAltura(double altura)
        {
            this.altura = altura;
        }


        // #El ejercicio continua en la Clase Main del Ejercicio 2
    }
}
