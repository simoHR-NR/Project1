using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1.Forms
{
    public partial class selectbirds : Form
    {
        public selectbirds(string h)
        {
            InitializeComponent();
            k = h;
        }

        ADO d=new ADO();
        string k;
        private void selectbirds_Load(object sender, EventArgs e)
        {
            d.connected();
            getbirdlist(k);
            dataGridView1.DataSource = d.ds.Tables["bird"];
            btc.Name = "Add";
            btc.Text = "+";
            btc.DisplayIndex = 5;
            btc.UseColumnTextForButtonValue = true;
            btc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btc.FlatStyle = FlatStyle.Standard;
            btc.CellTemplate.Style.BackColor = Color.Honeydew;
            dataGridView1.Columns.Add(btc);
            


    }
        public void getbirdlist(string a)
        {
            if(a=="P")
            {

            
            d.dap = new SqlDataAdapter("SELECT bird.id, bird.name, species.species, bird.gender, bird.price FROM     bird INNER JOIN species ON bird.species = species.id where bird.id not in (select purchasebird.bird from purchasebird) and bird.id not in (select salebird.bird from salebird)", d.cn);
            d.dap.Fill(d.ds, "bird");
            }
            else
            {
                d.dap = new SqlDataAdapter("SELECT bird.id, bird.name, species.species, bird.gender, bird.price FROM     bird INNER JOIN species ON bird.species = species.id where bird.id not in (select salebird.bird from salebird)", d.cn);
                d.dap.Fill(d.ds, "bird");
            }
        }

        //Button in the datagridview To add bird to list to return

        DataGridViewButtonColumn btc = new DataGridViewButtonColumn();
        public List<int> ls = new List<int>();
        
         
        private void btc_click(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && btc.Text =="+")
            {
               
                string t = ("=>"+dataGridView1.CurrentRow.Cells[1].Value
                     + "--" + dataGridView1.CurrentRow.Cells[2].Value
                     + "--" + dataGridView1.CurrentRow.Cells[3].Value
                     + "--" + dataGridView1.CurrentRow.Cells[4].Value).ToString();
                
                
                if (listBox1.Items.Contains(t) == false)
                  {
                      listBox1.Items.Add(t);
                      ls.Add(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                      return;
                  }
                   else
                       MessageBox.Show("alredy exist!");
             }
                
                
           

        }


        //Filter Birds list by species
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            d.ds.Tables["bird"].DefaultView.RowFilter = String.Format("species LIKE '%{0}%'",textBox1.Text);
        }

       
      


        // Return list Bird to Invoices window
        private void btnfinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        // Remove Birds from list before return it it Invoices window
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int z = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(z);
                ls.RemoveAt(z);
            }
            catch
            {
                return;
            }
        }
    }
}
