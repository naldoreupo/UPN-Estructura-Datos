using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Simples
{
    internal class Lista
    {
        Nodo Inicio, Fin;

        public void Agregar(int dato)
        {
            Nodo nodo = new Nodo();
            nodo.dato = dato;

            if ( Inicio == null)
            {
                Inicio = nodo;
                Fin = nodo;
            }
            else
            {
                Fin.siguiente = nodo;
                Fin = nodo;
            }
        }

        public string Mostrar()
        {
            Nodo temp = Inicio;
            string datos = string.Empty;


            while(temp != null)
            {
                datos += temp.dato + Environment.NewLine;

                temp = temp.siguiente;
            }


            return datos;
        }
    }
}
