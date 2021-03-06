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
        public String preorder;
        public String postOrder;
        public String Formato;

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

        //public void AgregarConObjeto(Empleado dato)  //verbos ar er
        //{
        //    //Creacion nodo
        //    Nodo nodo = new Nodo();
        //    nodo.dato = dato;


        //    if (raiz == null) // SI est vacion
        //    {
        //        raiz = nodo;
        //    }
        //    else
        //    {
        //        Nodo nodoRecorrido = raiz; // Recorremos empiza LA RAIZ
        //        Nodo nodoDisponible = null;

        //        // Identificar nodo a insertar nodo
        //        while (nodoRecorrido != null)  //for 
        //        {
        //            nodoDisponible = nodoRecorrido;
        //            if (dato.DNI == nodoRecorrido.dato.DNI) // Evitar repetido
        //            {
        //                return;//sale de la funcion
        //            }
        //            else if (string.Compare(dato.DNI, nodoRecorrido.dato.DNI) == -1)
        //            {
        //                nodoRecorrido = nodoRecorrido.Izquierdo;
        //            }
        //            else
        //            {
        //                nodoRecorrido = nodoRecorrido.Derecho;
        //            }
        //        }

        //        // TEMP padre de nuestro nuevo padre
        //        if (string.Compare(dato.DNI, nodoDisponible.dato.DNI) == -1)
        //        {
        //            nodoDisponible.Izquierdo = nodo;
        //        }
        //        else
        //        {
        //            nodoDisponible.Derecho = nodo;
        //        }
        //    }
        //}

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

        public void RecorrerPreOrder(Nodo nodo) // funcion recursiva otra forma de recorre
        {
            //string inorder = "";

            if (nodo != null)
            {
                preorder += nodo.dato + " ->";

                RecorrerPreOrder(nodo.Izquierdo);

                RecorrerPreOrder(nodo.Derecho);
            }
        }

        public void RecorrerPostOrder(Nodo nodo) // funcion recursiva otra forma de recorre
        {

            if (nodo != null)
            {
                RecorrerPostOrder(nodo.Izquierdo);

                RecorrerPostOrder(nodo.Derecho);

                postOrder += nodo.dato + " ->";
            }
        }

        public void RecorreFormato(Nodo nodo)
        {

            if( nodo != null)
            {
                if(nodo.Izquierdo != null )
                    Formato += nodo.dato + " ->"  + nodo.Izquierdo.dato + Environment.NewLine ;

                if (nodo.Derecho != null)
                    Formato += nodo.dato + " ->" + nodo.Derecho.dato + Environment.NewLine;

                RecorreFormato(nodo.Izquierdo);

                RecorreFormato(nodo.Derecho);
            }
        }


        //Recorrido

        /// Do while for foreach
        /// recursividad


        public bool Buscar(int datoABuscar )
        {
            Nodo nodo = raiz;

            while (nodo != null )
            {
                if(nodo.dato == datoABuscar) //hizo match
                {
                    return true;
                }

                if ( datoABuscar < nodo.dato)
                {
                    nodo = nodo.Izquierdo;
                 
                }
                else
                {
                    nodo = nodo.Derecho;
                }   
            }

            return false;
        }


        public bool Eliminar(int dato)
        {
            Nodo nodoAElimar = raiz;
            Nodo nodoPadre = null;
            Boolean EsIzquierda = false;

            //busqueda
            while (nodoAElimar !=  null && nodoAElimar.dato != dato )
            {
                nodoPadre = nodoAElimar;
                if(dato < nodoAElimar.dato)
                {
                    nodoAElimar = nodoAElimar.Izquierdo;
                    EsIzquierda = true;
                }
                else
                {
                    nodoAElimar = nodoAElimar.Derecho;
                    EsIzquierda = false;
                }
            }
            if( nodoAElimar == null)
            {
                return false;
            }


            ///Caso 1
            if ( nodoAElimar.Izquierdo == null && nodoAElimar.Derecho==null)
            {
                if(nodoAElimar == raiz)
                {
                    raiz = null;
                }
                if (EsIzquierda)
                {
                    nodoPadre.Izquierdo = null;
                }
                else
                {
                    nodoPadre.Derecho = null;
                }
            }
            // Caso 2
            else if(nodoAElimar.Derecho == null) // Izquieda tgiene datos
            {
                if(nodoAElimar == raiz)
                {
                    raiz = raiz.Izquierdo;
                }
                if (EsIzquierda)
                {
                    nodoPadre.Izquierdo = nodoAElimar.Izquierdo;
                }
                else
                {
                    nodoPadre.Derecho = nodoAElimar.Izquierdo;
                }
            }
            // caso 2
            else if (nodoAElimar.Izquierdo ==null) // Derehco datos
            {
                if (nodoAElimar == raiz)
                {
                    raiz = raiz.Derecho;
                }
                if (EsIzquierda)
                {
                    nodoPadre.Izquierdo = nodoAElimar.Derecho;
                }
                else
                {
                    nodoPadre.Derecho = nodoAElimar.Derecho;
                }

            }
            //Cas 3
            else {

                Nodo nodoReemplazo = ObtnerNodoReemplazoDeSubArbolDerecho(nodoAElimar);


                if( nodoAElimar == raiz)
                {
                    raiz = nodoReemplazo;
                }

                if (EsIzquierda)
                {
                    nodoPadre.Izquierdo = nodoReemplazo;
                }
                else
                {
                    nodoPadre.Derecho = nodoReemplazo;
                }

                nodoReemplazo.Izquierdo = nodoAElimar.Izquierdo;
            }



            return true;
        }

        private Nodo ObtnerNodoReemplazoDeSubArbolDerecho(Nodo nodoEliminar)
        {
            Nodo nodoAuxiliar = nodoEliminar.Derecho;
            Nodo reemplazo = nodoEliminar;
            Nodo reemplazopadre = nodoEliminar;

            while (nodoAuxiliar != null)
            {
                reemplazopadre = reemplazo;
                reemplazo = nodoAuxiliar;
                nodoAuxiliar = nodoAuxiliar.Izquierdo;
            }

            if ( reemplazo != nodoEliminar.Derecho)
            {
                reemplazopadre.Izquierdo = reemplazo.Derecho;
                reemplazo.Derecho = nodoEliminar.Derecho;
            }

            return reemplazo;
        }

    }
}
