using System;

namespace ABB_Generico
{
    public class Nodo
    {
        public string dato;
        public Nodo hijo;
        public Nodo hermano;
        public string Dato { get => dato; set => dato = value;}
        public Nodo Hijo{ get => hijo; set => hijo = value; }
        public Nodo Hermano { get => hermano; set => hermano = value;}


        public Nodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
