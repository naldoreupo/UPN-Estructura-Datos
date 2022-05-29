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
        public int cantidad;
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

            //hACIENDO LA LISTA CIRCULAR DOBLE
            Fin.siguiente = Inicio;
            Inicio.anterior = Fin;

            cantidad++;
        }

        public string Mostrar()
        {
            string retorno = string.Empty;

            Nodo nodo = Inicio;

            // DO - WHILE
            do
            {
                retorno += nodo.dato.ToString() + Environment.NewLine;
                nodo = nodo.siguiente;
            } while (nodo != Inicio);

            return retorno;
        }

        public string MostrarInversa()
        {

              string retorno = string.Empty;
              Nodo nodo = Fin;

            do
            {
                retorno += nodo.dato.ToString() + Environment.NewLine;
                nodo = nodo.anterior;
            } while (nodo != Fin);

            /*while(nodo != null)
            {
                retorno += nodo.dato.ToString() + Environment.NewLine;
                nodo = nodo.anterior;
            }*/

            return retorno;
        }

        public bool Buscar(int datoABuscar)
        {
            Nodo nodo = Inicio;

            // DO - WHILE
            do
            {
                if(nodo.dato == datoABuscar )
                {
                    return true;
                }               
                nodo = nodo.siguiente;
            } while (nodo != Inicio);

            return false;

            /* for (int i = 0; i <= datocount - 1, i++)
             {

                 if ()

             }*/

        }

        public void EliminarUltimo()
        {
            Inicio.anterior = Fin.anterior;
            Fin.anterior.siguiente= Inicio;
            Fin = Fin.anterior;

            cantidad--;

        }
    }
}

