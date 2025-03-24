using GrafosGrafico.Source;
using Raylib_cs;

class Program
{
    static int Main()
    {
        //Raylib.InitWindow(700, 700, "Grafos");

        //while(!Raylib.WindowShouldClose())
        //{
        //    Raylib.BeginDrawing();

        //    Raylib.ClearBackground(Color.Pink);

        //    Raylib.EndDrawing();
        //}

        Graph graph = new Graph(false);
        graph.AddVertex(0);
        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);

        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 0);
        graph.AddEdge(0, 2);

        //graph.RemoveVertex(2);

        //graph.PrintGraph();

        graph.BFS();
        graph.DFS(0);

        return 0;
    }
}
