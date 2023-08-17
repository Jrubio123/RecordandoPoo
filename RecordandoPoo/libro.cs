using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_1
{
    internal class libro
    {
        //atributos
        private int ISBN;
        private string titulo;
        private string autor;
        private int numPaginas;
    

        //constructores
        public libro(int isbn, string titulo, string autor, int numPaginas)
        {
            this.ISBN = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.numPaginas = numPaginas;
        }

        //metodos
        public int GetISBN()
        {
            return ISBN;
        }

        public void SetISBN(int isbn)
        {
            ISBN = isbn;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetAutor()
        {
            return autor;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public int GetNumPaginas()
        {
            return numPaginas;
        }

        public void SetNumPaginas(int numPaginas)
        {
            this.numPaginas = numPaginas;
        }


        public override string ToString()
        {
            return $"El libro {titulo} con ISBN {ISBN} creado por el autor {autor} tiene {numPaginas} páginas.";
        }

    }
}
