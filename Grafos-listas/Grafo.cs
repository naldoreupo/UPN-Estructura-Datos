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

        public void Conectar(string datoOrigen,string datoDestrino)
        {
            //Buscar nodos
            Nodo nodoOrigen = nodos.Single(n => n.dato == datoOrigen);
            Nodo nodoDestino = nodos.Single(n => n.dato == datoDestrino);

            //Conecto
            nodoOrigen.adyacencias.Add(nodoDestino);
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
    }
}
