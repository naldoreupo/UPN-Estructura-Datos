using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila_sin_libreria
{
    internal class Pila
    {
        Nodo Tope;

        public void Apilar(string dato) //Push
        {
            //creamos nodo
            Nodo nodo = new Nodo();
            nodo.dato = dato;

           
            if (Tope == null) // si la pila esta vacia
            {
                Tope = nodo;
            }
            else
            {
                nodo.siguiente = Tope;
                Tope = nodo;
            }   
        }

        public string Mostrar()
        {
            string retorno = string.Empty;
            Nodo nodo = Tope;


            while (nodo != null)
            {
                retorno += nodo.dato + Environment.NewLine;
                nodo = nodo.siguiente;
            }

            return retorno;
        }

        public string Desapilar()
        {
            string dato = Tope.dato;

            Tope = Tope.siguiente;

            return dato;
        }

        ///peek -- extraer
        ///
        public string extraer()

        {
            string dato = Tope.dato;

            return dato;

        }



    }
}
