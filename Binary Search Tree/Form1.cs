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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInt_Click(object sender, EventArgs e)
        {
             Integer_Form frm2 = new Integer_Form();
             frm2.Show();
        }
        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            Customer_Form frm3 = new Customer_Form();
            frm3.Show();
        }

        private void integerTreeMenu_Click(object sender, EventArgs e)
        {
            Integer_Form frm2 = new Integer_Form();
            frm2.Show();
        }

        private void customerTreeMenu_Click(object sender, EventArgs e)
        {
            Customer_Form frm3 = new Customer_Form();
            frm3.Show();
        }
    }
}
