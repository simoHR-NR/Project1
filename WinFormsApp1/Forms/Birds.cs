using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Birds : Form
    {
        public Birds()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }
        ADO d = new ADO();
        public static int a;
        private void Birds_Load(object sender, EventArgs e)
        {
            d.connected();
            getspecies();
            getbirdsinfo();
            getbirds();
            iconcolor();
        }

        // Iconbutton color
        // 
        public void iconcolor()
        {
            Add.IconColor = this.BackColor;
            Delete.IconColor = this.BackColor;
            Update.IconColor = this.BackColor;
            Save.IconColor = this.BackColor;
            Select.IconColor = this.BackColor;
            next.IconColor = this.BackColor;
            previous.IconColor = this.BackColor;
            last.IconColor = this.BackColor;
            first.IconColor = this.BackColor;
        }

        // Species data load

        public void getspecies()
        {
            d.dap = new SqlDataAdapter("select * from species", d.cn);
            d.dap.Fill(d.ds, "species");
            specieslist.DataSource = d.ds.Tables["species"];
            specieslist.DisplayMember = "species";
            specieslist.ValueMember = "id";

        }

        // Bird data load
        public void getbirdsinfo()
        {
            d.dap = new SqlDataAdapter("select * from bird", d.cn);
            d.dap.Fill(d.ds, "bird");
        }

        public void getbirds()
        {
            label12.Text = d.ds.Tables["bird"].Rows[a][1].ToString();
            for (int i = 0; i < d.ds.Tables["species"].Rows.Count; i++)
            {
                if (d.ds.Tables["bird"].Rows[a][2].ToString() == d.ds.Tables["species"].Rows[i][0].ToString())
                {
                    label2.Text = d.ds.Tables["species"].Rows[i][1].ToString();
                }
            }
            label4.Text = d.ds.Tables["bird"].Rows[a][3].ToString();
            label6.Text = d.calculateage(d.ds.Tables["bird"].Rows[a][4].ToString()).ToString();
            if (d.ds.Tables["bird"].Rows[a][5].GetHashCode() == 1)
            {
                label8.Text = "Yes";
                label10.Visible = true;
                label9.Visible = true;
                label10.Text = d.ds.Tables["bird"].Rows[a][6].ToString();
            }
            else
            {
                label8.Text = "No";
                label10.Visible = false;
                label9.Visible = false;
            }
            try {
                MemoryStream ms = new MemoryStream((byte[])d.ds.Tables["bird"].Rows[a][7]);
                pictureBox1.Image = new Bitmap(ms);
            }
            catch
            {
                pictureBox1.Load("bird.jpg");
            }
            label14.Text = d.ds.Tables["bird"].Rows[a][8].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            d.ds.Tables["bird"].AcceptChanges();

        }

        public bool checkfield()
        {
            if (textBox1.Text == "" || specieslist.Text == "" || Genderlist.Text == "")
                return false;
            else
                return true;
        }


        Image img;

        //Add new Bird
        private void Add_Click(object sender, EventArgs e)
        {
            if (checkfield()==false)
            {
                notifyIcon1.BalloonTipText = "PLease make sure you entred all information !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);

            }
            
            ImageConverter con = new ImageConverter();
            byte[] imgbyte = (byte[])con.ConvertTo(img, typeof(byte[]));
            d.lign = d.ds.Tables["bird"].NewRow();
            d.lign[1] = textBox2.Text;
            d.lign[2] = specieslist.SelectedValue;
            d.lign[3] = Genderlist.SelectedItem;
            d.lign[4] = dateTimePicker1.Value.ToShortDateString();
            if (checkBox1.Checked)
            {
                d.lign[5] = 1;
                d.lign[6] = textBox1.Text;
            }
            else d.lign[5] = 0;
            d.lign[7] = imgbyte;
            d.lign[8] = numericUpDown1.Value;
            d.ds.Tables["bird"].Rows.Add(d.lign);
        }

        //Update Bird
        private void Update_Click(object sender, EventArgs e)
        {
            d.ds.Tables["bird"].Rows[a][1] = textBox2.Text;
            d.ds.Tables["bird"].Rows[a][2] = specieslist.SelectedValue;
            d.ds.Tables["bird"].Rows[a][3] = Genderlist.SelectedItem;
            d.ds.Tables["bird"].Rows[a][4] = dateTimePicker1.Value.ToShortDateString();
            if (checkBox1.Checked)
            {
                d.ds.Tables["bird"].Rows[a][5] = true;
                d.ds.Tables["bird"].Rows[a][6] = textBox1.Text;
            }
            else
            { d.ds.Tables["bird"].Rows[a][5] = false; }


            ImageConverter con = new ImageConverter();
            byte[] imgbyte = (byte[])con.ConvertTo(img, typeof(byte[]));
            d.ds.Tables["bird"].Rows[a][7] = imgbyte;
            d.ds.Tables["bird"].Rows[a][8] = numericUpDown1.Value;

        }

        //Delete Bird
        private void Delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realy you want to delete this bird?");
            d.ds.Tables["bird"].Rows[a].Delete();


            if (a >= 0)
            {
                a++;
                getbirds();
            }
            else if (a == d.ds.Tables["bird"].Rows.Count - 1)
            {
                a--;
                getbirds();

            }
        }

        //Save all changes (disconnected mode)
        private void Save_Click(object sender, EventArgs e)
        {

            d.bc = new SqlCommandBuilder(d.dap);
            d.dap.Update(d.ds, "bird");
            MessageBox.Show("Data saved successfully !");
        }

        //Select Picture of Bird
        private void Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(op.FileName);
                img = Image.FromFile(op.FileName);
            }
        }

        // Navigation Buttons
        private void first_Click(object sender, EventArgs e)
        {
            a = 0;
            getbirds();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            try
            {
                a--;
                getbirds();

            }
            catch
            {
                
                notifyIcon1.BalloonTipText = "This is the first bird in list !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);    
                a++;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                a++;
                getbirds();

            }
            catch
            {
                notifyIcon1.Text = "This is the last bird in list !";
                notifyIcon1.BalloonTipText = "This is the last bird in list !";
                notifyIcon1.BalloonTipTitle = "Notification";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Icon = this.Icon;
                notifyIcon1.ShowBalloonTip(1000);
                a--;
            }
        }

        private void last_Click(object sender, EventArgs e)
        {
            a = d.ds.Tables["bird"].Rows.Count - 1;
            getbirds();
        }
    }
}
