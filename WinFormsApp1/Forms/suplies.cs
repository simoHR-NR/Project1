using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace WinFormsApp1.Forms
{
    public partial class suplies : Form
    {
      
        public suplies()
        {
            InitializeComponent();
            
            
        }
        public Invoices inv1;
        ADO d = new ADO();

        public string voi { get; set; }
        public double poi { get; set; }


        //Button and Checkbox to use in the datagridview
        DataGridViewButtonColumn dbtc = new DataGridViewButtonColumn();
        DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
        DataGridViewCheckBoxColumn c2 = new DataGridViewCheckBoxColumn();
        
        private void suplies_Load(object sender, EventArgs e)
        {
            d.connected();
            d.dap = new SqlDataAdapter("select * from supplies", d.cn);
            d.dap.Fill(d.ds, "supplies");
            dataGridView1.Columns.Add("Item", "Item");
            dataGridView1.Columns.Add("Price", "Price");
            iconcancel.Visible = false;
            dataGridView2.Visible = false;
            yes.Visible = false;
            no.Visible = false;
            Update.Visible= false;
            Delete.Visible = false;
            Save.Visible = false;
            groupBox1.Visible = false;
            reloaddatagridview();
            dbtc.UseColumnTextForButtonValue = true;
            dbtc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dbtc.FlatStyle = FlatStyle.Standard;
            dbtc.CellTemplate.Style.BackColor = Color.Honeydew;
            Addtoinvoice.Enabled = false;
            cancel2.Enabled = false;
            Finished.Enabled = false;

        }




        


        // Make the datagridview updated
        public void reloaddatagridview()
        {
            
            DataTable rt = new DataTable();
            rt.Columns.Add("ID");
            rt.Columns.Add("Supplies");
            rt.Columns.Add("Price");
            DataRow dt;
            if (d.ds.Tables["supplies"].Rows.Count > 11)
            {


                for (int i = d.ds.Tables["supplies"].Rows.Count - 11; i < d.ds.Tables["supplies"].Rows.Count; i++)
                {

                      rt.Rows.Add(d.ds.Tables["supplies"].Rows[i]);
                }

            }
            else
            {
                for (int i = 0; i < d.ds.Tables["supplies"].Rows.Count; i++)
                {
                   
                    dt = rt.NewRow();
                    dt[0] = d.ds.Tables["supplies"].Rows[i][0];
                    dt[1] = d.ds.Tables["supplies"].Rows[i][1];
                    dt[2] = d.ds.Tables["supplies"].Rows[i][2];
                    rt.Rows.Add(dt);
                }
            }
            dataGridView2.DataSource = rt;
            
            dbtc.Text = "modify";
            dbtc.HeaderText = "update";
            c2.HeaderText = "add to invoice";
            c2.Name = "add to invoice";
            c2.TrueValue = true;
            c2.FalseValue = false;
            dataGridView2.Columns.Add(dbtc);
            dataGridView2.Columns.Add(c2);
            dataGridView2.Columns["add to invoice"].DisplayIndex = 4;
            dataGridView2.Columns[4].Visible = false;

        }

        //show supplies selected in the First list(datagridview1)to modify on it
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && dbtc.Text == "modify")
            {
                
                dbtc.Text = "Ok"; 
                yes.Visible = true;
                no.Visible = true;
                dataGridView1.Rows.Clear();

                string val = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                int vap = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value);
                string[] valtb = val.Split(',');

                foreach (string el in valtb)
                {
                    if (el != "")
                        dataGridView1.Rows.Add(el, 0);
                }
                

            }
        
            else
            {
                return;
            }
        }


  



        //Apply changes on the supplies selected and show it in the second list(Datagridview2)
        public void ok()
        {
            dbtc.Text = "modify";
            for (int i = 0; i < d.ds.Tables["supplies"].Rows.Count; i++)
            {
                if (d.ds.Tables["supplies"].Rows[i][0].ToString() == dataGridView2.CurrentRow.Cells[0].Value)
                {
                    string sup = "";
                    int pr = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        sup = sup + row.Cells[0].Value + ",";
                        pr = pr + Convert.ToInt32(row.Cells[1].Value);
                    }
                    d.ds.Tables["supplies"].Rows[i][1] = sup;
                    d.ds.Tables["supplies"].Rows[i][2] = pr;
                    d.bc = new SqlCommandBuilder(d.dap);
                    d.dap.Update(d.ds, "supplies");
                    dataGridView1.Rows.Clear();
                    d.ds.Tables["supplies"].Clear();
                    d.dap.Fill(d.ds, "supplies");
                    dataGridView2.Columns.Remove(dbtc);
                    dataGridView2.Columns.Remove(c2);
                    reloaddatagridview();
                    break;
                }



            }
        }

        private void yes_Click(object sender, EventArgs e)
        {
            ok();
            notifyIcon1.BalloonTipText = "Modifyed successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
            yes.Visible = false;
            no.Visible = false;
        }

        private void no_Click(object sender, EventArgs e)
        {
            dbtc.Text = "modify";
            dataGridView1.Rows.Clear();
            yes.Visible = false;
            no.Visible = false;
        }

          // Button add,update,delete and save
        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("There is an empty field !");
                return;
            }
            dataGridView1.Rows.Add(textBox1.Text, numericUpDown1.Value);
            Update.Visible = true;
            Delete.Visible = true;
            Save.Visible = true;
            notifyIcon1.BalloonTipText = "Added successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Update_Click(object sender, EventArgs e)
        {

            if (Update.Text == "Update")
            {
                Update.Text = "OK";
                label1.Visible = true;
                label1.Text = "You can modifie any field by selecting it and write the value\nwhen you finished just click on OK !";

            }
            else
            {
                Update.Text = "Update";
                label1.Visible = false;
                notifyIcon1.BalloonTipText = "Modifyed successfully !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (Delete.Text == "Delete")
            {
                iconcancel.Visible = true;
                Delete.Text = "Confirm";

                c.HeaderText = "delete";

                dataGridView1.Columns.Add(c);
                dataGridView1.Columns[2].Visible = true;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (Convert.ToBoolean(row.Cells[2].Value) == true)
                    {
                        dataGridView1.Rows.Remove(row);

                    }

                }
                iconcancel.Visible = false;
                Delete.Text = "Delete";
                dataGridView1.Columns.Remove(c);
                notifyIcon1.BalloonTipText = "Deleted successfully !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            d.lign = d.ds.Tables["supplies"].NewRow();
            string sup = "";
            int pr = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                sup = sup + row.Cells[0].Value + ",";
                pr = pr + Convert.ToInt32(row.Cells[1].Value);
            }
            d.lign[1] = sup;
            d.lign[2] = pr;
            d.ds.Tables["supplies"].Rows.Add(d.lign);
            d.bc = new SqlCommandBuilder(d.dap);
            d.dap.Update(d.ds, "supplies");
            d.ds.Tables["supplies"].Clear();
            d.dap.Fill(d.ds, "supplies");
            dataGridView2.Columns.Remove(dbtc);
            dataGridView2.Columns.Remove(c2);
            reloaddatagridview();
            notifyIcon1.BalloonTipText = "Saved successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void iconcancel_Click(object sender, EventArgs e)
        {
            iconcancel.Visible = false;
            Delete.Text = "Delete";
            dataGridView1.Columns.Remove(c);
        }

        //Show the second list contains the last 10 Supplies
        private void Showlist_Click(object sender, EventArgs e)
        {
            if (Showlist.Text == "Show list")
            {
                Addtoinvoice.Enabled = true;
                cancel2.Enabled = true;
                Finished.Enabled=true;
                dataGridView2.Visible = true;
                Showlist.Text = "Hide list";
                Showlist.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                Showlist.Text = "Show list";
                Addtoinvoice.Enabled = false;
                cancel2.Enabled = false;
                Finished.Enabled = false;
                dataGridView2.Visible = false;
                Showlist.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }
        //Select the articles to return it to invoice window
        private void Addtoinvoice_Click(object sender, EventArgs e)
        {

            if (Addtoinvoice.Text == "Add")
            {
                Addtoinvoice.Text = "Ok";
                dataGridView2.Columns[4].Visible = true;
                cancel2.Visible = true;
            }
            else
            {


                
                    Addtoinvoice.Text = "Add";
                    dataGridView2.Columns[4].Visible = false;
                    cancel2.Visible=false;

                
                


            }
        }

        //Cancel and deselect all supplies selected
        private void cancel2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    row.Cells[4].Value = false;
                
            }
                    Addtoinvoice.Text = "Add";
            dataGridView2.Columns[4].Visible = false;
            cancel2.Visible = false;
        }


        //close the window and return supplies and prices(if selected) to Invoice window
        private void Finished_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                {

                    voi = row.Cells[1].Value.ToString() + "," + voi;
                    poi = Convert.ToDouble(row.Cells[2].Value) + poi;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //show second list
        private void btnshow_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
