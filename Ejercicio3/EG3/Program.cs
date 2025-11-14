using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG3
{
    class Nodo
    {
        public int dato;
        public Nodo izquierdo;
        public Nodo derecho;

        public Nodo(int valor)
        {
            dato = valor;
            izquierdo = null;
            derecho = null;
        }
    }

    class ArbolBinarioBusqueda
    {
        public Nodo raiz;

        public ArbolBinarioBusqueda()
        {
            raiz = null;
        }

        // Insertar un valor en el árbol (automáticamente en su posición)
        public Nodo Insertar(Nodo nodo, int valor)
        {
            if (nodo == null)
                return new Nodo(valor);

            if (valor < nodo.dato)
                nodo.izquierdo = Insertar(nodo.izquierdo, valor);
            else if (valor > nodo.dato)
                nodo.derecho = Insertar(nodo.derecho, valor);
            else
                Console.WriteLine("Valor duplicado, no se insertará.");

            return nodo;
        }

        // Crear el árbol pidiendo los datos al usuario
        public void CrearArbol()
        {
            Console.WriteLine("Ingrese los valores del árbol (-1 para terminar):");
            while (true)
            {
                Console.Write("Valor: ");
                int valor;
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Entrada inválida, intente de nuevo.");
                    continue;
                }

                if (valor == -1)
                    break;

                raiz = Insertar(raiz, valor);
            }
        }

        // Recorrido postorden (Izquierdo - Derecho - Raíz)
        public void Postorden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Postorden(nodo.izquierdo);
            Postorden(nodo.derecho);
            Console.Write(nodo.dato + " ");
        }

        // Sumar todos los valores del árbol
        public int SumarValores(Nodo nodo)
        {
            if (nodo == null)
                return 0;
            return nodo.dato + SumarValores(nodo.izquierdo) + SumarValores(nodo.derecho);
        }

        // Contar pares e impares
        public void ContarParesImpares(Nodo nodo, ref int pares, ref int impares)
        {
            if (nodo == null)
                return;

            if (nodo.dato % 2 == 0)
                pares++;
            else
                impares++;

            ContarParesImpares(nodo.izquierdo, ref pares, ref impares);
            ContarParesImpares(nodo.derecho, ref pares, ref impares);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();

            Console.WriteLine("Creación del árbol binario de búsqueda");
            arbol.CrearArbol();

            Console.WriteLine("\nRecorrido postorden");
            arbol.Postorden(arbol.raiz);
            Console.WriteLine();

            int suma = arbol.SumarValores(arbol.raiz);
            Console.WriteLine($"\nSuma total de los valores: {suma}");

            int pares = 0, impares = 0;
            arbol.ContarParesImpares(arbol.raiz, ref pares, ref impares);
            Console.WriteLine($"Cantidad de nodos pares: {pares}");
            Console.WriteLine($"Cantidad de nodos impares: {impares}");

            Console.WriteLine("\nPresione cualquier tecla para salir del programa");
            Console.ReadKey();
        }
    }
}
