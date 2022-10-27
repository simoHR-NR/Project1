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
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Species : Form
    {
        public Species()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        ADO d = new ADO();
        private void Form3_Load(object sender, EventArgs e)
        {
            d.connected();
            getspecieslist();
            dataGridView1.Columns[0].Visible = false;
        }
        public void getspecieslist ()
        {
            if(d.ds.Tables["species"]!=null)
            {
                d.ds.Tables["species"].Clear();
            }
            d.dap = new SqlDataAdapter("select * from species",d.cn);
            d.dap.Fill(d.ds, "species");
            dataGridView1.DataSource = d.ds.Tables["species"];
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView1.CurrentCell.Value.ToString();
            
        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter species name !");
                return;
            }
            d.lign = d.ds.Tables["species"].NewRow();
            d.lign[1] = textBox1.Text;
            for (int i = 0; i < d.ds.Tables["species"].Rows.Count; i++)
            {
                if (textBox1.Text == d.ds.Tables["species"].Rows[i][1].ToString())
                {
                    MessageBox.Show("Field alredy exist !");
                    return;
                }

            }
            d.ds.Tables["species"].Rows.Add(d.lign);
            notifyIcon1.BalloonTipText = "Species Added successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
            dataGridView1.DataSource = d.ds.Tables["species"];
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select an species !");
                return;
            }
            for (int i = 0; i < d.ds.Tables["species"].Rows.Count; i++)
            {
                if (textBox1.Text == d.ds.Tables["species"].Rows[i][1].ToString())
                {
                    MessageBox.Show("Field alredy exist !");
                    return;
                }

            }
            bool tr = false;
            for (int i = 0; i < d.ds.Tables["species"].Rows.Count; i++)
            {
                if (dataGridView1.CurrentCell.Value.ToString() == d.ds.Tables["species"].Rows[i][1].ToString())
                {
                    tr = true;
                    d.ds.Tables["species"].Rows[i][1] = textBox1.Text;
                    notifyIcon1.BalloonTipText = "Species Modifyed successfully !";
                    notifyIcon1.BalloonTipTitle = "Notification";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.Icon = this.Icon;
                    notifyIcon1.ShowBalloonTip(1000);
                    dataGridView1.DataSource = d.ds.Tables["species"];
                    break;
                }

            }
            if (tr == false)
            {
                MessageBox.Show("Field don't exist !");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select an species !");
                return;
            }
            bool tr = false;
            for (int i = 0; i < d.ds.Tables["species"].Rows.Count; i++)
            {
                if (textBox1.Text == d.ds.Tables["species"].Rows[i][1].ToString())
                {
                    tr = true;
                    d.ds.Tables["species"].Rows[i].Delete();
                    notifyIcon1.BalloonTipText = "Species deleted successfully !";
                    notifyIcon1.BalloonTipTitle = "Notification";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.Icon = this.Icon;
                    notifyIcon1.ShowBalloonTip(1000);
                    dataGridView1.DataSource = d.ds.Tables["species"];
                    break;
                }

            }
            if (tr == false)
            {
                MessageBox.Show("Field don't exist !");
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            d.bc = new SqlCommandBuilder(d.dap);
            d.dap.Update(d.ds, "species");
            notifyIcon1.BalloonTipText = "Species saved successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
        }
    }
}
