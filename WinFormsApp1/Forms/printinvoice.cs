using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class printinvoice : Form
    {
        public printinvoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Show All Informations getting by Invoice window
        public string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11;
      
        private void printinvoice_Load(object sender, EventArgs e)
        {
        
            label8.Text = a8;
            label9.Text = a9;
            label3.Text = a3;
            label4.Text = a4;
            label5.Text = a5;
            
            label11.Text = a11+" DH";
            label13.Text = a1+" DH";
            
            double h = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
              h+= Convert.ToDouble(row.Cells[2].Value);
            }
            label2.Text = h.ToString()+" DH";
            

        }
    }
}
