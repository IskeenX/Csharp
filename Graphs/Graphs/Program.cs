namespace Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph<string, int> myGraph = new Graph<string, int>();

            myGraph.AddNode("Budapest", 2000);
            myGraph.AddNode("Bucharest", 4000);
            myGraph.AddNode("Rome", 3000);
            myGraph.AddNode("Bratislava", 1000);
            myGraph.AddNode("Berlin", 5000);
            myGraph.AddNode("Moscow", 9000);

            myGraph.AddUndirectedEdge("Budapest", "Rome");
            myGraph.AddUndirectedEdge("Berlin", "Bratislava");
            myGraph.AddUndirectedEdge("Budapest", "Bratislava");
            myGraph.AddUndirectedEdge("Budapest", "Bucharest");
            myGraph.AddUndirectedEdge("Rome", "Berlin");

            myGraph.FindPath("Berlin", "Bucharest");


            Console.ReadKey();
        }
    }
}