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
    public partial class Invoices : Form
    {
        ADO d = new ADO();
        DataSet ds, ds2, ds3;
        SqlDataAdapter dap, dap2, dap3;
        
        public Invoices()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            dap = new SqlDataAdapter();
            dap2 = new SqlDataAdapter();
            dap3 = new SqlDataAdapter();
            ds = new DataSet();
            ds2 = new DataSet();
            ds3 = new DataSet();
            d.connected();
            chargedata();
            printinv.Enabled = false;

        }

        // Get tables from database
        public void chargedata()
        {
            d.dap = new SqlDataAdapter("SELECT bird.id, bird.name, bird.price, species.species FROM  bird INNER JOIN  species ON bird.species = species.id", d.cn);
            d.dap.Fill(d.ds, "bird");
            d.dap = new SqlDataAdapter("select id,firstname+' '+lastname as 'Name',adress,phone from breeder", d.cn);
            d.dap.Fill(d.ds, "breeder");
            dap = new SqlDataAdapter("select * from invoice", d.cn);
            dap.Fill(ds, "invoice");
            listbreeder.DataSource = d.ds.Tables["breeder"];
            listbreeder.DisplayMember = "Name";
            listbreeder.ValueMember = "id";
            
            dap2 = new SqlDataAdapter("select * from purchasebird", d.cn);
           dap2.Fill(ds2, "purchasebird");
            dap3 = new SqlDataAdapter("select * from salebird", d.cn);
            dap3.Fill(ds3, "salebird");
        }
        string suppliesinvoice;
        double suppliesprice=0;
        string[] dx;


       // Save birds in purchase table

        public void savepurchase(int a)
        {
           
                
                foreach (int i in list)
                {
                d.lign = ds2.Tables["purchasebird"].NewRow();
                d.lign[0] = a;
                    d.lign[1] = i;
                   
                    ds2.Tables["purchasebird"].Rows.Add(d.lign);
                }
            d.bc = new SqlCommandBuilder(dap2);
            dap2.Update(ds2, "purchasebird");


        }

        // Save birds in purchase table
        public void savesale(int a)
        {
            
                
                foreach (int i in list)
                {
                    d.lign = ds3.Tables["salebird"].NewRow();
                    d.lign[0] = a;
                    d.lign[1] = i;
                    
                    ds3.Tables["salebird"].Rows.Add(d.lign);
                }
            d.bc = new SqlCommandBuilder(dap3);
            dap3.Update(ds3, "salebird");
           
        }

        // Check combobox selected
        public bool checkfield()
        {
            bool r = true ;
            if (typeop.Text == "" || listbreeder.Text == "")
            {
                MessageBox.Show("Select a type and the breeder name!");
                r = false;
            }

            return r;

        }
        //List to get Birds ID
           List<int> list = new List<int>();



        string h;

        //Save  Invoce before print
        private void Save_Click(object sender, EventArgs e)
        {

            d.lign = ds.Tables["invoice"].NewRow();
            d.lign[1] = typeop.Text;
            d.lign[2] = listbreeder.SelectedValue;
            d.lign[3] = suppliesinvoice;
            d.lign[4] = dateop.Value.ToShortDateString();
            d.lign[5] = calculatetotal();
            ds.Tables["invoice"].Rows.Add(d.lign);
            d.bc = new SqlCommandBuilder(dap);
            dap.Update(ds, "invoice");
            ds.Tables["invoice"].Clear();
            dap.Fill(ds, "invoice");
            int x = ds.Tables["invoice"].Rows.Count - 1;
            if (ds.Tables["invoice"].Rows[x][1].ToString() == "Purchase")
            {
                savepurchase(Convert.ToInt32(ds.Tables["invoice"].Rows[x][0]));
            }
            else
            {
                savesale(Convert.ToInt32(ds.Tables["invoice"].Rows[x][0]));
            }
            printinv.Enabled = true;
            notifyIcon1.BalloonTipText = "Invoice created successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);

        }

        // Select bird from a showdialog
        private void selecbird_Click(object sender, EventArgs e)
        {
            if (checkfield() == true)
            {
                list.Clear();
                if (typeop.Text == "Sale")
                {
                    h = "S";
                }
                else
                {
                    h = "P";
                }

                using (var fom = new selectbirds(h))
                {
                    var result = fom.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (fom.ls.Count == 0)
                            label9.Text = "No bird added";
                        else
                        {

                            foreach (int i in fom.ls)
                            {
                                list.Add(i);
                            }
                        }
                    }
                }
                int az = list.Count;
                label9.Text = az.ToString() + " Birds selected !";
            }
            else
                return;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        // Select Supplies from supplies window if exist
        private void Select_Click(object sender, EventArgs e)
        {
            using (var form = new suplies())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    suppliesinvoice = form.voi;
                    suppliesprice = form.poi;


                }
            }
            if (suppliesinvoice != null)
            {
                int sp = 0;
                dx = suppliesinvoice.Split(",");
                foreach (string d1 in dx)
                {
                    if (d1 != "")
                        sp++;
                }
                if (sp == 0)
                    label7.Text = "No articles selected";
                else
                    label7.Text = sp.ToString() + " articles selected";
            }
            else { label7.Text = "No articles selected"; }

        }
        //After Saving Invoice it can be printable
        private void printinv_Click(object sender, EventArgs e)
        {
            using (var form = new printinvoice())
            {

                int x = ds.Tables["invoice"].Rows.Count - 1;
                if (ds.Tables["invoice"].Rows[x][1].ToString() == "Purchase")
                { form.a8 = "#P" + ds.Tables["invoice"].Rows[x][0].ToString(); }
                else
                {
                    form.a8 = "#S" + ds.Tables["invoice"].Rows[x][0].ToString();
                }
                form.a9 = DateTime.Parse(ds.Tables["invoice"].Rows[x][4].ToString()).ToShortDateString();
                for (int i = 0; i < d.ds.Tables["breeder"].Rows.Count; i++)
                {
                    if (d.ds.Tables["breeder"].Rows[i][0].ToString() == ds.Tables["invoice"].Rows[x][2].ToString())
                    {
                        form.a3 = d.ds.Tables["breeder"].Rows[i][1].ToString();
                        form.a4 = d.ds.Tables["breeder"].Rows[i][2].ToString();
                        form.a5 = d.ds.Tables["breeder"].Rows[i][3].ToString();

                    }

                }
                foreach (int g in list)
                {
                    for (int j = 0; j < d.ds.Tables["bird"].Rows.Count; j++)
                    {
                        if (Convert.ToInt32(d.ds.Tables["bird"].Rows[j][0]) == g)
                        {
                            form.dataGridView1.Rows.Add(d.ds.Tables["bird"].Rows[j][1], d.ds.Tables["bird"].Rows[j][3], d.ds.Tables["bird"].Rows[j][2]);
                        }

                    }
                }


                form.a11 = suppliesprice.ToString();

                form.a1 = calculatetotal().ToString();
                if (suppliesinvoice != null)
                {
                    form.a7 = suppliesinvoice.ToString();
                    string[] supp = suppliesinvoice.Split(',');
                    foreach (string r in supp)
                    {
                        if (r != "")
                            form.listView1.Items.Add(r);
                    }
                }
                else
                    form.listView1.BackColor = Color.Gray;


                form.ShowDialog();
                printinv.Enabled = false;
            }

        }



        //Calculate the total (supplies+birds)

        public double calculatetotal()
        {
            double a = 0;
            foreach (int i in list)
            {
                for (int j = 0; j < d.ds.Tables["bird"].Rows.Count; j++)
                {
                    if (Convert.ToInt32(d.ds.Tables["bird"].Rows[j][0]) == i)
                    {
                        a += Convert.ToDouble(d.ds.Tables["bird"].Rows[j][2]);
                    }
                }
            }
            a += suppliesprice;
            return a;
        }

        private void bntcalculate_Click(object sender, EventArgs e)
        {
            lbTotal.Text = calculatetotal().ToString()+" DH";
        }




 
    }
}
