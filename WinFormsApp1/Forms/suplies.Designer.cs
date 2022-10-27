namespace WinFormsApp1.Forms
{
    partial class suplies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.Update = new FontAwesome.Sharp.IconButton();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.iconcancel = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Showlist = new FontAwesome.Sharp.IconButton();
            this.Addtoinvoice = new FontAwesome.Sharp.IconButton();
            this.cancel2 = new FontAwesome.Sharp.IconPictureBox();
            this.yes = new FontAwesome.Sharp.IconPictureBox();
            this.no = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Finished = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnshow = new FontAwesome.Sharp.IconButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(372, 123);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 27);
            this.numericUpDown1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(538, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(321, 182);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(372, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(526, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(321, 263);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Location = new System.Drawing.Point(6, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 307);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.Save.IconColor = System.Drawing.Color.Black;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.IconSize = 35;
            this.Save.Location = new System.Drawing.Point(6, 235);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 53);
            this.Save.TabIndex = 28;
            this.Save.Text = "Save";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Delete.IconColor = System.Drawing.Color.OrangeRed;
            this.Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Delete.IconSize = 35;
            this.Delete.Location = new System.Drawing.Point(6, 161);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 58);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "Delete";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.Update.IconColor = System.Drawing.Color.SteelBlue;
            this.Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Update.IconSize = 35;
            this.Update.Location = new System.Drawing.Point(6, 95);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(143, 50);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Add.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add.IconSize = 35;
            this.Add.Location = new System.Drawing.Point(6, 26);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 52);
            this.Add.TabIndex = 25;
            this.Add.Text = "Add";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // iconcancel
            // 
            this.iconcancel.BackColor = System.Drawing.Color.Transparent;
            this.iconcancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconcancel.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.iconcancel.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconcancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcancel.IconSize = 40;
            this.iconcancel.Location = new System.Drawing.Point(166, 175);
            this.iconcancel.Name = "iconcancel";
            this.iconcancel.Size = new System.Drawing.Size(40, 40);
            this.iconcancel.TabIndex = 39;
            this.iconcancel.TabStop = false;
            this.iconcancel.Click += new System.EventHandler(this.iconcancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(278, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Article :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(278, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Price :";
            // 
            // Showlist
            // 
            this.Showlist.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Showlist.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.Showlist.IconColor = System.Drawing.Color.DodgerBlue;
            this.Showlist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Showlist.IconSize = 35;
            this.Showlist.Location = new System.Drawing.Point(6, 72);
            this.Showlist.Name = "Showlist";
            this.Showlist.Size = new System.Drawing.Size(143, 54);
            this.Showlist.TabIndex = 42;
            this.Showlist.Text = "Show list";
            this.Showlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Showlist.UseVisualStyleBackColor = true;
            this.Showlist.Click += new System.EventHandler(this.Showlist_Click);
            // 
            // Addtoinvoice
            // 
            this.Addtoinvoice.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addtoinvoice.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.Addtoinvoice.IconColor = System.Drawing.Color.YellowGreen;
            this.Addtoinvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Addtoinvoice.IconSize = 35;
            this.Addtoinvoice.Location = new System.Drawing.Point(6, 140);
            this.Addtoinvoice.Name = "Addtoinvoice";
            this.Addtoinvoice.Size = new System.Drawing.Size(143, 45);
            this.Addtoinvoice.TabIndex = 43;
            this.Addtoinvoice.Text = "Add";
            this.Addtoinvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Addtoinvoice.UseVisualStyleBackColor = true;
            this.Addtoinvoice.Click += new System.EventHandler(this.Addtoinvoice_Click);
            // 
            // cancel2
            // 
            this.cancel2.BackColor = System.Drawing.SystemColors.Control;
            this.cancel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancel2.IconChar = FontAwesome.Sharp.IconChar.XmarkSquare;
            this.cancel2.IconColor = System.Drawing.SystemColors.ControlText;
            this.cancel2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancel2.IconSize = 40;
            this.cancel2.Location = new System.Drawing.Point(144, 143);
            this.cancel2.Name = "cancel2";
            this.cancel2.Size = new System.Drawing.Size(40, 40);
            this.cancel2.TabIndex = 0;
            this.cancel2.TabStop = false;
            this.cancel2.Click += new System.EventHandler(this.cancel2_Click);
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.ForeColor = System.Drawing.Color.Lime;
            this.yes.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.yes.IconColor = System.Drawing.Color.Lime;
            this.yes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yes.IconSize = 40;
            this.yes.Location = new System.Drawing.Point(865, 53);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(40, 40);
            this.yes.TabIndex = 44;
            this.yes.TabStop = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.Transparent;
            this.no.ForeColor = System.Drawing.Color.Red;
            this.no.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.no.IconColor = System.Drawing.Color.Red;
            this.no.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.no.IconSize = 40;
            this.no.Location = new System.Drawing.Point(865, 99);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(40, 40);
            this.no.TabIndex = 45;
            this.no.TabStop = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Finished);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.Addtoinvoice);
            this.groupBox1.Controls.Add(this.cancel2);
            this.groupBox1.Controls.Add(this.Showlist);
            this.groupBox1.Location = new System.Drawing.Point(17, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 297);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // Finished
            // 
            this.Finished.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Finished.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.Finished.IconColor = System.Drawing.Color.RoyalBlue;
            this.Finished.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Finished.IconSize = 40;
            this.Finished.Location = new System.Drawing.Point(6, 209);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(143, 40);
            this.Finished.TabIndex = 44;
            this.Finished.Text = "Finished";
            this.Finished.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Finished.UseVisualStyleBackColor = true;
            this.Finished.Click += new System.EventHandler(this.Finished_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnshow);
            this.groupBox3.Controls.Add(this.no);
            this.groupBox3.Controls.Add(this.yes);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.iconcancel);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(17, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(912, 316);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // btnshow
            // 
            this.btnshow.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnshow.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnshow.IconColor = System.Drawing.Color.Black;
            this.btnshow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnshow.Location = new System.Drawing.Point(372, 271);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(181, 38);
            this.btnshow.TabIndex = 46;
            this.btnshow.Text = "Already exist ?";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // suplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "suplies";
            this.Text = "suplies";
            this.Load += new System.EventHandler(this.suplies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconcancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton Delete;
        private FontAwesome.Sharp.IconButton Update;
        private FontAwesome.Sharp.IconButton Add;
        private FontAwesome.Sharp.IconPictureBox iconcancel;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton Showlist;
        private FontAwesome.Sharp.IconButton Addtoinvoice;
        private FontAwesome.Sharp.IconPictureBox cancel2;
        private FontAwesome.Sharp.IconPictureBox yes;
        private FontAwesome.Sharp.IconPictureBox no;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton Finished;
        private GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnshow;
        private NotifyIcon notifyIcon1;
    }
}