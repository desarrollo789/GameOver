using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraffoSolution
{
    public class Grafoheurustico
    {
        public List<Nodoh> Nodos { get; set; }
        public Grafoheurustico()
        {
            Nodos = new List<Nodoh>();
        }
        public void NuevoNodo(string estado, int heuristica)
        {
            Nodos.Add(new Nodoh()
            {
                Estado = estado,
                Heuristica = heuristica
            });
        }
        public void AgregarArco(string eOrigen, string eDestino, int costo)
        {
            foreach (Nodoh nodo in Nodos)
            {
                if (nodo.Estado == eOrigen)
                {
                    nodo.SubNodos.Add(new Subnodo()
                    {
                        Costo = costo,
                        ArcoNodo = eDestino
                    });
                    break;
                }
            }
        }
        public List<Nodoh> ObtenerVecinos(string estado, List<string> explorados)
        {
            List<Nodoh> vecinosResp = new List<Nodoh>();
            List<Subnodo> vecinos = new List<Subnodo>();
            foreach (Nodoh nodo in Nodos)
            {
                if (nodo.Estado == estado)
                {
                    vecinos = nodo.SubNodos;
                }
            }
            foreach (Subnodo sbn in vecinos)
            {
                if (!explorados.Contains(sbn.ArcoNodo))
                {
                    vecinosResp.Add(getNodo(sbn.ArcoNodo));
                }
            }
            return vecinosResp;

        }
        public Nodoh getNodo(string estado)
        {
            Nodoh nodo = new Nodoh();
            foreach (Nodoh nod in Nodos)
            {
                if (nod.Estado == estado)
                {
                    nodo = nod;
                    break;
                }
            }
            return nodo;
        }
        public List<NodoCosto> getVecinosCosto(string estado, int acum, List<string> explorados)
        {
            Nodoh nodo = getNodo(estado);
            List<NodoCosto> costos = new List<NodoCosto>();
            foreach (var subN in nodo.SubNodos)
            {
                if (!explorados.Contains(subN.ArcoNodo))
                {
                    costos.Add(new NodoCosto()
                    {
                        Costo = (acum + subN.Costo) + getNodo(subN.ArcoNodo).Heuristica,
                        Nodo = subN.ArcoNodo,
                        ArcCosto = subN.Costo
                    });
                }

            }
            return costos;
        }
        public NodoCosto ObtenerVecinoMenorCosto(string estado, int acum, List<string> explorados)
        {
            List<NodoCosto> costos = getVecinosCosto(estado, acum, explorados);
            NodoCosto minimo = new NodoCosto();
            minimo.Costo = costos[0].Costo;
            foreach (var costo in costos)
            {
                if (costo.Costo < minimo.Costo)
                {
                    minimo = costo;
                }
            }
            return minimo;
        }
    }
    public class Nodoh
    {
        public string Estado { get; set; }
        public int Heuristica { get; set; }
        public List<Subnodo> SubNodos { get; set; }
        public Nodoh()
        {
            SubNodos = new List<Subnodo>();
        }
    }


    public class Subnodo
    {
        public int Costo { get; set; }
        public string ArcoNodo { get; set; }
    }
}
