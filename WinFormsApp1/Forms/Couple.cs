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
using System.Data.Common;

namespace WinFormsApp1.Forms
{
    public partial class Couple : Form
    {
        public Couple()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        ADO d = new ADO();
        SqlDataAdapter dap2;
        SqlCommandBuilder scb;
        SqlDataAdapter dp;
        DataSet df=new DataSet();
        BindingSource bs = new BindingSource();
        private void Couple_Load(object sender, EventArgs e)
        {
            d.connected();
            datacharge();
          
            clearf.Visible= false;
            clearm.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            
            
            
        }
        public void datacharge()
        {
            
            d.dap = new SqlDataAdapter("select * from bird inner join species on bird.id=species.id where species.species='@gender' and gender='Female' ", d.cn);
            d.dap.Fill(d.ds, "bird2");
            d.dap = new SqlDataAdapter("select * from species", d.cn);
            d.dap.Fill(d.ds, "species");
            dap2 = new SqlDataAdapter("select * from couple", d.cn);
            dp = new SqlDataAdapter("SELECT couple.id, couple.name, bird.name AS Male, bird_1.name AS female, couple.dateaccoup, species.species FROM     bird INNER JOIN couple ON bird.id = couple.idmale INNER JOIN bird AS bird_1 ON couple.idfemelle = bird_1.id INNER JOIN species ON bird.species = species.id AND bird_1.species = species.id", d.cn);
            dap2.Fill(d.ds, "couple");
            //dap2.Fill(d.ds, "couple3");
            
            dp.Fill(d.ds, "couple2");
            comboBox1.DataSource = d.ds.Tables["species"];
            comboBox1.DisplayMember = "species";
            comboBox1.ValueMember = "id";
            bs.DataSource = d.ds.Tables["couple2"];
            dataGridView1.DataSource = bs;
            //dataGridView1.Columns.Add("Name", "Name");
            //dataGridView1.Columns.Add("Species", "Species");
            //dataGridView1.Columns.Add("Male", "Male");
            //dataGridView1.Columns.Add("Female", "Female");
            //dataGridView1.Columns.Add("DateAcc", "DateAcc");
            //loaddatagridview();
        }
        public void loaddatagridview()
        {
            d.ds.Tables["couple2"].Clear();
            
            dp.Fill(d.ds, "couple2");
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int a, b;
        public void malelist()
        {
            if (d.ds.Tables["bird1"] != null)
            {
                d.ds.Tables["bird1"].Rows.Clear();
            }
            SqlCommand cm = new SqlCommand();
            cm.Connection = d.cn;
            cm.CommandText = "select * from bird inner join species on bird.species=species.id where species.species=@species  and gender='Male' ";
            cm.Parameters.AddWithValue("@species", comboBox1.Text);
            d.dap.SelectCommand = cm;
            d.dap.Fill(d.ds, "bird1");
            comboBox2.DataSource = d.ds.Tables["bird1"];
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";

        }
        public void femalelist()
        {
            if (d.ds.Tables["bird2"] != null)
            {
                d.ds.Tables["bird2"].Rows.Clear();
            }
            SqlCommand cm = new SqlCommand();
            cm.Connection = d.cn;
            cm.CommandText = "select * from bird inner join species on bird.species=species.id where species.species=@species  and gender='Female' ";
            cm.Parameters.AddWithValue("@species", comboBox1.Text);
            d.dap.SelectCommand = cm;
            d.dap.Fill(d.ds, "bird2");
            comboBox3.DataSource = d.ds.Tables["bird2"];
            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "id";

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(comboBox3.SelectedIndex);
            if (a<0)
            {
                return;
             }
            try
            {
                MemoryStream ms = new MemoryStream((byte[])d.ds.Tables["bird2"].Rows[a][7]);
           pictureBox1.Image = new Bitmap(ms);
            clearf.Visible = true;
             label8.Visible = true;
            }
            catch
            {
                return ;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(comboBox2.SelectedIndex);

            if (b < 0)
            {
                return;
            }
            try { 
            MemoryStream ms = new MemoryStream((byte[])d.ds.Tables["bird1"].Rows[b][7]);
                pictureBox2.Image = new Bitmap(ms);
            
            clearm.Visible = true;
            label7.Visible = true;
            }
            catch
            {
                return ;
            }
        }
        
        public void save(DataSet s,string tablename)
        {
            d.bc = new SqlCommandBuilder(dap2);
            dap2.Update(s, tablename);

           
        }
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            malelist();
            femalelist();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void clearf_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }
        

        private void button7_Click(object sender, EventArgs e)
        {
            df.RejectChanges();
           scb = new SqlCommandBuilder(dap2);
            dap2.Update(df, "couple");

            MessageBox.Show("all modification was cancelled !");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = String.Format("species LIKE '%{0}%' or name LIKE  '%{0}%' ", textBox2.Text);

        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("please enter a name");
                return;
            }
            for (int i = 0; i < d.ds.Tables["couple"].Rows.Count; i++)
            {
                if (textBox1.Text == d.ds.Tables["couple"].Rows[i][1].ToString())
                {
                    MessageBox.Show("please choose another name,this one already exist");
                    return;
                }
            }
            for (int i = 0; i < d.ds.Tables["couple"].Rows.Count; i++)
            {
                if (comboBox2.Text == d.ds.Tables["couple"].Rows[i][2].ToString() || comboBox3.Text == d.ds.Tables["couple"].Rows[i][3].ToString())
                {
                    MessageBox.Show("The Male or the Female  is already on another couple \n you must delete it from the couple list !");
                    return;
                }

            }
            d.lign = d.ds.Tables["couple"].NewRow();
            d.lign[1] = textBox1.Text;
            d.lign[2] = comboBox2.SelectedValue;
            d.lign[3] = comboBox3.SelectedValue;
            d.lign[4] = dateTimePicker1.Value.ToShortDateString();
            d.ds.Tables["couple"].Rows.Add(d.lign);

            save(d.ds, "couple");

            loaddatagridview();
            notifyIcon1.BalloonTipText = "Couple Added successfully !";
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the name of couple to update !");
            }
            for (int i = 0; i < d.ds.Tables["couple"].Rows.Count; i++)
            {
                // if(d.ds.Tables["couple"].Rows[i].RowState!= DataRowState.Deleted)
                // { 
                if (comboBox2.Text == d.ds.Tables["couple"].Rows[i][2].ToString() || comboBox3.Text == d.ds.Tables["couple"].Rows[i][3].ToString())
                {
                    MessageBox.Show("The Male or the Female  is already on another couple \n you must delete it from the couple list !");
                    return;
                }
                //}
                for (int v = 0; v < d.ds.Tables["couple"].Rows.Count; v++)
                {
                    if (d.ds.Tables["couple"].Rows[v][1].ToString() == textBox1.Text)
                    {


                        d.ds.Tables["couple"].Rows[v][1] = textBox1.Text;
                        d.ds.Tables["couple"].Rows[v][2] = comboBox2.SelectedValue;
                        d.ds.Tables["couple"].Rows[v][3] = comboBox3.SelectedValue;
                        d.ds.Tables["couple"].Rows[v][4] = dateTimePicker1.Value.ToShortDateString();


                        save(d.ds, "couple");
                        notifyIcon1.BalloonTipText = "Coupe updated successfully !";
                        notifyIcon1.BalloonTipTitle = "Notification";
                        notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                        notifyIcon1.Icon = this.Icon;
                        notifyIcon1.ShowBalloonTip(1000);
                        loaddatagridview();
                        return;
                    }
                }

            }
            MessageBox.Show("There is no couple with this name,please try again!");


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Make sure you choose the name of couple to delete !");
                return;
            }

            for (int i = 0; i < d.ds.Tables["couple"].Rows.Count; i++)
            {
                if (d.ds.Tables["couple"].Rows[i][1].ToString() == textBox1.Text)
                {
                    // d.ds.Tables["couple"].Rows[i].Delete();

                    d.ds.Tables["couple"].Rows[i].Delete();

                    save(d.ds, "couple");
                    loaddatagridview();
                    notifyIcon1.BalloonTipText = "Couple deleted successfully !";
                    notifyIcon1.BalloonTipTitle = "Notification";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.Icon = this.Icon;
                    notifyIcon1.ShowBalloonTip(1000);


                    return;
                }
            }
            MessageBox.Show("There is no couple with this name,please try again!");






        }

        private void Save_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox1.Image = null;
            clearf.Visible = false;
            label8.Visible = false;
            pictureBox2.Image = null;
            clearm.Visible = false;
            label7.Visible = false;
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            clearm.Visible = false;
            label7.Visible = false;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            clearf.Visible = false;
            label8.Visible = false;
        }


    } 
}
