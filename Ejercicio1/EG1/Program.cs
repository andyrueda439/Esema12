using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EG1
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

    class ArbolBinario
    {
        public Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        // Función para crear el árbol pidiendo datos al usuario
        public Nodo CrearArbol()
        {
            Console.Write("Ingrese un número (o deje vacío para nulo): ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrEmpty(entrada))
                return null;

            int valor = int.Parse(entrada);
            Nodo nuevo = new Nodo(valor);

            Console.WriteLine($"Ingrese el hijo izquierdo de {valor}:");
            nuevo.izquierdo = CrearArbol();

            Console.WriteLine($"Ingrese el hijo derecho de {valor}:");
            nuevo.derecho = CrearArbol();

            return nuevo;
        }

        // Recorrido en preorden: Raíz → Izquierdo → Derecho
        public void Preorden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Console.Write(nodo.dato + " ");
            Preorden(nodo.izquierdo);
            Preorden(nodo.derecho);
        }

        // Función recursiva para contar los nodos
        public int ContarNodos(Nodo nodo)
        {
            if (nodo == null)
                return 0;

            return 1 + ContarNodos(nodo.izquierdo) + ContarNodos(nodo.derecho);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            Console.WriteLine("Creación del árbol binario");
            arbol.raiz = arbol.CrearArbol();

            Console.WriteLine("\nRecorrido en preorden :0");
            arbol.Preorden(arbol.raiz);

            int cantidad = arbol.ContarNodos(arbol.raiz);
            Console.WriteLine($"\n\nCantidad total de nodos: {cantidad}");

            Console.WriteLine("\nPresione cualquier tecla para salir del programa :)...");
            Console.ReadKey();
        }
    }
}
