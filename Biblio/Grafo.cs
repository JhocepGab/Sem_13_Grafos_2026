using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Grafo
    {
        public int[,] ma;
        public Vertice lista = null;

        public Grafo (int cnt)
        {
            ma = new int[cnt,cnt];
            char l = 'a';
            for (int i = 0; i < cnt; i++)
            {
                insertar(l);
                l++;
            }
        }
        public void insertar(char elemento)
        {
            Vertice nuevo = new Vertice();
            nuevo.dato = elemento;
            if (lista == null)
            {
                lista = nuevo;
            }
            else
            {
                Vertice temp = lista;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public void mostrarlista()
        {
            Vertice temp = lista;
            while (temp != null)
            {
                Console.WriteLine(temp.dato + "->");
                temp = temp.sig;
            }
            Console.WriteLine();
        }
        public void LlenarMatriz()
        {
            Vertice fila = lista;
            for (int i = 0; i<ma.GetLength(0); i++)
            {
                Vertice columna = lista;
                for (int j = 0; j<ma.GetLength(1); j++)
                {
                    Console.Write($"[{fila.dato}.{columna.dato}]: ");
                    int val = int.Parse(Console.ReadLine());
                    ma[i,j] = val;
                    columna = columna.sig;
                }
                fila = fila.sig;
            }
        }
        public void mostrarMatriz()
        {
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                for (int j = 0; j<ma.GetLength(1); j++)
                {
                    Console.Write(ma[i, j] + " ");
                }
                Console.WriteLine() ;
            }
        }
        public void CrearGrafo()
        {
            Console.Write("ingrese la cantidad de vertices: ");
            int nuvertices = int.Parse(Console.ReadLine());
            ma = new int[nuvertices,nuvertices];

            lista = null;
            Vertice actual = null;

            Console.WriteLine("Ingreso de vertice");
            for (int i = 0; i < nuvertices;i++)
            {
                Vertice nuevo = new Vertice();
                Console.Write($"Dato del vertice {i + 1}: ");
                nuevo.dato = char.Parse(Console.ReadLine());
                nuevo.sig = null;

                if (lista == null)
                {
                    lista = nuevo;
                    actual = nuevo;
                }
                else
                {
                    actual.sig = nuevo;
                    actual = nuevo;
                }
            }
        }
    }
}
