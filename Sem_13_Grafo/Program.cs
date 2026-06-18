using Biblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_13_Grafo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grafo g = new Grafo(6);
            g.mostrarlista();
            g.LlenarMatriz();
            g.mostrarMatriz();
            g.CrearGrafo();
        }
    }
}
