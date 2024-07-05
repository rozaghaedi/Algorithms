using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssessedExercise3
{
    internal class Graph
    {
        // List to store the nodes of the graph
        private LinkedList<GraphNode> nodes;
        
        public Graph()
        {
            nodes = new LinkedList<GraphNode>();
        }

        // Public property to access the list of nodes in the graph.
        public LinkedList<GraphNode> Nodes
        {
            get { return nodes; }
        }

        // Adds a node to the graph with the specified name.
        public void AddNode(string name)
        {
            nodes.AddLast(new GraphNode(name));
        }

        //Return the graphnode with a specific Name
        public GraphNode GetNodeByName(string name)
        {
            foreach (var node in nodes)
            {
                // Check if the current node's name matches the desired name
                if (node.Name == name)
                {
                    return node; 
                }
            }
            return null;
        }

        // Adds a node to the graph with the specified name.
        public void AddEdge(string from, string to)
        {
            GraphNode n1 = GetNodeByName(from);//get the graphnode that corresponds to the node with Name = from
            GraphNode n2 = GetNodeByName(to);// get the graphnode that corresponds to the node with Name = to
            n1.AddEdge(n2);// add a directed edge going from node n1 to node 2 
                          


        }

        // Returns the total number of edges in the graph.
        public int Number_of_edges()
        {
            int totalEdges = 0;

            // Iterate over each node in the list of nodes
            foreach (var node in nodes)
            {
                totalEdges += node.GetAdjList().Count; // Add the number of edges (adjacent nodes) for this node
            }

            return totalEdges; // Return the total number of edges in the graph
        }

        // Determines if a path exists from the source node to the destination node using BFS.
        public bool Is_Travers_Possible(string source, string destination)
        {
           
            var sourceNode = GetNodeByName(source);
            var destinationNode = GetNodeByName(destination);

            if (sourceNode == null || destinationNode == null)
            {
                return false; // If either node doesn't exist in the graph, return false
            }

            Queue<GraphNode> queue = new Queue<GraphNode>();
            List<GraphNode> visited = new List<GraphNode>();

            queue.Enqueue(sourceNode);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                LinkedList<string> neighbors = currentNode.GetAdjList();
                visited.Add(currentNode);

                foreach (string neighbor in neighbors)
                {
                    var node = GetNodeByName(neighbor);

                    if (node == destinationNode)
                    {
                        return true;
                    }
                    if (neighbor != null && !visited.Contains(node)) 
                    {
                        queue.Enqueue(node);
                    }
                }
            }

            return false;
        }
        // Performs a breadth-first search from a starting node and returns a string of visited nodes.
        public string BFS(string startpoint)
        {
            var startNode = GetNodeByName(startpoint);
            if (startNode == null) return "Start node not found.";

            Queue<GraphNode> queue = new Queue<GraphNode>();

            List<GraphNode> visited = new List<GraphNode>();
            string result = string.Empty;

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                result +=(currentNode.Name + " -> ");

                foreach (string neighborName in currentNode.GetAdjList())
                {
                    var neighbor = GetNodeByName(neighborName);
                    if (neighbor != null && !visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result.ToString().Substring(0,result.Length-4 ); 
        }
    }
}
