using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*The CustomerQueue class is designed to manage a circular queue of Customer instances.
for adding, removing, viewing customers, calculating total owed,
and finding the customer with the highest debt.*/

namespace CustomerApp
{
    internal class CustomerQueue
    {
        // Array to store customers
        private Customer[] myQueue;
        private readonly int maxSize;// Maximum size of the queue
        private int head; // Index of the front element
        private int tail;// Index of the back element
        private int numItems;// Number of items in the queue
        private float totalOwed; // Total amount owed by all customers


        //Initializes an empty queue with a specified maximum size.
        public CustomerQueue(int queue_size)
        {
            maxSize = queue_size;
            myQueue = new Customer[queue_size];
            head = 0;
            tail = 0;
            numItems = 0;
            totalOwed = 0;
        }

        // Adds a new Customer to the back of the queue.If the queue is full, it displays a message box.
        public void Enqueue(Customer customer)
        {
            if (IsFull())
            {
                MessageBox.Show("Queue is Full.");
                return;
            }
            myQueue[tail] = customer;
            totalOwed += customer.AmountOwed;
            numItems++;// This is for GetNumberOfItems function.
            tail = tail + 1;
            if (tail == maxSize)
                tail = 0;
        }


        //Removes and returns the customer at the front of the queue. If the queue is empty, it displays a message box and returns null.
        public Customer Dequeue()

        {
            if (IsEmpty())
            {
                MessageBox.Show("Queue is empty");
                return null;
            }
            Customer one_customer = myQueue[head];
            myQueue[head] = null;
            totalOwed -= one_customer.AmountOwed;
            head = head + 1;
            numItems--;// This is for GetNumberOfItems function.
            if (head == maxSize)
                head = 0;

            return one_customer;
        }

        // Returns the customer at the front of the queue without removing them. Returns null if the queue is empty.
        public Customer Peek()
        {
            if (numItems == 0)
            {
                return null;
            }
            return myQueue[head];
        }

        //Returns the current number of items in the queue.
        public int GetNumberOfItems()
        {
            return this.numItems;
        }

        //Calculates and returns the total amount owed by all customers in the queue.
        public float TotalOwedByAll()
        {
            return this.totalOwed;
        }
        public Customer GetTheCustomerWithMax()
        {
            if (IsEmpty())
            {
                return new Customer();
            }
            Customer c = myQueue[head];
            int counter = head;
            for(int i = head; i < numItems; i++)
            {
                if(counter < maxSize) counter = 0;
                if (c.AmountOwed < myQueue[i].AmountOwed)
                {
                    c = myQueue[i];
                }
                counter++;
            }
            return c;
        }
        public bool IsEmpty()//Checks if the queue is empty.
        {
            return (numItems == 0);
        }

        public bool IsFull()//Checks if the queue is full.
        {
            return (numItems == maxSize);
        }
    }
}
