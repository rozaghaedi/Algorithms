using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    // The CNode class represents a node in a binary tree structure, specifically designed to hold customer data.
    internal class CustomerNode
    {
        private Customer _customerData; 
        public CustomerNode Left, Right; 

        // Constructor initializes a CNode with a given customer, setting both child references to null.
        public CustomerNode(Customer Customer)
        {
            CustomerData = Customer;
            Left = null;
            Right = null;
        }

        // Property CustomerData for getting and setting customer data in this node.
        // The setter updates the internal field, and the getter returns the customer object.
        public Customer CustomerData
        {
            set { _customerData = value; }
            get { return _customerData; }
        }
    }
}
