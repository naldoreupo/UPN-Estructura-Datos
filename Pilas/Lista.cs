using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Lista
    {
        Nodo Tope;

        public void Apilar(int dato)
        {
            Nodo nodo = new Nodo();
            nodo.dato = dato;


            if (Tope == null)
            {
                Tope = nodo;
            }
            else
            {
                nodo.siguiente = Tope;
                Tope = nodo;
            }
        }


        public string mostrar()
        {
            Nodo nodo = Tope;
            string retorno = "";

            while( nodo != null)
            {
                retorno += nodo.dato + Environment.NewLine;
                nodo = nodo.siguiente;
            }

            return retorno;
        }
    }
}
