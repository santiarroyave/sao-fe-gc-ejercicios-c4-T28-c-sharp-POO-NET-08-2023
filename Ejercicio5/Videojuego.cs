using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Videojuego : IEntregable
    {
        //Crearemos una clase Videojuego con las siguientes características:
        //• Sus atributos son titulo, horas estimadas, entregado, genero y compañia.
        //• Por defecto, las horas estimadas serán de 10 horas y entregado false.
        //El resto de atributos serán valores por defecto según el tipo del atributo.
        protected string titulo;
        protected int horasEstimadas;
        protected bool entregado;
        protected string genero;
        protected string compañia;

        protected const string DEF_TITULO = "";
        protected const int DEF_HORAS_ESTIMADAS = 10;
        protected const bool DEF_ENTREGADO = false;
        protected const string DEF_GENERO = "";
        protected const string DEF_COMPAÑIA = "";

        //Los constructores que se implementaran serán:
        //✓ Un constructor por defecto.
        //✓ Un constructor con el titulo y horas estimadas. El resto por defecto.
        //✓ Un constructor con todos los atributos, excepto de entregado.
        public Videojuego()
        {
            string titulo = DEF_TITULO;
            int horasEstimadas = DEF_HORAS_ESTIMADAS;
            bool entregado = DEF_ENTREGADO;
            string genero = DEF_GENERO;
            string compañia = DEF_COMPAÑIA;
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas= horasEstimadas;
            bool entregado = DEF_ENTREGADO;
            string genero = DEF_GENERO;
            string compañia = DEF_COMPAÑIA;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compañia)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
            entregado = DEF_ENTREGADO;
            this.genero = genero;
            this.compañia = compañia;
        }

        //Los métodos que se implementara serán:
        //• Métodos get de todos los atributos, excepto de entregado.
        //• Métodos set de todos los atributos, excepto de entregado.
        //• Sobrescribe los métodos toString.
        public string GetTitulo() { return titulo; }
        public int GetHorasEstimadas() { return horasEstimadas; }
        public string GetGenero() { return genero; }
        public string GetCompañia() { return compañia; }

        public void SetTitulo(string titulo) { this.titulo = titulo; }
        public void SetHorasEstimadas(int horasEstimadas) { this.horasEstimadas = horasEstimadas; }
        public void SetGenero(string genero) { this.genero = genero; }
        public void SetCompañia(string compañia) { this.compañia = compañia; }

        public string ToString()
        {
            return string.Format("Título: {0} \nHoras estimadas: {1} \nGénero: {2} \nCmpañía: {3} \nEntregado: {4}", titulo, horasEstimadas, genero, compañia, entregado);
        }

        //Implementa los métodos de la interfaz Entregable.
        public void Entregar() { entregado = true; }
        public void Devolver() { entregado = false; }
        public bool IsEntregado() { return entregado; }
        public int CompareTo(Videojuego videojuego)
        {
            if (horasEstimadas > videojuego.GetHorasEstimadas())
            {
                return 1;
            }
            else if (horasEstimadas < videojuego.GetHorasEstimadas())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
