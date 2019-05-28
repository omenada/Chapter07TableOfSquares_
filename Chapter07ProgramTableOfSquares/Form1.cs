using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter07ProgramTableOfSquares
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {   //first version of the program 
            bool flag;
            int i;
            int start;
            int end;
            string buff;
            int j;
            int square;
            int nextOddInteger;
            //================ Gather inputs ======================
            //Convert start from text to int

            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {

                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }

            // Convert end from text to int
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {

                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }

            if (start >= end) // Reasonable values?
            {
                MessageBox.Show("Start greater than end.", "Input Error");
                txtStart.Focus();
                return;
            }

            ////================= Process and Display ============== example first for 

            //for (i = start; i <= end; i++)
            //{
            //    buff = string.Format("{0,5}                          {1,20}", i, i * i);
            //    lstOutput.Items.Add(buff);
            //}

            ////================= Process and Display ============== example for 

            //for (i = start; i <= end; i++)
            //{
            //    nextOddInteger = 1; // Set first odd integer
            //    square = 0; // Always start with square = 0
            //    for (j = 0; j < i; j++) // Nested j loop
            //    {
            //        square += nextOddInteger; // Sum the odd integer
            //        nextOddInteger += 2; // Set the next odd integer
            //    }

            //    buff = string.Format("{0, 5}        {1, 20}", i, square);
            //    lstOutput.Items.Add(buff);
            //}

            ////================= Process and Display ============== example while 
            i = start; // Initialize loop counter: condition 1
            while (i <= end) // Another iteration: condition 2
            {
                buff = string.Format("{0, 5}{1, 20}", i, i * i);
                lstOutput.Items.Add(buff);
                i++; // Change state of loop: condition 3
            }
        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }
    }
}
