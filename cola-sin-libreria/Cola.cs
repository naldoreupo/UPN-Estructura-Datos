using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cola_sin_libreria
{
    internal class Cola
    {
        Nodo Final;//Agregar
        Nodo Inicio; //Eliminar y extrae
        int contador = 0;
        public void Encolar(int dato)
        {
            if (contador > 10)
            {
                //creacion del nodo
                Nodo nodo = new Nodo();
                nodo.dato = dato;

                if (Inicio == null) //Cola este vacia
                {
                    Inicio = nodo;
                    Final = nodo;
                }
                else // Cola tiene elementos
                {
                    Final.siguiente = nodo;
                    Final = nodo;
                }
            }
            contador++;

        }

        public string Mostrar()
        {
            String retorno = "";
            Nodo nodo = Inicio;


            while (nodo !=null) // Recorriendo cola
            {
                retorno += nodo.dato + Environment.NewLine;
                nodo = nodo.siguiente;
            }

            return retorno;
        }

        public string Desencolar()
        {
            string retorno = Inicio.dato.ToString();

            Inicio = Inicio.siguiente;

            contador--;

            return retorno;                
        }

        public string Extraer() //Peek
        {
            string dato = Inicio.dato.ToString();

            return dato;
        }

    }
}
