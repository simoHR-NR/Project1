namespace WinFormsApp1.Forms
{
    partial class Breeder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnadd = new FontAwesome.Sharp.IconButton();
            this.btnupdate = new FontAwesome.Sharp.IconButton();
            this.btndelete = new FontAwesome.Sharp.IconButton();
            this.btnsearch = new FontAwesome.Sharp.IconButton();
            this.bntcancel = new FontAwesome.Sharp.IconButton();
            this.filter = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(285, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(497, 300);
            this.dataGridView1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(119, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(119, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(119, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(119, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "First name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Last name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Adress :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "please select the breeder you want to delete !";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(442, 70);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "keyword(first name,adress,..)";
            this.textBox5.Size = new System.Drawing.Size(206, 27);
            this.textBox5.TabIndex = 22;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnadd.IconColor = System.Drawing.Color.Black;
            this.btnadd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnadd.Location = new System.Drawing.Point(285, 424);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(116, 55);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "Add";
            this.btnadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnupdate.IconColor = System.Drawing.Color.Black;
            this.btnupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnupdate.Location = new System.Drawing.Point(404, 424);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(116, 55);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btndelete.IconColor = System.Drawing.Color.Black;
            this.btndelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndelete.Location = new System.Drawing.Point(532, 424);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(116, 55);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "Delete";
            this.btndelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnsearch.IconColor = System.Drawing.Color.Black;
            this.btnsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsearch.Location = new System.Drawing.Point(666, 424);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(116, 55);
            this.btnsearch.TabIndex = 26;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // bntcancel
            // 
            this.bntcancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntcancel.BackColor = System.Drawing.Color.Transparent;
            this.bntcancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntcancel.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.bntcancel.IconColor = System.Drawing.Color.Black;
            this.bntcancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntcancel.Location = new System.Drawing.Point(321, 485);
            this.bntcancel.Name = "bntcancel";
            this.bntcancel.Size = new System.Drawing.Size(41, 46);
            this.bntcancel.TabIndex = 27;
            this.bntcancel.UseVisualStyleBackColor = false;
            this.bntcancel.Click += new System.EventHandler(this.bntcancel_Click);
            // 
            // filter
            // 
            this.filter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter.BackColor = System.Drawing.Color.Transparent;
            this.filter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.filter.IconColor = System.Drawing.SystemColors.ControlText;
            this.filter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filter.IconSize = 29;
            this.filter.Location = new System.Drawing.Point(654, 70);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(29, 29);
            this.filter.TabIndex = 28;
            this.filter.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 300);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Breeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.bntcancel);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Breeder";
            this.Text = "Breeder";
            this.Load += new System.EventHandler(this.Breeder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private FontAwesome.Sharp.IconButton btnadd;
        private FontAwesome.Sharp.IconButton btnupdate;
        private FontAwesome.Sharp.IconButton btndelete;
        private FontAwesome.Sharp.IconButton btnsearch;
        private FontAwesome.Sharp.IconButton bntcancel;
        private FontAwesome.Sharp.IconPictureBox filter;
        private GroupBox groupBox1;
        private NotifyIcon notifyIcon1;
    }
}