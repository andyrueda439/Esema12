using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG2
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

        // Crear el árbol pidiendo datos al usuario
        public Nodo CrearArbol()
        {
            Console.Write("Ingrese un número (-1 para nulo): ");
            int valor = int.Parse(Console.ReadLine());

            if (valor == -1)
                return null;

            Nodo nuevo = new Nodo(valor);

            Console.WriteLine($"Ingrese el hijo izquierdo de {valor}:");
            nuevo.izquierdo = CrearArbol();

            Console.WriteLine($"Ingrese el hijo derecho de {valor}:");
            nuevo.derecho = CrearArbol();

            return nuevo;
        }

        // Recorridos
        public void Inorden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Inorden(nodo.izquierdo);
            Console.Write(nodo.dato + " ");
            Inorden(nodo.derecho);
        }

        public void Preorden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Console.Write(nodo.dato + " ");
            Preorden(nodo.izquierdo);
            Preorden(nodo.derecho);
        }

        public void Postorden(Nodo nodo)
        {
            if (nodo == null)
                return;

            Postorden(nodo.izquierdo);
            Postorden(nodo.derecho);
            Console.Write(nodo.dato + " ");
        }

        // Función para crear el espejo del árbol
        public Nodo Espejo(Nodo nodo)
        {
            if (nodo == null)
                return null;

            Nodo nuevo = new Nodo(nodo.dato);
            nuevo.izquierdo = Espejo(nodo.derecho);
            nuevo.derecho = Espejo(nodo.izquierdo);
            return nuevo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            Console.WriteLine("Creación del árbol binario");
            arbol.raiz = arbol.CrearArbol();

            Console.WriteLine("\nRecorridos del árbol original");
            Console.Write("Inorden: ");
            arbol.Inorden(arbol.raiz);
            Console.WriteLine();

            Console.Write("Preorden: ");
            arbol.Preorden(arbol.raiz);
            Console.WriteLine();

            Console.Write("Postorden: ");
            arbol.Postorden(arbol.raiz);
            Console.WriteLine();

            // Crear el árbol espejo
            Nodo espejo = arbol.Espejo(arbol.raiz);

            Console.WriteLine("\nRecorridos del árbol espejo");
            Console.Write("Inorden: ");
            arbol.Inorden(espejo);
            Console.WriteLine();

            Console.Write("Preorden: ");
            arbol.Preorden(espejo);
            Console.WriteLine();

            Console.Write("Postorden: ");
            arbol.Postorden(espejo);
            Console.WriteLine();

            Console.WriteLine("\nPresione cualquier tecla para salir del programa :/");
            Console.ReadKey();
        }
    }
}
