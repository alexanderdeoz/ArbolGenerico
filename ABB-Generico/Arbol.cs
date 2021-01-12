using System;
using System.Collections.Generic;
using System.Text;

namespace ABB_Generico
{
   public class Arbol
    {
        public Nodo raiz;
        public Nodo trabajo;
        public int i = 0;

        public Arbol()
        {
            raiz = new Nodo();
        }
        public Nodo Insertar(string pDato, Nodo pNodo)
        {
            // si no hay donde insertar , tomamos como si fuerra riz
            if (pNodo == null)
            {
                raiz = new Nodo();
                raiz.Dato = pDato;

                //no hay hijo
                raiz.Hijo = null;
                // no hay hermano
                raiz.Hermano = null;
                return raiz;
            }
            //verificamos si no tiene hijo
            // insertamos el dato como hijo
            if (pNodo.Hijo == null)
            {
                Nodo temp = new Nodo();
                temp.Dato = pDato;
                // conectamos el nuevo nodo 
                pNodo.hijo = temp;
                return temp;
            }
            else //  ya tiene un hijo tenemos que insertarlo como hermano
            {
                trabajo = pNodo.hijo;
                //avansamos hasta el ultimo
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                // creamos nodo tempora
                Nodo temp = new Nodo();
                temp.Dato = pDato;

                //unimo el temp al ultimo hermano
                trabajo.hermano = temp;
                return temp;
            }
        }
        // transversa preorden 
        public void TransversaPreo(Nodo pNodo)

        {
            if (pNodo == null) 
                return;

            //mreproceso primero a mi 
            for ( int n = 0; n< i ; n++)
                Console.Write("");

            Console.WriteLine(pNodo.Dato);

            // luego proceso a mi hijo
            if (pNodo.Hijo != null)
            {
                í++;
                TransversaPreo(pNodo.Hijo);
                i--;
            }
            // si tengo hermanos los procesos 
            if (pNodo.Hermano != null)
                TransversaPreo(pNodo.Hermano);
        }
    }
}
