namespace WinFormsApp1
{
    partial class Species
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.Update = new FontAwesome.Sharp.IconButton();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(255, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(218, 328);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Location = new System.Drawing.Point(269, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 295);
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
            this.Save.Location = new System.Drawing.Point(6, 245);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(143, 44);
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
            this.Delete.IconColor = System.Drawing.Color.Black;
            this.Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Delete.IconSize = 35;
            this.Delete.Location = new System.Drawing.Point(6, 168);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(143, 49);
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
            this.Update.IconSize = 35;
            this.Update.Location = new System.Drawing.Point(6, 101);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(143, 41);
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
            this.Add.IconSize = 35;
            this.Add.Location = new System.Drawing.Point(6, 26);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 43);
            this.Add.TabIndex = 25;
            this.Add.Text = "Add";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Species Name :";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Species";
            this.Text = "Species";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton Delete;
        private FontAwesome.Sharp.IconButton Update;
        private FontAwesome.Sharp.IconButton Add;
        private Label label1;
        private NotifyIcon notifyIcon1;
    }
}