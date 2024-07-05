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
using System.Xml.Linq;

namespace Excercise2
{
    // Represents a form to manage an integer binary tree. Allows users to insert data and view pre-order, in-order,and post-order traversals of the tree.
    public partial class Integer_Form : Form
    {
        // Field to hold the binary tree of integers
        IntegerBinTree BinaryTree = null;
        public Integer_Form()
        {
            InitializeComponent();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // Check if the textbox for number input is empty
            if (TxtNumber.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Node Data");
                return;
            }
            try
            {
                int data = int.Parse(TxtNumber.Text);
                if (BinaryTree == null)
                {
                    // If the binary tree hasn't been initialized, create it and add the first node
                    IntegerNode node = new IntegerNode(data);
                    BinaryTree = new IntegerBinTree(node);
                    lblCount.Text = Convert.ToString(BinaryTree.CountNodes());
                    MessageBox.Show(TxtNumber.Text + " added to the Tree");
                    TxtNumber.Text =string.Empty;

                }
                else
                {
                    // If the binary tree is already initialized, insert new data
                    BinaryTree.InsertItem(data);
                    lblCount.Text = Convert.ToString(BinaryTree.CountNodes());
                    MessageBox.Show(TxtNumber.Text + " added to the Tree");
                    TxtNumber.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Number");
            }
        }
        // Displays the pre-order traversal of the binary tree in the UI.
        private void btn_PreOrder_Click(object sender, EventArgs e)
        {
            string result = BinaryTree.PreOrderTraversal();
            TxtPreOrder.Text = result.Substring(0, result.Length - 3); 
        }

        private void btn_InOrder_Click(object sender, EventArgs e)
        {
            string result = BinaryTree.InOrderTraversal();
            TxtInOrder.Text = result.Substring(0, result.Length - 3);
        }
        //Displays the post-order traversal of the binary tree in the UI.
        private void btn_PostOrder_Click(object sender, EventArgs e)
        {
            string result = BinaryTree.PostOrderTraversal();
            TxtPostOrder.Text = result.Substring(0, result.Length - 3);
        }


    }
}
