using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Libro
    {
        //Crear una clase Libro que contenga los siguientes atributos:
        //• ISBN
        //• Titulo
        //• Autor
        //• Número de páginas
        private string isbn;
        private string titulo;
        private string autor;
        private int numPaginas;

        //Crear sus respectivos métodos get y set correspondientes para cada atributo.
        public string GetIsbn() { return isbn; }
        public string GetTitulo() { return titulo; }
        public string GetAutor() { return autor; }
        public int GetNumPaginas() { return numPaginas; }

        public void SetIsbn(string isbn) { this.isbn = isbn; }
        public void SetTitulo(string titulo) { this.titulo = titulo; }
        public void SetAutor(string autor) { this.autor = autor; }
        public void SetNumPaginas(int numPaginas) { this.numPaginas = numPaginas; }

        //Crear el método toString() para mostrar la información relativa al libro con el siguiente formato: “El libro con ISBN creado por el autor tiene páginas”
        public void ToString()
        {
            Console.WriteLine($"El libro {titulo} con ISBN {isbn} creado por el autor {autor} tiene {numPaginas} páginas.");
        }

    }
}
