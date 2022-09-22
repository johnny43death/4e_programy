using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartkowka
{
    internal class ListaOcen
    {
        private IList<ListaOcen> listaOcen;

        public ListaOcen()
        {
            listaOcen = new List<ListaOcen>();
        }

        public ListaOcen PrintGradesFor(int ocena) 
        {
            foreach (ocena in listaOcen)
            {
                ocena.Print()
            }
        }
    }
}
