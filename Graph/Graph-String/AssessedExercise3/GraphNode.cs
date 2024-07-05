using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessedExercise3
{
    // Represents a single node within a graph, capable of connecting to other nodes via directed edges.
    internal class GraphNode
    {
        // Private field to store the name of the graph node.
        private string name;

        // List of adjacency node names to represent the edges from this node to other nodes.
        private LinkedList<string> adjList;

        //Constructor initializes a new instance of the GraphNode with a specific name.
        public GraphNode(string name)
        {
            this.name = name;
            adjList = new LinkedList<string>();
        }

        // Property to get or set the name of the graph node.
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        // Adds an edge from this node to another node.
        // <param name="to">The destination node to which the edge will be directed.</param>
        public void AddEdge(GraphNode to)
        {
            if (to != null)
            {
                adjList.AddLast(to.Name);
            }
        }

        //Gets the list of adjacency node names indicating connections from this node to other nodes.
        public LinkedList<string> GetAdjList()
        {
            return adjList;
        }


    }
}
