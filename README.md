# Implementación y Operaciones en Grafos en C#

Este proyecto es una implementación en C# para trabajar con grafos. Incluye tres clases principales:

- **Graph**: Implementa la estructura de datos de un grafo mediante una lista de adyacencia. Permite agregar y eliminar vértices y aristas, imprimir el grafo, y realizar recorridos en anchura (BFS) y en profundidad (DFS).

- **Menu**: Proporciona una interfaz interactiva en consola para que el usuario pueda manipular el grafo. Con el menú se pueden realizar operaciones como agregar o eliminar vértices/aristas, visualizar el grafo, ejecutar BFS/DFS y contar el número de vértices.

- **Program**: Contiene el método `Main`, que es el punto de entrada de la aplicación. Inicializa el menú y permite la interacción continua con el usuario.

## Descripción de las Clases

### Graph

La clase **Graph** se encuentra en el namespace `GrafosGrafico.Source` y utiliza un diccionario (`Dictionary<int, List<int>>`) para representar la lista de adyacencia. Entre sus funcionalidades se incluyen:

- **Agregar Vértice:**  
  `AddVertex(int vertex)` agrega un vértice si este no existe en el grafo.

- **Agregar Arista:**  
  `AddEdge(int source, int destination)` conecta dos vértices existentes. En grafos no dirigidos, la conexión se realiza en ambos sentidos.

- **Eliminar Vértice:**  
  `RemoveVertex(int vertex)` elimina un vértice y todas las aristas asociadas.

- **Eliminar Arista:**  
  `RemoveEdge(int source, int destination)` elimina la conexión entre dos vértices.

- **Imprimir Grafo:**  
  `PrintGraph()` muestra en consola cada vértice y sus vértices adyacentes.

- **Recorridos:**  
  `BFS(int start)` y `DFS(int start)` permiten realizar recorridos en anchura y en profundidad respectivamente, partiendo de un vértice específico.

- **Contar Vértices:**  
  `VertexCount()` devuelve el número total de vértices presentes en el grafo.

Esta clase permite crear tanto grafos dirigidos como no dirigidos, según se especifique en el constructor.

### Menu

La clase **Menu** ofrece una interfaz de usuario basada en consola para interactuar con la clase **Graph**. Entre las opciones que provee el menú se encuentran:

- Seleccionar si el grafo será dirigido o no.
- Agregar o eliminar vértices.
- Agregar o eliminar aristas.
- Imprimir la estructura del grafo.
- Ejecutar recorridos BFS y DFS.
- Mostrar el número de vértices del grafo.

El menú se implementa mediante un bucle que permite al usuario ejecutar múltiples operaciones hasta decidir salir.

### Program

La clase **Program** es el punto de entrada del proyecto. Contiene el método `Main`, que crea una instancia de la clase **Menu** e invoca el método `Start()` para comenzar la interacción con el usuario.


## Cómo Ejecutar el Proyecto

1. **Requisitos:**
   - Tener instalado .NET Framework o .NET Core.
   - Un entorno de desarrollo compatible, como Visual Studio o VS Code.

2. **Compilación y Ejecución:**
   - Abre el proyecto en tu IDE.
   - Compila la solución.
   - Ejecuta el proyecto y sigue las instrucciones en la consola para interactuar con el grafo.

## Uso del Proyecto

Al iniciar el programa se te preguntará si el grafo es dirigido o no. Luego, a través del menú interactivo, podrás:

- Agregar o eliminar vértices y aristas.
- Imprimir la estructura del grafo.
- Realizar recorridos BFS y DFS.
- Consultar el número de vértices en el grafo.

Este proyecto es útil para aprender y practicar la manipulación de grafos y algoritmos de búsqueda en C#.
