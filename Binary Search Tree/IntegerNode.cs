    /*The "Node" class is designed for use in data structures that require a binary tree architecture. 
 It encapsulates a single node of the tree with properties to hold the data and references to the left and right child nodes.
Each node stores an integer value, and it initializes with no children, indicating a leaf node until children are added.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class IntegerNode
    {
        // Field to store the data value of the node.
        private int _data;

        // Public properties to access and set left and right child nodes.
        public IntegerNode Left, Right;

        // Constructor to initialize the node with a data value and no children.
        public IntegerNode(int newValue)
        {
            Data = newValue;
            Left = null;
            Right = null;
        }

        // Property to safely access and modify the data value of the node.
        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
