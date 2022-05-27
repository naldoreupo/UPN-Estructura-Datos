using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_doble_enlazadas
{
    internal class Lista
    {
        Nodo Inicio;
        Nodo Fin;

        public void Agregar(int dato)
        {
            //Creacion nodo
            Nodo nodo = new Nodo();
            nodo.dato = dato;

            if (Inicio == null) //Si la lista esta  vacia
            {
                Inicio = nodo;
                Fin = nodo;
            }
            else //Tiene elementos
            {
                Fin.siguiente = nodo;
                nodo.anterior = Fin;
                Fin = nodo;
            }
        }



        public string Mostrar()
        {
            string retorno = string.Empty;

            Nodo nodo = Inicio;

            while(nodo != null)
            {
                retorno += nodo.dato.ToString() + Environment.NewLine ;
                nodo = nodo.siguiente;
            }

            return retorno;
        }

        public string MostrarInversa()
        {

            string retorno = string.Empty;
            Nodo nodo = Fin;

            while(nodo != null)
            {
                retorno += nodo.dato.ToString() + Environment.NewLine;
                nodo = nodo.anterior;
            }

            return retorno;

        }


    }
}

