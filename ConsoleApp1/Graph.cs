using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vertex
    {
        public char label;
        public bool wasVisited;
        public Vertex(char label)
        {
            this.label = label;
            this.wasVisited = false;
        }
    }
    class Graph
    {
        private const int MAX_VERTS = 20;
        private Vertex[] VertexList;
        private int[,] AdjMatrix;
        private int nVerts;
        public Graph()
        {
            this.VertexList = new Vertex[MAX_VERTS];
            this.AdjMatrix = new int[MAX_VERTS, MAX_VERTS];
            this.nVerts = 0;
            for (int i = 0; i < MAX_VERTS; i++)
            {
                for (int j = 0; j < MAX_VERTS; j++)
                {
                    AdjMatrix[i, j] = 0;
                }
            }
        }
        public void AddVertex(char lbl)
        {
            VertexList[nVerts++] = new Vertex(lbl);
        }
        public void AddEdge(int start, int end)
        {
            AdjMatrix[start, end] = 1;
            AdjMatrix[end, start] = 1;
        }
        public void DisplayVertex(int index)
        {
            Console.WriteLine(VertexList[index].label);
        }
    }
}
