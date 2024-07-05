using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AssessedExercise3
{

    // Represents a graph data structure that can store nodes and establish directed edges between them.
    internal class Graph
    {
        // Stores all the nodes in the graph using a linked list.
        private LinkedList<GraphNode> nodes;

        // Constructor that initializes a new instance of the Graph class.
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }


        // Provides public access to the list of nodes in the graph.
        public LinkedList<GraphNode> Nodes
        {
            get { return nodes; }
        }


        //Adds a node with the specified identifier to the graph if it doesn't already exist.
        public void AddNode(int id)
        {
            // Prevents the addition of duplicate nodes.
            if (GetNodeByID(id) == null)  
            {
                nodes.AddLast(new GraphNode(id));
            }
        }

        /// Retrieves a node by its identifier from the graph.
        public GraphNode GetNodeByID(int id)
        {
            // Iterates over each node in the list to find a match.
            foreach (GraphNode node in nodes)
            {
                if (node.ID == id)
                {
                    return node;
                }
            }
            return null;
        }


        // Adds a directed edge from one node to another if both nodes exist in the graph.
        public void AddEdge(int from, int to)
        {
            GraphNode fromNode = GetNodeByID(from);
            GraphNode toNode = GetNodeByID(to);

            // Ensures both nodes exist before adding an edge.
            if (fromNode != null && toNode != null)
            {
                fromNode.AddEdge(to);
            }
        }


        // Calculates the total number of directed edges in the graph.
        public int Number_of_edges()
        {
            int totalEdges = 0;
            foreach (GraphNode node in nodes)//Sum up the count of adjacency lists for all nodes.
            {
                totalEdges += node.GetAdjList().Count;
            }
            return totalEdges;
        }


        // Determines whether a path exists between two specified nodes using (BFS).
        public bool Is_Travers_Possible(int source, int destination)
        {
            GraphNode sourceNode = GetNodeByID(source);
            GraphNode destinationNode = GetNodeByID(destination);

            if (sourceNode == null || destinationNode == null)
            {
                return false;
            }

            Queue<GraphNode> queue = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();

            queue.Enqueue(sourceNode);
            visited.Add(sourceNode);

            while (queue.Count > 0)
            {
                GraphNode currentNode = queue.Dequeue();
                foreach (int neighborId in currentNode.GetAdjList())
                {
                    GraphNode neighbor = GetNodeByID(neighborId);
                    if (neighbor == destinationNode)
                    {
                        return true;
                    }
                    if (neighbor != null && !visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return false;
        }

        // Performs a breadth-first search starting from the specified node and returns a string representation of the visited nodes.
        public string BFS(int startpoint)
        {
            GraphNode startNode = GetNodeByID(startpoint);
            if (startNode == null) return "Start node not found.";

            Queue<GraphNode> queue = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();
            StringBuilder result = new StringBuilder();

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                GraphNode currentNode = queue.Dequeue();
                result.Append(currentNode.ID).Append(" -> ");

                foreach (int neighborId in currentNode.GetAdjList())
                {
                    GraphNode neighbor = GetNodeByID(neighborId);
                    if (neighbor != null && !visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            if (result.Length > 4)
                result.Length -= 4; 

            return result.ToString();
        }
    }
}
