using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosGrafico.Source
{
    class Menu
    {
        private Graph graph;

        public Menu()
        {
            Console.Write("¿El grafo es dirigido? (s/n): ");
            string respuesta = Console.ReadLine();
            bool isDirected = respuesta.ToLower() == "s";
            graph = new Graph(isDirected);
        }

        public void Start()
        {
            int opcion = 0;
            do
            {
                ShowMenu();
                Console.Write("Elige una opción: ");
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción no válida, ingresa un número.");
                    continue;
                }
                switch (opcion)
                {
                    case 1:
                        AddVertex();
                        break;
                    case 2:
                        AddEdge();
                        break;
                    case 3:
                        DeleteVertex();
                        break;
                    case 4:
                        DeleteEdge();
                        break;
                    case 5:
                        Console.WriteLine("Grafo:");
                        graph.PrintGraph();
                        break;
                    case 6:
                        RealizarBFS();
                        break;
                    case 7:
                        RealizarDFS();
                        break;
                    case 8:
                        CountVertices();
                        break;
                    case 9:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no reconocida.");
                        break;
                }
                Console.WriteLine();
            } while (opcion != 9);
        }

        private void ShowMenu()
        {
            Console.WriteLine("=== Menú de Opciones ===");
            Console.WriteLine("1. Agregar vértice");
            Console.WriteLine("2. Agregar arista");
            Console.WriteLine("3. Eliminar vértice");
            Console.WriteLine("4. Eliminar arista");
            Console.WriteLine("5. Imprimir grafo");
            Console.WriteLine("6. Realizar BFS");
            Console.WriteLine("7. Realizar DFS");
            Console.WriteLine("8. Contar vértices");
            Console.WriteLine("9. Salir");
        }

        private void AddVertex()
        {
            Console.Write("Ingresa el vértice a agregar (número entero): ");
            if (int.TryParse(Console.ReadLine(), out int vertice))
            {
                if (graph.AddVertex(vertice))
                    Console.WriteLine("Vértice agregado exitosamente.");
                else
                    Console.WriteLine("El vértice ya existe.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        private void AddEdge()
        {
            Console.Write("Ingresa el vértice origen: ");
            if (!int.TryParse(Console.ReadLine(), out int origen))
            {
                Console.WriteLine("Entrada inválida para el origen.");
                return;
            }
            Console.Write("Ingresa el vértice destino: ");
            if (!int.TryParse(Console.ReadLine(), out int destino))
            {
                Console.WriteLine("Entrada inválida para el destino.");
                return;
            }
            if (graph.AddEdge(origen, destino))
                Console.WriteLine("Arista agregada exitosamente.");
            else
                Console.WriteLine("Error al agregar la arista. Verifica que ambos vértices existan.");
        }

        private void DeleteVertex()
        {
            Console.Write("Ingresa el vértice a eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int vertice))
            {
                if (graph.RemoveVertex(vertice))
                    Console.WriteLine("Vértice eliminado exitosamente.");
                else
                    Console.WriteLine("El vértice no existe.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        private void DeleteEdge()
        {
            Console.Write("Ingresa el vértice origen: ");
            if (!int.TryParse(Console.ReadLine(), out int origen))
            {
                Console.WriteLine("Entrada inválida para el origen.");
                return;
            }
            Console.Write("Ingresa el vértice destino: ");
            if (!int.TryParse(Console.ReadLine(), out int destino))
            {
                Console.WriteLine("Entrada inválida para el destino.");
                return;
            }
            if (graph.RemoveEdge(origen, destino))
                Console.WriteLine("Arista eliminada exitosamente.");
            else
                Console.WriteLine("Error al eliminar la arista. Verifica que ambos vértices existan.");
        }

        private void RealizarBFS()
        {
            Console.Write("Ingresa el vértice de inicio para BFS: ");
            if (int.TryParse(Console.ReadLine(), out int inicio))
            {
                if (!graph.BFS(inicio))
                    Console.WriteLine("El vértice de inicio no existe.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        private void RealizarDFS()
        {
            Console.Write("Ingresa el vértice de inicio para DFS: ");
            if (int.TryParse(Console.ReadLine(), out int inicio))
            {
                if (!graph.DFS(inicio))
                    Console.WriteLine("El vértice de inicio no existe.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        private void CountVertices()
        {
            Console.WriteLine("Número de vértices: " + graph.VertexCount());
        }
    }
}
