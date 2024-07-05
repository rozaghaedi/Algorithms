using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerApp
{
    /// Form1 manages the user interface for customer queue operations including creating queues,enqueueing and dequeuing customers, and displaying queue details.
    public partial class Form1 : Form
    {
        private CustomerQueue _customerQueue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Handles the click event of the Enqueue button. Validates input, creates a new customer, and adds it to the queue.


        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            try
            {
                if (_customerQueue == null)
                {
                    MessageBox.Show("There is no Queue. Please create one first.");
                    return;
                }

                if (txtName.Text == string.Empty || txtAge.Text == string.Empty ||
                    txtAddress.Text == string.Empty || txtAmount.Text == string.Empty)
                {
                    MessageBox.Show("Enter all customer info correctly.");
                    return;
                }

                if (int.TryParse(txtName.Text, out int number))
                {
                    MessageBox.Show("Please enter a valid name for the customer.");
                    return;
                }

                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string address = txtAddress.Text;
                float amount = (float)Convert.ToDouble(txtAmount.Text);

                Customer newCustomer = new Customer(name, age, address, amount);
                _customerQueue.Enqueue(newCustomer);
                UpdateUI();
                ClearInputFields();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for age and amount!");
            }
        }

        //Manage the Dequeue button click, removes the front customer from the queue, and updates the UI.
        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (_customerQueue == null)
            {
                MessageBox.Show("There is no Queue. Please create one first.");
                return;
            }

            if (_customerQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty.");
            }
            else
            {
                Customer dequeuedCustomer = _customerQueue.Dequeue();
                MessageBox.Show(dequeuedCustomer.GetInformation(), "Dequeued Customer");
                UpdateUI();
            }
        }

        //Manage the Peek button click, displays information about the customer at the front of the queue.
        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (_customerQueue == null || _customerQueue.IsEmpty())
            {
                MessageBox.Show("Queue is Empty.");
            }
            else
            {
                Customer frontCustomer = _customerQueue.Peek();
                MessageBox.Show(frontCustomer.GetInformation());
            }
        }

        // Manage creating a new queue with specified size.
        private void btnQueueCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int size = Convert.ToInt32(txtQueueSize.Text);
                if (size <= 0)
                {
                    MessageBox.Show("Please enter a valid number for the queue size.");
                    return;
                }

                if (_customerQueue != null && !_customerQueue.IsEmpty())
                {
                    MessageBox.Show("There is already a queue with items. Please Dequeue all the items first.");
                }
                else
                {
                    _customerQueue = new CustomerQueue(size);
                    MessageBox.Show("Queue created.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for the queue size.");
            }
        }

        //Updates the UI with the latest queue stats.

        private void UpdateUI()
        {
            maxCustomer.Text = _customerQueue.GetTheCustomerWithMax().GetInformation();
            noCustomers.Text = _customerQueue.GetNumberOfItems().ToString();
            totalAmountOwned.Text = _customerQueue.TotalOwedByAll().ToString();
            
        }

        // Clears all input fields after a customer is enqueued.
        private void ClearInputFields()
        {
            txtName.Text = txtAge.Text = txtAddress.Text = txtAmount.Text = string.Empty;
        }
    }
}
