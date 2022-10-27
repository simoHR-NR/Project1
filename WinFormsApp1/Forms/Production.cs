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
using System.Windows.Media.Media3D;

namespace WinFormsApp1.Forms
{
    public partial class Production : Form
    {
        public Production()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        ADO d= new ADO();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        SqlDataAdapter dap = new SqlDataAdapter();
        SqlDataAdapter dap2 = new SqlDataAdapter();
        private void Production_Load(object sender, EventArgs e)
        {
            d.connected();
            getspecies();
            
            dap = new SqlDataAdapter("select * from nest",d.cn);
            dap.Fill(ds, "nest");
            dap2 = new SqlDataAdapter("select nest.id, couple.name, nest.eaggsnbr, nest.date, nest.nbrbirdsuccess FROM couple INNER JOIN  nest ON couple.id = nest.couple", d.cn);
            dap2.Fill(ds2, "Nes");
            label6.Visible = false;
            label7.Visible = false;
            dataGridView1.Visible = false;
            
            dataGridView1.DataSource = ds2.Tables["Nes"];
            dataGridView1.Columns[0].Visible = false;
            btnupdate.Enabled = false;

        }
        
        public void getspecies()
        {
            d.dap = new SqlDataAdapter("select * from species",d.cn);
            d.dap.Fill(d.ds, "species");
            listspecies.DataSource = d.ds.Tables["species"];
            listspecies.DisplayMember = "species";
            listspecies.ValueMember = "id";
        }
        public void getscouple()
        {

            foreach(DataTable dt in d.ds.Tables)
            {
                if(dt.TableName.Contains("Bird")==false)
                {
                    SqlCommand cmd = new SqlCommand("SELECT couple.id AS id,couple.name as name, bird.name AS Male,bird.picture as picture1, bird_1.name AS Female,bird_1.picture AS picture2 FROM bird INNER JOIN couple ON bird.id = couple.idmale AND bird.gender = 'Male' INNER JOIN  bird AS bird_1 ON  couple.idfemelle = bird_1.id AND bird_1.gender = 'Female'   where bird.species="+ listspecies.SelectedValue, d.cn);
                    d.dap = new SqlDataAdapter(cmd);
                    d.dap.Fill(d.ds, "Bird");
                    listcouple.DataSource = d.ds.Tables["Bird"];
                    listcouple.DisplayMember = "name";
                    listcouple.ValueMember = "id";
                }
                else
                {
                    d.ds.Tables["Bird"].Rows.Clear();
                    d.dap.Fill(d.ds, "Bird");
                    listcouple.DataSource = d.ds.Tables["Bird"];
                    listcouple.DisplayMember = "name";
                    listcouple.ValueMember = "id";
                }

            }
   
        }

        private void listspecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {getscouple(); }
            catch { return; }
          
        }

        private void listcouple_SelectedIndexChanged(object sender, EventArgs e)
        {
              try
              {
                
                for (int i=0;i< d.ds.Tables["Bird"].Rows.Count;i++)
                    if(Convert.ToInt32(d.ds.Tables["Bird"].Rows[i][0])== Convert.ToInt32(listcouple.SelectedValue))
                    {
                     //label6.Text = d.ds.Tables["Bird"].Rows[0][5].ToString()+" "+d.ds.Tables["Bird"].Rows[0][4].ToString() ;
                     MemoryStream ms = new MemoryStream((byte[])d.ds.Tables["Bird"].Rows[i][3]);
                     pictureBox1.Image = new Bitmap(ms);
                     MemoryStream ms2 = new MemoryStream((byte[])d.ds.Tables["Bird"].Rows[i][5]);
                     pictureBox2.Image = new Bitmap(ms2);
                        label6.Visible = true;
                        label7.Visible = true;
                        btnupdate.Enabled = true;
                    }
                
              }
              catch
              {
                  pictureBox1.Load("bird.jpg");
                  pictureBox2.Load("bird.jpg");
              }
            //label6.Text = listcouple.SelectedValue.ToString();
        }
    
        private bool checkfield()
        {
            if (listspecies.Text == "" || listcouple.Text == "")
                return true;
            else
                return false;
        }

        //Add a new Nest data
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(checkfield())
            {
                MessageBox.Show("Please select species and couple!");
            }
            else
            { 
            d.lign = ds.Tables["nest"].NewRow();
            d.lign[1]=listcouple.SelectedValue;
            d.lign[2] = numericUpDown1.Value;
            d.lign[3] = dateTimePicker1.Value.ToShortDateString();
            d.lign[4] = numericUpDown2.Value;
            ds.Tables["nest"].Rows.Add(d.lign);
            d.bc = new SqlCommandBuilder(dap);
            dap.Update(ds, "nest");
            notifyIcon1.Text = "saved !";
            ds.Tables["nest"].Rows.Clear();
            ds2.Tables["Nes"].Rows.Clear();
            dap.Fill(ds, "nest");
            dap2.Fill(ds2, "Nes");
            dataGridView1.DataSource = ds2.Tables["Nes"];
                notifyIcon1.BalloonTipText = "Nest added successfully !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if(btnupdate.Text== "Update")
            {
                btnupdate.Text = "Done!";
              dataGridView1.Visible = true;
               ds2.Tables["Nes"].DefaultView.RowFilter = String.Format("name='" + listcouple.Text+"'");

            }
            else
            {
                
               for(int i=0; i < ds.Tables["nest"].Rows.Count; i++)
               {
                    foreach (DataGridViewRow dr in dataGridView1.Rows)
                    {

                        if (Convert.ToInt32(ds.Tables["nest"].Rows[i][0]) == Convert.ToInt32(dr.Cells[0].Value))
                   {
                            if(Convert.ToInt32(dr.Cells[4].Value) > Convert.ToInt32(dr.Cells[2].Value))
                            {
                                MessageBox.Show("The success birds number chould be less than eggs number!");
                                return;
                            }
                            else
                            {
                                 ds.Tables["nest"].Rows[i][2] = dr.Cells[2].Value;
                                 ds.Tables["nest"].Rows[i][3] = dr.Cells[3].Value;
                                 ds.Tables["nest"].Rows[i][4] = dr.Cells[4].Value;
                            }
                       
                   }
               }
                }
                
                btnupdate.Text = "Update";
                d.bc = new SqlCommandBuilder(dap);
                dap.Update(ds, "nest");
                dataGridView1.Visible = false;
                ds.Tables["nest"].Rows.Clear();
                dap.Fill(ds, "nest");
                ds2.Tables["Nes"].Rows.Clear();
                dap2.Fill(ds2, "Nes");
                ds2.Tables["Nes"].DefaultView.RowFilter = String.Format("name='" + listcouple.Text + "'");
                notifyIcon1.BalloonTipText = "Nest Modifyed successfully !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);

            }
          
        }
    }
}
