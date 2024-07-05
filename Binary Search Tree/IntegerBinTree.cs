using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exercise2
{
    // The BinTree class defines a binary tree with insert and traversal capabilities
    internal class IntegerBinTree
    {
        private IntegerNode root; 

        // Default constructor initializing the tree with no nodes
        public IntegerBinTree()
        {
            root = null;
        }

        // Constructor to initialize the tree with a single node
        public IntegerBinTree(IntegerNode node)
        {
            root = node;
        }

        // Method to perform pre-order traversal of the tree
        public string PreOrderTraversal()
        {
            return PreOrderTraversal(root);
        }

        // Private helper method for pre-order traversal from a given node
        private string PreOrderTraversal(IntegerNode node)
        {
            string sortResult = string.Empty;
            if (node != null)
            {
                sortResult += node.Data + " => ";
                sortResult += PreOrderTraversal(node.Left);
                sortResult += PreOrderTraversal(node.Right);
                return sortResult;
            }
            return sortResult;
        }

        // Method to perform in-order traversal of the tree
        public string InOrderTraversal()
        {
            return InOrderTraversal(root);
        }

        // Private helper method for in-order traversal from a given node
        private string InOrderTraversal(IntegerNode node)
        {
            string sortResult = string.Empty;
            if (node != null)
            {
                sortResult += InOrderTraversal(node.Left);
                sortResult += node.Data + " => "; //visit the node itself
                sortResult += InOrderTraversal(node.Right);
                return sortResult;
            }
            return sortResult;
        }

        // Method to perform post-order traversal of the tree
        public string PostOrderTraversal()
        {
            return PostOrderTraversal(root);
        }

        // Private helper method for post-order traversal from a given node
        private string PostOrderTraversal(IntegerNode node)
        {
            string sortResult = string.Empty;
            if (node != null)
            {
                sortResult += PostOrderTraversal(node.Left);
                sortResult += PostOrderTraversal(node.Right);
                sortResult += node.Data + " => ";
                return sortResult;
            }
            return sortResult;
        }

        // Method to insert a new value into the correct position in the tree
        public void InsertItem(int value)
        {
            Insert(ref root, value);
        }

        // Private recursive method to find the correct spot and insert a new node
        private void Insert(ref IntegerNode node, int value)
        {
            if (node == null)
            {
                node = new IntegerNode(value);
            }
            else if (value < node.Data)
            {
                Insert(ref node.Left, value);
            }
            else if (value > node.Data)
            {
                Insert(ref node.Right, value);
            }
        }

        // Method to count all nodes in the tree
        public int CountNodes()
        {
            return CountNodesRecursive(root);
        }

        // Private recursive method to count nodes starting from a given node
        private int CountNodesRecursive(IntegerNode tree)
        {
            if (tree == null)
                return 0;
            return CountNodesRecursive(tree.Left) + CountNodesRecursive(tree.Right) + 1;
        }
    }
}
