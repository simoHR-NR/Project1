namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnProduction = new FontAwesome.Sharp.IconButton();
            this.btnCouple = new FontAwesome.Sharp.IconButton();
            this.btnInvoice = new FontAwesome.Sharp.IconButton();
            this.btnSpecies = new FontAwesome.Sharp.IconButton();
            this.btnBreeder = new FontAwesome.Sharp.IconButton();
            this.btnBird = new FontAwesome.Sharp.IconButton();
            this.panelLG = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitel = new System.Windows.Forms.Panel();
            this.btnmin = new FontAwesome.Sharp.IconButton();
            this.btnmax = new FontAwesome.Sharp.IconButton();
            this.btnclose = new FontAwesome.Sharp.IconButton();
            this.labelIcon = new System.Windows.Forms.Label();
            this.iconform = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelform = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconform)).BeginInit();
            this.panelform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.Controls.Add(this.btnProduction);
            this.panelMenu.Controls.Add(this.btnCouple);
            this.panelMenu.Controls.Add(this.btnInvoice);
            this.panelMenu.Controls.Add(this.btnSpecies);
            this.panelMenu.Controls.Add(this.btnBreeder);
            this.panelMenu.Controls.Add(this.btnBird);
            this.panelMenu.Controls.Add(this.panelLG);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(248, 778);
            this.panelMenu.TabIndex = 7;
            // 
            // btnProduction
            // 
            this.btnProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduction.FlatAppearance.BorderSize = 0;
            this.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduction.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnProduction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduction.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnProduction.IconColor = System.Drawing.Color.Black;
            this.btnProduction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.Location = new System.Drawing.Point(0, 402);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(248, 53);
            this.btnProduction.TabIndex = 7;
            this.btnProduction.Text = "Production";
            this.btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduction.UseVisualStyleBackColor = true;
            this.btnProduction.Click += new System.EventHandler(this.btnProduction_Click);
            // 
            // btnCouple
            // 
            this.btnCouple.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCouple.FlatAppearance.BorderSize = 0;
            this.btnCouple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCouple.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCouple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCouple.IconChar = FontAwesome.Sharp.IconChar.Earlybirds;
            this.btnCouple.IconColor = System.Drawing.Color.Black;
            this.btnCouple.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCouple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCouple.Location = new System.Drawing.Point(0, 349);
            this.btnCouple.Name = "btnCouple";
            this.btnCouple.Size = new System.Drawing.Size(248, 53);
            this.btnCouple.TabIndex = 6;
            this.btnCouple.Text = "Couple";
            this.btnCouple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCouple.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCouple.UseVisualStyleBackColor = true;
            this.btnCouple.Click += new System.EventHandler(this.btnCouple_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoice.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btnInvoice.IconColor = System.Drawing.Color.Black;
            this.btnInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(0, 296);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(248, 53);
            this.btnInvoice.TabIndex = 5;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnSpecies
            // 
            this.btnSpecies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSpecies.FlatAppearance.BorderSize = 0;
            this.btnSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecies.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSpecies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpecies.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.btnSpecies.IconColor = System.Drawing.Color.Black;
            this.btnSpecies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSpecies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpecies.Location = new System.Drawing.Point(0, 243);
            this.btnSpecies.Name = "btnSpecies";
            this.btnSpecies.Size = new System.Drawing.Size(248, 53);
            this.btnSpecies.TabIndex = 4;
            this.btnSpecies.Text = "Species";
            this.btnSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpecies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpecies.UseVisualStyleBackColor = true;
            this.btnSpecies.Click += new System.EventHandler(this.btnSpecies_Click);
            // 
            // btnBreeder
            // 
            this.btnBreeder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBreeder.FlatAppearance.BorderSize = 0;
            this.btnBreeder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreeder.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBreeder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBreeder.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.btnBreeder.IconColor = System.Drawing.Color.Black;
            this.btnBreeder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBreeder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBreeder.Location = new System.Drawing.Point(0, 190);
            this.btnBreeder.Name = "btnBreeder";
            this.btnBreeder.Size = new System.Drawing.Size(248, 53);
            this.btnBreeder.TabIndex = 3;
            this.btnBreeder.Text = "Breeder";
            this.btnBreeder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBreeder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBreeder.UseVisualStyleBackColor = true;
            this.btnBreeder.Click += new System.EventHandler(this.btnBreeder_Click);
            // 
            // btnBird
            // 
            this.btnBird.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBird.FlatAppearance.BorderSize = 0;
            this.btnBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBird.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnBird.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBird.IconChar = FontAwesome.Sharp.IconChar.Dove;
            this.btnBird.IconColor = System.Drawing.Color.Black;
            this.btnBird.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBird.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBird.Location = new System.Drawing.Point(0, 137);
            this.btnBird.Name = "btnBird";
            this.btnBird.Size = new System.Drawing.Size(248, 53);
            this.btnBird.TabIndex = 2;
            this.btnBird.Text = "Bird";
            this.btnBird.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBird.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBird.UseVisualStyleBackColor = true;
            this.btnBird.Click += new System.EventHandler(this.btnBird_Click);
            // 
            // panelLG
            // 
            this.panelLG.Controls.Add(this.pictureBox2);
            this.panelLG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLG.Location = new System.Drawing.Point(0, 0);
            this.panelLG.Name = "panelLG";
            this.panelLG.Size = new System.Drawing.Size(248, 137);
            this.panelLG.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinFormsApp1.Properties.Resources.channels4_profile_copy;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelTitel
            // 
            this.panelTitel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTitel.Controls.Add(this.label3);
            this.panelTitel.Controls.Add(this.btnmin);
            this.panelTitel.Controls.Add(this.btnmax);
            this.panelTitel.Controls.Add(this.btnclose);
            this.panelTitel.Controls.Add(this.labelIcon);
            this.panelTitel.Controls.Add(this.iconform);
            this.panelTitel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitel.Location = new System.Drawing.Point(248, 0);
            this.panelTitel.Name = "panelTitel";
            this.panelTitel.Size = new System.Drawing.Size(1016, 86);
            this.panelTitel.TabIndex = 8;
            this.panelTitel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitel_MouseDown);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnmin.IconColor = System.Drawing.Color.Black;
            this.btnmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmin.IconSize = 30;
            this.btnmin.Location = new System.Drawing.Point(902, 3);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(30, 29);
            this.btnmin.TabIndex = 4;
            this.btnmin.UseVisualStyleBackColor = true;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.btnmax.IconColor = System.Drawing.Color.Black;
            this.btnmax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmax.IconSize = 30;
            this.btnmax.Location = new System.Drawing.Point(938, 3);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(30, 29);
            this.btnmax.TabIndex = 3;
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnclose.IconColor = System.Drawing.Color.Black;
            this.btnclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclose.IconSize = 40;
            this.btnclose.Location = new System.Drawing.Point(974, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 29);
            this.btnclose.TabIndex = 2;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // labelIcon
            // 
            this.labelIcon.AutoSize = true;
            this.labelIcon.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelIcon.Location = new System.Drawing.Point(52, 33);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(101, 35);
            this.labelIcon.TabIndex = 1;
            this.labelIcon.Text = "Home";
            // 
            // iconform
            // 
            this.iconform.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconform.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconform.IconSize = 40;
            this.iconform.Location = new System.Drawing.Point(6, 29);
            this.iconform.Name = "iconform";
            this.iconform.Size = new System.Drawing.Size(40, 40);
            this.iconform.TabIndex = 0;
            this.iconform.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(248, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 10);
            this.panel1.TabIndex = 9;
            // 
            // panelform
            // 
            this.panelform.BackColor = System.Drawing.Color.Lavender;
            this.panelform.Controls.Add(this.label2);
            this.panelform.Controls.Add(this.label1);
            this.panelform.Controls.Add(this.pictureBox1);
            this.panelform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelform.Location = new System.Drawing.Point(248, 96);
            this.panelform.Name = "panelform";
            this.panelform.Size = new System.Drawing.Size(1016, 682);
            this.panelform.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(17)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(366, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(17)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(363, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.channels4_profile_copy;
            this.pictureBox1.Location = new System.Drawing.Point(269, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(353, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "HR-Med Bird world";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 778);
            this.Controls.Add(this.panelform);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitel);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1282, 825);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitel.ResumeLayout(false);
            this.panelTitel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconform)).EndInit();
            this.panelform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnProduction;
        private FontAwesome.Sharp.IconButton btnCouple;
        private FontAwesome.Sharp.IconButton btnInvoice;
        private FontAwesome.Sharp.IconButton btnSpecies;
        private FontAwesome.Sharp.IconButton btnBreeder;
        private FontAwesome.Sharp.IconButton btnBird;
        private Panel panelLG;
        private Panel panelTitel;
        private FontAwesome.Sharp.IconPictureBox iconform;
        private Label labelIcon;
        private Panel panel1;
        private Panel panelform;
        private FontAwesome.Sharp.IconButton btnmin;
        private FontAwesome.Sharp.IconButton btnmax;
        private FontAwesome.Sharp.IconButton btnclose;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}