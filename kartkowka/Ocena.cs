using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kartkowka
{
    internal class ObiektOcena
    {
        int ID { set; get; }
        int Ocena { set; get; }

        public ObiektOcena(int id, int ocena)
        {
            ID = id;
            Ocena = ocena;
        }

        public void Print()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("OCENA: {0}", Ocena);
        }
    }
}
