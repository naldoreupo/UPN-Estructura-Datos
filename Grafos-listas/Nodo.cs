using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos_listas
{
    internal class Nodo // vertice
    {
        public string dato { get; set; }

        public string EsActivo { get; set; }

        public List<Arista> adyacencias { get; set; } //0 1  ... 100

        public Nodo()
        {
            dato = null;
            adyacencias = new List<Arista>();
        }
    }
}
