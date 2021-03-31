using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_total_Click(object sender, EventArgs e)
        {

            int guests = int.Parse(tb_numGuests.Text);
            int total = guests * 35;
            if (guests < 0)
            {
                label10.Text = "Please enter a positive number";
            }
            else if( guests == 0)
            {
                label10.Text = "$35";
            }
            else
            {
                label10.Text = total.ToString();

            }
            
            label10.Visible = true;
        }

        private void lbl_Total_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cb_sides_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numSelected = cb_sides.CheckedItems.Count;

            if(numSelected == 3)
            {
               while(cb_sides.CheckedIndices.Count > 0)
                {
                    cb_sides.SetItemChecked(cb_sides.CheckedIndices[0], false);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void combo_desert_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_numGuests_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int numGuests = int.Parse(tb_numGuests.Text);
            }
            catch(Exception)
            {
                label10.Text = "$0";
            }
           
        }
    }
}
