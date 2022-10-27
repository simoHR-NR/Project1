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
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Documents;

namespace WinFormsApp1.Forms
{
    public partial class Breeder : Form
    {
        public Breeder()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        ADO d=new ADO();
        
        private void Breeder_Load(object sender, EventArgs e)
        {
            d.connected();
            getbreeder();
            textBox5.Visible = false;
            filter.Visible = false;
            visibility(false);
            label5.Visible = false;
            iconcolor();
        }
        public void iconcolor()
        {
            btnadd.IconColor = this.BackColor;
            btndelete.IconColor = this.BackColor;
            btnupdate.IconColor = this.BackColor;
            btnsearch.IconColor = this.BackColor;
            bntcancel.IconColor = this.BackColor;
        }

        //Get Breeder 
        public void getbreeder()
        {
            d.dap = new SqlDataAdapter("select * from breeder",d.cn);
            d.dap.Fill(d.ds, "breeder");
            
            dataGridView1.DataSource = d.ds.Tables["breeder"];
            dataGridView1.Columns[0].Visible = false;
        }

        // Controls Insert visibility
        public void visibility(bool a)
        {
            if(a==true)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                bntcancel.Visible = true;
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnsearch.Enabled = false;
                groupBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                bntcancel.Visible = false;
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                btnsearch.Enabled = true;
                groupBox1.Visible = false;
            }
        }

        // Save in Database
        public void save(DataSet s, string tablename)
        {
            d.bc = new SqlCommandBuilder(d.dap);
            d.dap.Update(s, tablename);


        }

        //Filter list Breeder with keywords
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            d.ds.Tables["breeder"].DefaultView.RowFilter = String.Format("firstname Like '%{0}%' or lastname Like '%{0}%' or adress Like '%{0}%'", textBox5.Text);
        }
        // Check fields before Add
        private bool checkfield()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                return true;
            else
                return false;

        }
        // Buttons
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "Add")
            {
                btnadd.Text = "Save";
                visibility(true);
                btnupdate.Enabled = false;
                btndelete.Enabled = false;
                btnsearch.Enabled = false;

            }
            else
            {
                if(checkfield())
                {
                    MessageBox.Show("One or more field are emty");
                }
                else
                {

                btnadd.Text = "Add";
                visibility(false);
                d.lign = d.ds.Tables["breeder"].NewRow();
                d.lign[1] = textBox1.Text;
                d.lign[2] = textBox2.Text;
                d.lign[3] = textBox3.Text;
                d.lign[4] = textBox4.Text;
                d.ds.Tables["breeder"].Rows.Add(d.lign);
                save(d.ds, "breeder");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                btnsearch.Enabled = true;
                d.ds.Tables["breeder"].Clear();
                d.dap.Fill(d.ds, "breeder");
                dataGridView1.DataSource = d.ds.Tables["breeder"];
                bntcancel.Visible = false;
                notifyIcon1.BalloonTipText = "Breeder Added successfully !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);
                }
                
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0] == d.ds.Tables["breeder"].Rows[i][0])
                {
                    d.ds.Tables["breeder"].Rows[i][1] = dataGridView1.Rows[i].Cells[1].Value;
                    d.ds.Tables["breeder"].Rows[i][2] = dataGridView1.Rows[i].Cells[2].Value;
                    d.ds.Tables["breeder"].Rows[i][3] = dataGridView1.Rows[i].Cells[3].Value;
                    d.ds.Tables["breeder"].Rows[i][4] = dataGridView1.Rows[i].Cells[4].Value;
                }
            }
            save(d.ds, "breeder");
            notifyIcon1.BalloonTipText = "Breeder updated successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {


            if (btndelete.Text == "Delete")
            {
                DataColumn dm = new DataColumn("delete", typeof(bool));
                dm.DefaultValue = false;
                d.ds.Tables["breeder"].Columns.Add(dm);
                label5.Visible = true;
                btndelete.Text = "Confirm\ndelete !";
            }
            else
            {

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[5].Value) == true)
                    {
                        d.ds.Tables["breeder"].Rows[int.Parse(r.Index.ToString())].Delete();

                    }
                }
                btndelete.Text = "Delete";
                label5.Visible = false;
                d.ds.Tables["breeder"].Columns.Remove("delete");
                save(d.ds, "breeder");
                notifyIcon1.BalloonTipText = "Breeder deleted !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (btnsearch.Text == "Search")
            {
                btnsearch.Text = "Ok";
                textBox5.Visible = true;
                filter.Visible = true;
            }
            else
            {
                btnsearch.Text = "Search";
                textBox5.Visible = false;
                filter.Visible = false;
                textBox5.Clear();
            }
        }
        // Cancel Add
        private void bntcancel_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            btnadd.Text = "Add";
            visibility(false);
        }
    }
}
