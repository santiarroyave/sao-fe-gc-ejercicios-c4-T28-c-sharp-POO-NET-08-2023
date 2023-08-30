using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Serie
    {
        //Crearemos una clase llamada Serie con las siguientes características:
        //• Sus atributos son titulo, numero de temporadas, entregado, genero y creador.
        //• Por defecto, el numero de temporadas es de 3 temporadas y entregado false.
        //El resto de atributos serán valores por defecto según el tipo del atributo.
        protected string titulo;
        protected int numeroTemporadas;
        protected bool entregado;
        protected string genero;
        protected string creador;

        protected const string DEF_TITULO = "";
        protected const int DEF_NUM_TEMPORADAS = 3;
        protected const bool DEF_ENTREGADO = false;
        protected const string DEF_GENRO = "";
        protected const string DEF_CREADOR = "";

        //Los constructores que se implementaran serán:
        //✓ Un constructor por defecto.
        //✓ Un constructor con el titulo y creador. El resto por defecto.
        //✓ Un constructor con todos los atributos, excepto de entregado.
        public Serie()
        {
            titulo = DEF_TITULO;
            numeroTemporadas = DEF_NUM_TEMPORADAS;
            entregado = DEF_ENTREGADO;
            genero = DEF_GENRO;
            creador = DEF_CREADOR;
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            numeroTemporadas = DEF_NUM_TEMPORADAS;
            entregado = DEF_ENTREGADO;
            genero = DEF_GENRO;
            this.creador = creador;
        }

        public Serie(string titulo, int numeroTemporadas, string genero, string creador)
        {
            this.titulo= titulo;
            this.numeroTemporadas= numeroTemporadas;
            entregado = DEF_ENTREGADO;
            this.genero = genero;
            this.creador = creador;
        }

        //Los métodos que se implementara serán:
        //• Métodos get de todos los atributos, excepto de entregado.
        //• Métodos set de todos los atributos, excepto de entregado.
        //• Sobrescribe los métodos toString.
        public string GetTitulo() { return titulo; }
        public int GetNumeroTemporadas() {  return numeroTemporadas; }
        public string GetGenero() { return genero; }
        public string GetCreador() { return creador; }

        public void SetTitulo(string titulo) { this.titulo = titulo; }
        public void SetNumeroTemporadas(int numeroTemporadas) { this.numeroTemporadas = numeroTemporadas; }
        public void SetGenero(string genero) { this.genero = genero; }
        public void SetCreador(string creador) { this.creador = creador; }

        public string ToString()
        {
            return string.Format("Título: {0} \nCreador: {1} \nNúmero de temporadas: {2} \nGénero: {3} \nEntregado: {4}", titulo, creador, numeroTemporadas, genero, entregado);
        }

        //Implementa los métodos de la interfaz Entregable.
        public void Entregar() { entregado = true; }
        public void Devolver() { entregado = false; }
        public bool IsEntregado() { return entregado; }
        public int CompareTo(Serie serie)
        {
            if (numeroTemporadas > serie.GetNumeroTemporadas())
            {
                return 1;
            }
            else if (numeroTemporadas < serie.GetNumeroTemporadas())
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
