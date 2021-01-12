using System;
using ABB_Generico;
namespace ABB_Cls
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            Nodo raiz = arbol.Insertar("a", null);

            arbol.Insertar("b",raiz);
            arbol.Insertar("c",raiz);
            arbol.TransversaPreo(raiz);
        }
    }
}
