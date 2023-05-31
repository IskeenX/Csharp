using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class GraphNode<TLabel, TData>
    {
        public TLabel Label { get; set; }
        public TData Data { get; set; }
        public List<GraphNode<TLabel, TData>> Neighborhood { get; set; }
    }

    class Graph<TLabel, TData>
    {
        List<GraphNode<TLabel, TData>> nodes  = new List<GraphNode<TLabel, TData>>();

        public void AddNode(TLabel label, TData data)
        {
            GraphNode<TLabel, TData> newNode = new GraphNode<TLabel, TData>
            {
                Label = label,
                Data = data,
                Neighborhood = new List<GraphNode<TLabel, TData>>()
            };
            nodes.Add(newNode);
        }
        private GraphNode<TLabel, TData> LabelToNode(TLabel name)
        {
            foreach (var n in nodes)
            {
                if(n.Label.Equals(name))
                {
                    return n;
                }
            }
            throw new Exception("No such label in the graph!");
        }

        public void AddUndirectedEdge(TLabel from, TLabel to)
        {
            GraphNode<TLabel, TData> fromNode = LabelToNode(from);
            GraphNode<TLabel, TData> toNode = LabelToNode(to);

            fromNode.Neighborhood.Add(toNode);
            toNode.Neighborhood.Add(fromNode);
        }

        public void FindPath(TLabel source, TLabel target)
        {
            GraphNode<TLabel, TData> sourceNode = LabelToNode(source);
            GraphNode<TLabel, TData> targetNode = LabelToNode(target);

            Queue<GraphNode<TLabel, TData>> Q = new Queue<GraphNode<TLabel, TData>>(); //Nodes to be visited
            List<GraphNode<TLabel, TData>> V = new List<GraphNode<TLabel, TData>>(); //Nodes already visited
            Q.Enqueue(sourceNode);

            while (Q.Count > 0)
            { 
                GraphNode<TLabel, TData> current = Q.Dequeue();
                V.Add(current);
                Console.WriteLine("Granma is in that city: " + current);
                foreach (var n in current.Neighborhood)
                {
                    if (!Q.Contains(n) && !V.Contains(n))
                    {
                        Q.Enqueue(n);
                    }
                }
            }
        }
    }
}