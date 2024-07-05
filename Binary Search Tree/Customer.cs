using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Exercise2
{
    /* Defines the Customer class with properties to model personal details and financial status.
    Implements IComparable for sorting based on customer names, typically useful in customer management systems.*/
    internal class Customer : IComparable
    {
        private string _name; // Private field to hold the customer's name.
        private int _age; // Private field to hold the customer's age.
        private string _address; // Private field to hold the customer's address.
        private long _amountOwed; // Private field to track how much the customer owes.

        // Constructor to initialize a Customer object with the name, age, address, and amount owed.
        public Customer(string name, int age, string address, long amountowed)
        {
            this._name = name;
            this._age = age;
            this._address = address;
            this._amountOwed = amountowed;
        }

        // Property to access and modify the customer's name.
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Property to access and modify the customer's age.
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        // Property to access and modify the customer's address.
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Property to access and modify the amount the customer owes.
        public long AmountOwed
        {
            get { return this._amountOwed; }
            set { this._amountOwed = value; }
        }

        // Implements the CompareTo method to allow sorting of customers by name.
        public int CompareTo(object obj) 
        {
            // Cast obj to a Customer object and compare names in the alphabetical order.
            Customer other = (Customer)obj; 
            return Name.CompareTo(other.Name); 
        }
    }
}
