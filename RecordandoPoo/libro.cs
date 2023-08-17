using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_1
{
    internal class libro
    {

        private int ISBN;
        private string titulo;
        private string autor;
        private int numPaginas;
    
        public libro(int isbn, string titulo, string autor, int numPaginas)
        {
            this.ISBN = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.numPaginas = numPaginas;
        }

    }
}
