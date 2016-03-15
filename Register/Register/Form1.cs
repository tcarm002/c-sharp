using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        private double total;
        public Form1()
        {
            InitializeComponent();

            total = 0.0;
            string [] items = { "bananas", "apples", "grapes", "peaches" };
            for (int i = 0; i < items.Length; i++)
            {
                clbItems.Items.Insert(i,items[i]);
            }
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int numItems = clbItems.CheckedItems.Count;

            total = numItems * 0.50;
            lblTotal.Text = String.Format("{0:#.00}", total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
