using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_listas
{
    internal class Grafo
    {
        List<Nodo> nodos = new List<Nodo>();

        public int CantidadNodos;
        public int CantidadAristas;

        public void Agregar(string dato)
        {
            //Crea el nodo
            Nodo nodoNuevo = new Nodo();
            nodoNuevo.dato = dato;

            //Integramos grafo
            nodos.Add(nodoNuevo);

            CantidadNodos++;
        }

        public void eliminar()
        {
            CantidadNodos--;
        }

        public bool Conectar(string datoOrigen,string datoDestrino,int peso )
        {
            //Buscar nodos
            Nodo nodoOrigen = nodos.SingleOrDefault(n => n.dato == datoOrigen);
            Nodo nodoDestino = nodos.SingleOrDefault(n => n.dato == datoDestrino);

            Arista arista = new Arista();
            arista.origen = nodoOrigen;
            arista.Destino = nodoDestino;
            arista.peso = peso;

            if (nodoOrigen == null || nodoDestino == null)
                return false;

            //Conecto
            nodoOrigen.adyacencias.Add(arista);

            CantidadAristas++;

            return true;
        }

        public string ObtenerListaAdyacencias()
        {
            string retonar = "";

            foreach (var nodo in nodos)
            {
                retonar += nodo.dato + "  -> ";

                foreach (var adyacencia in nodo.adyacencias )
                {
                    retonar += adyacencia.Destino.dato +"(" + adyacencia.peso +  ")  -> ";
                }
                retonar += Environment.NewLine;
            }
            
            return retonar;

        }

        public string RecorridoDFS(String datoABuscar)
        {
            string DFS = "";
            List<Nodo> recorrdioDFS = new List<Nodo>();

            Queue<Nodo> cola = new Queue<Nodo>();

            Nodo nodoInicial = nodos.First();

            cola.Enqueue(nodoInicial);

            while (cola.Count() > 0)
            {
                Nodo nodoActual = cola.Dequeue();

                //Validar si el nodo fue procesdo y agregado al recorrdio
                if (recorrdioDFS.Where(n => n.dato == nodoActual.dato).Count() == 0)
                {
                    recorrdioDFS.Add(nodoActual);
                    if (nodoActual.dato == datoABuscar)
                    {
                        break;
                    }          
                }

                foreach (var item in nodoActual.adyacencias)
                {
                    if (recorrdioDFS.Where(n => n.dato == item.Destino.dato).Count() == 0)
                        cola.Enqueue(item.Destino);
                }
            }

            foreach (var item in recorrdioDFS)
            {
                DFS += item.dato + " -> ";
            }

            return DFS;
        }

        public string RecorridoBFS(String datoABuscar)
        {
            string DFS = "";
            List<Nodo> recorrdioDFS = new List<Nodo>();

            Stack<Nodo> cola = new Stack<Nodo>();

            Nodo nodoInicial = nodos.First();

            cola.Push(nodoInicial);

            while (cola.Count() > 0)
            {
                Nodo nodoActual = cola.Pop();

                //Validar si el nodo fue procesdo y agregado al recorrdio
                if (recorrdioDFS.Where(n => n.dato == nodoActual.dato).Count() == 0)
                {
                    recorrdioDFS.Add(nodoActual);
                    if (nodoActual.dato == datoABuscar)
                    {
                        break;
                    }
                }

                foreach (var item in nodoActual.adyacencias)
                {
                    if (recorrdioDFS.Where(n => n.dato == item.Destino.dato).Count() == 0)
                        cola.Push(item.Destino);
                }
            }

            foreach (var item in recorrdioDFS)
            {
                DFS += item.dato + " -> ";
            }

            return DFS;
        }

        //public bool Buscar(string datoBuscar)
        //{

        //}

        public bool Eliminar(string nodoEliminar)
        {
            foreach (var item in nodos)
            {
                Arista adyacenciaAEliminar = item.adyacencias.SingleOrDefault(a => a.Destino.dato == nodoEliminar);
                if (adyacenciaAEliminar != null)
                { item.adyacencias.Remove(adyacenciaAEliminar); }
            }

            Nodo nodo = nodos.Single(n => n.dato == nodoEliminar);
            nodos.Remove(nodo);           

            return true;
        }

        public Dictionary<Nodo, int> ObtenerRutasMinimas(string nodoInicial)
        {
            Dictionary<Nodo, int> pesos = new Dictionary<Nodo, int>(); // Clave -valor , nodo -peso

            // A       B C D F
            // A,0     B,infino  C,infinito  c,infinito C,infinito

            List<Nodo> noVistados = new List<Nodo>();


            ///Funciones lambda
            var nodoOrigen = nodos.SingleOrDefault(nodo => nodo.dato == nodoInicial);

            /*
            foreach (var nodo in nodos)
             {
                 if ( nodo.dato == nodoInicial)
                 {
                     return nodo;
                 }
             }
            */

            pesos[nodoOrigen] = 0;

            foreach (var nodo in nodos) // Inicializando
            {
                if (nodo != nodoOrigen)
                    pesos[nodo] = int.MaxValue;

                noVistados.Add(nodo);
            }

            while (noVistados.Count() > 0)
            {
                Nodo nodoComodin = null;
                bool flag = true;



                foreach (var nodo in noVistados) // Selecionar nodo comodin
                {
                    if (flag || pesos[nodo] < pesos[nodoComodin])
                    {
                        nodoComodin = nodo;
                        flag = false;
                    }

                }

                noVistados.Remove(nodoComodin);

                foreach (var adyacencia in nodoComodin.adyacencias)
                {
                    var medida = pesos[nodoComodin] + adyacencia.peso; // acumulado

                    if( medida < pesos[adyacencia.Destino]) // quedamos con el menor
                    {
                        pesos[adyacencia.Destino] = medida;    
                    }

                }
            }

            return pesos;
        }

    }
}
