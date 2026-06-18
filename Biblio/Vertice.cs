using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Vertice
    {
        public char dato;
        public Vertice sig;
        public List<Vertice> arista = new List<Vertice>();
    }
}
