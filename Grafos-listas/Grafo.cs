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

        public void Agregar(string dato)
        {
            //Crea el nodo
            Nodo nodoNuevo = new Nodo();
            nodoNuevo.dato = dato;

            //Integramos grafo
            nodos.Add(nodoNuevo); 
        }

        public bool Conectar(string datoOrigen,string datoDestrino)
        {
            //Buscar nodos
            Nodo nodoOrigen = nodos.SingleOrDefault(n => n.dato == datoOrigen);
            Nodo nodoDestino = nodos.SingleOrDefault(n => n.dato == datoDestrino);

            if (nodoOrigen == null || nodoDestino == null)
                return false;

            //Conecto
            nodoOrigen.adyacencias.Add(nodoDestino);

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
                    retonar += adyacencia.dato + "  -> ";
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
                    if (recorrdioDFS.Where(n => n.dato == item.dato).Count() == 0)
                        cola.Enqueue(item);
                }
            }

            foreach (var item in recorrdioDFS)
            {
                DFS += item.dato + " -> ";
            }

            return DFS;
        }
    }
}
