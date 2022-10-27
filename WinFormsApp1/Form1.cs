using WinFormsApp1.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Xml;
using System.Drawing;
using System;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Random random;


        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            random = new Random();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
        }
       
        //List colors
        public static List<string> ColorList = new List<string>() { "#126881",
"#3F51B5",
"#721D47",
"#0E3441",
"#5A806B",
"#7A7572",
"#C2C2C2",
"#28656A",
"#E4126B",
"#7BCFE9",
"#9C27B0",
"#A12059",
"#DCC7AE",
"#F4E6E6"};
        public static List<string> ColorList2 = new List<string>() { "#01FFFF",
"#FFFF01",
"#00FFFF",
"#FF0000",
"#68F8FF",
"#68F800",
"#F0F0F0"};

        private string colorin()
        {
            int ind = random.Next(ColorList.Count);
            string colora = ColorList[ind];
            return colora;
        }
        private string colorin2()
        {
            int ind = random.Next(ColorList2.Count);
            string colorae = ColorList2[ind];
            return colorae;
        }

        private void ActivateButton(object senderBtn, Color color,Color color2)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = color;
                currentBtn.ForeColor = color2;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color2;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconform.IconChar = currentBtn.IconChar;
                iconform.IconColor = color2;
                panelTitel.BackColor = Color.FromArgb(72, 61, 139);
                label3.ForeColor = ColorTranslator.FromHtml(colorin2());
            }
            
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(72, 61, 139);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = currentBtn.BackColor;
            panelform.Controls.Add(childForm);
            panelform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelIcon.Text = childForm.Text;

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconform.IconChar = IconChar.Home;
            iconform.IconColor = Color.MediumPurple;
            labelIcon.Text = "Home";
        }


        
        //Reset
        private void pictureBox2_Click(object sender, EventArgs e)
        {

         if (currentChildForm != null)
         {
             currentChildForm.Close();
         }
         Reset();
        }
        


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     


        //Remove transparent border in maximized state
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        //Menu Button_Clicks
        private void btnBird_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorTranslator.FromHtml(colorin()), ColorTranslator.FromHtml(colorin2()));
            OpenChildForm(new Birds());
        }

        private void btnBreeder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorTranslator.FromHtml(colorin()), ColorTranslator.FromHtml(colorin2()));
            OpenChildForm(new Breeder());
        }

        private void btnSpecies_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorTranslator.FromHtml(colorin()), ColorTranslator.FromHtml(colorin2()));
            OpenChildForm(new Species());
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorTranslator.FromHtml(colorin()), ColorTranslator.FromHtml(colorin2()));
            OpenChildForm(new Invoices());
        }

        private void btnCouple_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorTranslator.FromHtml(colorin()), ColorTranslator.FromHtml(colorin2()));
            OpenChildForm(new Couple());
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, ColorTranslator.FromHtml(colorin()), ColorTranslator.FromHtml(colorin2()));
            OpenChildForm(new Production());
        }

        //Close-Maximize-Minimize
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnmax.IconChar = FontAwesome.Sharp.IconChar.Minimize;
            }
                
            else
            {
                WindowState = FormWindowState.Normal;
                btnmax.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            }
               
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Clock
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}