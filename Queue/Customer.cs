using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;

namespace CustomerApp
{

    // Represents a customer with basic personal and financial information.
    internal class Customer
    {
        private string _name;// The customer's name (private for data encapsulation).
        private int _age;//The customer's age (private for data encapsulation).
        private string _address;//The customer's address (private for data encapsulation).
        private float _amountOwed;//The amount of money owed by the customer (private for data encapsulation)

        /// This default constructor initializes a new Customer object with default values (null name, 0 age, null address, 0 amount owed).
        public Customer()
        {
            this.Name = null;
            this.Age = 0;
            this.Address = null;
            this.AmountOwed = 0;
        }

        /// This parameterized constructor initializes a new Customer object with the provided values for each property.
        public Customer(string name, int age, string address, float amountOwed)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.AmountOwed = amountOwed;
        }
        // Property to access and modify the customer's name.
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Property to access and modify the customer's age.
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // Property to access and modify the customer's address.
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        // Property to access and modify the amount owed by the customer
        public float AmountOwed
        {
            get { return _amountOwed; }
            set { _amountOwed = value; }
        }

        //This method retrieves all current customer information(name, age, address, amount owed) and formats it into a single string that can be displayed .
        public string GetInformation()
        {
            if (this.Name == null)
            {
                return string.Empty;
            }
            return "Name: " + Name + Environment.NewLine +
                   "Age: " + Age + Environment.NewLine +
                   "Address: " + Address + Environment.NewLine +
                   "Amount Owed: " + AmountOwed;
        }
    }
}