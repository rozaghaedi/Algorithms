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
        // Private field to store the id of the graph node.
        private int id;

        // List of adjacency node id to represent the edges from this node to other nodes.
        private LinkedList<int> adjList;

        //Constructor initializes a new instance of the GraphNode with a specific id.
        public GraphNode(int id)
        {
            this.id = id;
            adjList = new LinkedList<int>();
        }

        // Property to get or set the id of the graph node.
        public int ID
        {
            set {id = value; }
            get { return id; }
        }

        // Adds an edge from this node to another node.
        // <param id="to">The destination node to which the edge will be directed.</param>
        public void AddEdge(int toId)
        {
            adjList.AddLast(toId); 
        }

        //Gets the list of adjacency node id indicating connections from this node to other nodes.
        public LinkedList<int> GetAdjList()
        {
            return adjList;
        }


    }
}
