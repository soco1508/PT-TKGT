using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class ColoringGraph
    {
        public List<Vertex> Graph = new List<Vertex>();
        public List<Vertex> Greedy(List<Vertex> G)
        {
            List<Vertex> Newclr = new List<Vertex>();
            foreach (var v in G) 
            {
                if (v.Mau == 0)
                {
                    if (CheckDinhKe(v.Dinh, Newclr))
                        Newclr.Add(v);
                }
            }
            return Newclr;
        }
        public int _ColoringGraph(List<Vertex> G)
        {
            List<Vertex> C = new List<Vertex>();
            int N = 1;
            while (G.Count > 0)
            {
                C = Greedy(G);
                foreach (var v in C)
                {
                    v.Mau = N;
                    G.Remove(v);
                }                
                N++;
                Graph.AddRange(C);
            }
            Graph = Graph.OrderBy(g => g.Dinh).ToList();
            return N - 1;
        }
        public bool CheckDinhKe(int Dinh, List<Vertex> Newclr)
        {
            foreach (var v in Newclr) 
            {
                foreach (int i in v.DinhKe) 
                {
                    if (Dinh == i) return false; 
                }
            }
            return true;
        }
    }
    public class Vertex
    {
        public int Dinh { get; set; }
        public int Mau { get; set; }
        public List<int> DinhKe { get; set; }
        public Vertex(int Dinh)
        {
            this.Dinh = Dinh;
            Mau = 0;
            DinhKe = new List<int>();
        }
        public Vertex()
        {
            Mau = 0;
            DinhKe = new List<int>();
        }
    }
}
