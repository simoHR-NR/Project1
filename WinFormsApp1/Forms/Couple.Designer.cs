namespace WinFormsApp1.Forms
{
    partial class Couple
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Clear = new FontAwesome.Sharp.IconButton();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.Update = new FontAwesome.Sharp.IconButton();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.clearf = new FontAwesome.Sharp.IconPictureBox();
            this.clearm = new FontAwesome.Sharp.IconPictureBox();
            this.filter = new FontAwesome.Sharp.IconPictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clearf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(314, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(132, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 275);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(42, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Location = new System.Drawing.Point(264, 335);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(757, 434);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(314, 235);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(132, 28);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(217, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Species :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Male :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(217, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Female :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(219, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(470, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 35);
            this.label7.TabIndex = 20;
            this.label7.Text = "M";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 35);
            this.label8.TabIndex = 21;
            this.label8.Text = "F";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(689, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Filter by species";
            this.textBox2.Size = new System.Drawing.Size(316, 27);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Clear);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Location = new System.Drawing.Point(23, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 271);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.Clear.IconColor = System.Drawing.Color.Black;
            this.Clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clear.Location = new System.Drawing.Point(6, 209);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(143, 50);
            this.Clear.TabIndex = 28;
            this.Clear.Text = "Clear";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Delete.IconColor = System.Drawing.Color.Black;
            this.Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Delete.Location = new System.Drawing.Point(6, 142);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 51);
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
            this.Update.IconColor = System.Drawing.Color.Black;
            this.Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Update.Location = new System.Drawing.Point(6, 86);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(143, 47);
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
            this.Add.IconColor = System.Drawing.Color.Black;
            this.Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add.Location = new System.Drawing.Point(6, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 48);
            this.Add.TabIndex = 25;
            this.Add.Text = "Add";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // clearf
            // 
            this.clearf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearf.BackColor = System.Drawing.Color.Transparent;
            this.clearf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearf.IconChar = FontAwesome.Sharp.IconChar.X;
            this.clearf.IconColor = System.Drawing.SystemColors.ControlText;
            this.clearf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearf.IconSize = 24;
            this.clearf.Location = new System.Drawing.Point(10, 335);
            this.clearf.Name = "clearf";
            this.clearf.Size = new System.Drawing.Size(26, 24);
            this.clearf.TabIndex = 38;
            this.clearf.TabStop = false;
            this.clearf.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // clearm
            // 
            this.clearm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearm.BackColor = System.Drawing.Color.Transparent;
            this.clearm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearm.IconChar = FontAwesome.Sharp.IconChar.X;
            this.clearm.IconColor = System.Drawing.SystemColors.ControlText;
            this.clearm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearm.IconSize = 24;
            this.clearm.Location = new System.Drawing.Point(469, 335);
            this.clearm.Name = "clearm";
            this.clearm.Size = new System.Drawing.Size(26, 24);
            this.clearm.TabIndex = 39;
            this.clearm.TabStop = false;
            this.clearm.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // filter
            // 
            this.filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter.BackColor = System.Drawing.Color.Transparent;
            this.filter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.filter.IconColor = System.Drawing.SystemColors.ControlText;
            this.filter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filter.IconSize = 27;
            this.filter.Location = new System.Drawing.Point(1011, 28);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(35, 27);
            this.filter.TabIndex = 40;
            this.filter.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Couple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 520);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.clearm);
            this.Controls.Add(this.clearf);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Couple";
            this.Text = "Couple";
            this.Load += new System.EventHandler(this.Couple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clearf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private ComboBox comboBox3;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton Clear;
        private FontAwesome.Sharp.IconButton Delete;
        private FontAwesome.Sharp.IconButton Update;
        private FontAwesome.Sharp.IconButton Add;
        private FontAwesome.Sharp.IconPictureBox clearf;
        private FontAwesome.Sharp.IconPictureBox clearm;
        private FontAwesome.Sharp.IconPictureBox filter;
        private NotifyIcon notifyIcon1;
    }
}