using Exercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    // The CustomerBinTree class defines a binary tree for storing and retouch customer data efficiently.
    internal class CustomerBinTree
    {
        private CustomerNode root; // Root node of the binary tree, initially set to null

        // Default constructor that initializes an empty tree
        public CustomerBinTree()
        {
            root = null;
        }

        // Constructor that initializes the tree with a single node
        public CustomerBinTree(CustomerNode node)
        {
            root = node;
        }

        // Public method to perform a pre-order traversal starting from the root
        public string PreOrderTraversal()
        {
            return PreOrderTraversal(root);
        }

        // Private recursive method for pre-order traversal from a specific node
        private string PreOrderTraversal(CustomerNode node)
        {
            string sortResult = string.Empty;
            if (node != null)
            {
                sortResult += node.CustomerData.Name + " => ";
                sortResult += PreOrderTraversal(node.Left);
                sortResult += PreOrderTraversal(node.Right);
                return sortResult;
            }
            return sortResult;
        }

        // Public method to perform an in-order traversal starting from the root
        public string InOrderTraversal()
        {
            return InOrderTraversal(root);
        }

        // Private recursive method for in-order traversal from a specific node
        private string InOrderTraversal(CustomerNode node)
        {
            string sortResult = string.Empty;
            if (node != null)
            {
                sortResult += InOrderTraversal(node.Left);
                sortResult += node.CustomerData.Name + " => ";
                sortResult += InOrderTraversal(node.Right);
                return sortResult;
            }
            return sortResult;
        }

        // Public method to perform a post-order traversal starting from the root
        public string PostOrderTraversal()
        {
            return PostOrderTraversal(root);
        }

        // Private recursive method for post-order traversal from a specific node
        private string PostOrderTraversal(CustomerNode node)
        {
            string sortResult = string.Empty;
            if (node != null)
            {
                sortResult += PostOrderTraversal(node.Left);
                sortResult += PostOrderTraversal(node.Right);
                sortResult += node.CustomerData.Name + " => ";
                return sortResult;
            }
            return sortResult;
        }

        // Method to insert a new customer into the binary tree
        public bool InsertItem(Exercise2.Customer value)
        {
            bool added = false;
            Insert(ref root, value, ref added);
            return added;
        }

        // Private method to recursively find the correct position and insert a new node
        private void Insert(ref CustomerNode node, Exercise2.Customer value, ref bool added)
        {
            if (node == null)
            {
                node = new CustomerNode(value);
                added = true;
            }
            else if (value.CompareTo(node.CustomerData) < 0)
            {
                Insert(ref node.Left, value, ref added);
            }
            else if (value.CompareTo(node.CustomerData) > 0)
            {
                Insert(ref node.Right, value, ref added);
            }
            else
            {
                throw new Exception("There is a customer with this name."); // Ensure uniqueness in the tree
            }
        }

        // Method to search for a customer by name and return their data if found
        public Exercise2.Customer search(string Name)
        {
            CustomerNode res = search(root, Name);
            return res.CustomerData;
        }

        // Private recursive method to search for a node by customer name
        private CustomerNode search(CustomerNode root, string Name)
        {
            if (root == null)
                return null;

            if (root.CustomerData.Name == Name)
                return root;
            if (root.CustomerData.Name.CompareTo(Name) > 0) {
                return search(root.Left, Name);
            } else {
                return search(root.Right, Name);
            }
        }

        // Method to count all nodes (customers) in the tree
        public int CountItems()
        {
            return Count(root);
        }

        // Private recursive method to count all nodes in the tree
        private int Count(CustomerNode tree)
        {
            if (tree == null)
                return 0;
            return 1 + Count(tree.Left) + Count(tree.Right);
        }

    }
}
