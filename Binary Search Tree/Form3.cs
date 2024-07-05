using Exercise2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise2
{

    //A form for managing customer data within a binary tree structure. Allows insertion of new customers and supports viewing and searching of existing customer records in various traversal orders.
    public partial class Customer_Form : Form
    {
        CustomerBinTree CBinaryTree = null;
        public Customer_Form()
        {
            InitializeComponent();
        }

        // Handles the event for in-order traversal button click, updating the in-order text display.
        private void BtnInOrder_Click(object sender, EventArgs e)
        {
            string result = CBinaryTree.InOrderTraversal();
            TxtInOrder.Text = result.Substring(0, result.Length - 3); 
        }

        // Handles the event for post-order traversal button click, updating the post-order text display.
        private void BtnPostOrder_Click(object sender, EventArgs e)
        {
            string result = CBinaryTree.PostOrderTraversal();
            TxtPostOrder.Text = result.Substring(0, result.Length - 3);
        }

        // Handles the event for pre-order traversal button click, updating the pre-order text display.
        private void BtnPreOrder_Click(object sender, EventArgs e)
        {
            string result = CBinaryTree.PreOrderTraversal();
            TxtPreOrder.Text = result.Substring(0, result.Length - 3);
        }


        // Handles the event for the search button click, searching for a customer by name and updating the UI with the customer details or an error message if not found.
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = TxtSearch.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter Name!");
                return;
            }

            Exercise2.Customer c = CBinaryTree.search(name);
            if (c == null)
            {
                MessageBox.Show("No customer record found with the specified name: " + name);
                lblresult.Text = string.Empty;
            }
            else
            {
                lblresult.Text = $"Name: {c.Name}\nAge: {c.Age}\nAddress: {c.Address}\nAmount Owed: {c.AmountOwed}";
            }
        }


        private void BtnInsert_Click(object sender, EventArgs e)
        {
            // Validate required fields are not empty
            if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtAge.Text) ||
                string.IsNullOrEmpty(TxtAddress.Text) || string.IsNullOrEmpty(TxtAmountOwed.Text))
            {
                MessageBox.Show("Please enter all required customer information to proceed.");
                return;
            }

            // Validate numeric fields
            bool amountIsNumeric = long.TryParse(TxtAmountOwed.Text, out long amountOwed);
            bool ageIsNumeric = int.TryParse(TxtAge.Text, out int age);
            if (!amountIsNumeric)
            {
                MessageBox.Show("Please enter a valid number for amount owed.");
                return;
            }
            if (!ageIsNumeric)
            {
                MessageBox.Show("Please enter a valid number for customer age.");
                return;
            }

            try
            {
                // Attempt to add customer to the binary tree
                Exercise2.Customer c = new Exercise2.Customer(TxtName.Text, age, TxtAddress.Text, amountOwed);
                if (CBinaryTree == null)
                {
                    // Initialize binary tree if it's the first entry
                    CustomerNode node = new CustomerNode(c);
                    CBinaryTree = new CustomerBinTree(node);
                }
                else
                {
                    // Insert customer into existing tree
                    bool result = CBinaryTree.InsertItem(c);
                    if (!result)
                    {
                        MessageBox.Show("An error occurred. Please try again.");
                        return;
                    }
                }

                // Update UI with success message and reset fields
                lblCount.Text = Convert.ToString(CBinaryTree.CountItems());
                MessageBox.Show("New customer added:\n" +
                                $"Name: {TxtName.Text}\n" +
                                $"Age: {TxtAge.Text}\n" +
                                $"Address: {TxtAddress.Text}\n" +
                                $"Amount Owed: {TxtAmountOwed.Text}");
                TxtName.Text = TxtAge.Text = TxtAddress.Text = TxtAmountOwed.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }
    }
}