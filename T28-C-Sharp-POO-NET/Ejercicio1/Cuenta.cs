using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace T28_C_Sharp_POO_NET.Ejercicio1
{
    internal class Cuenta
    {
        //1) Crea una clase llamada Cuenta que tendrá los siguientes atributos: 
        //  - titular
        //  - cantidad (puede tener decimales)

        //El titular será obligatorio y la cantidad es opcional.
        //Crea dos constructores que cumpla lo anterior.

        //Crea sus métodos get, set y toString.

        //Tendrá dos métodos especiales:
        //- ingresar(double cantidad): se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.
        //- retirar(double cantidad): se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.


        //ATRIBUTOS
        private string titular;
        private double cantidad;

        //CONSTRUCTORES
        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0.0;
        }

        public Cuenta(string titular, double cantidad = 0.0)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //MÉTODOS
        // Getters
        public string getTitular()
        {
            Console.WriteLine("El titular es {0}", this.titular);
            return this.titular;
        }
        public double getCantidad()
        {
            Console.WriteLine("La cantidad actual es {0} euros\n", this.cantidad);
            return this.cantidad;
        }

        // Setters
        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public void setCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }

        // toString
        public void toString()
        {
            Console.WriteLine("El titular es {0}", this.titular);
            Console.WriteLine("Su cantidad es {0} euros\n", this.cantidad);
        }

        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
                Console.WriteLine("Has ingresado {0} de euros", cantidad);
            }
            else
            {
                Console.WriteLine("La cantidad introducida es negativa");
            }
        }

        public void Retirar(double cantidad)
        {
            if ((this.cantidad - cantidad) < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }

            Console.WriteLine("Se han retirado {0} euros", cantidad);
        }
    }
}
