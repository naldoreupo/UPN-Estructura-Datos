using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_binario
{
    internal class ArbolBinarioBusqueda //Sustantivos
    {
        public Nodo raiz;
        public String inorder;

        public void Agregar(int dato)  //verbos ar er
        {
            //Creacion nodo
            Nodo nodo = new Nodo();
            nodo.dato = dato;


            if (raiz == null) // SI est vacion
            {
                raiz = nodo;
            }
            else
            {
                Nodo nodoRecorrido = raiz; // Recorremos empiza LA RAIZ
                Nodo nodoDisponible = null; 

                // Identificar nodo a insertar nodo
                while (nodoRecorrido != null)  //for 
                {
                    nodoDisponible = nodoRecorrido;
                    if (dato == nodoRecorrido.dato) // Evitar repetido
                    {
                        return;//sale de la funcion
                    }
                    else if (dato < nodoRecorrido.dato)
                    {
                        nodoRecorrido = nodoRecorrido.Izquierdo;
                    }
                    else
                    {
                        nodoRecorrido = nodoRecorrido.Derecho;
                    }
                }

                // TEMP padre de nuestro nuevo padre
                if (dato < nodoDisponible.dato)
                {
                    nodoDisponible.Izquierdo = nodo;
                }
                else
                {
                    nodoDisponible.Derecho = nodo;
                }    
            }
        }

        //InOrder Izquierda - raiz - derecha
        public void RecorrerInOrder(Nodo nodo) // funcion recursiva otra forma de recorre
        {
            //string inorder = "";

            if (nodo != null)
            {   
                RecorrerInOrder(nodo.Izquierdo);

                inorder += nodo.dato + " ->";

                RecorrerInOrder(nodo.Derecho);
            }
        }
    }
}
