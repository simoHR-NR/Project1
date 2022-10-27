namespace WinFormsApp1
{
    partial class Birds
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.last = new FontAwesome.Sharp.IconButton();
            this.next = new FontAwesome.Sharp.IconButton();
            this.previous = new FontAwesome.Sharp.IconButton();
            this.first = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Genderlist = new System.Windows.Forms.ComboBox();
            this.specieslist = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.Delete = new FontAwesome.Sharp.IconButton();
            this.Update = new FontAwesome.Sharp.IconButton();
            this.Add = new FontAwesome.Sharp.IconButton();
            this.Select = new FontAwesome.Sharp.IconButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.last);
            this.groupBox1.Controls.Add(this.next);
            this.groupBox1.Controls.Add(this.previous);
            this.groupBox1.Controls.Add(this.first);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(582, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 502);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // last
            // 
            this.last.IconChar = FontAwesome.Sharp.IconChar.ForwardFast;
            this.last.IconColor = System.Drawing.Color.Black;
            this.last.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.last.Location = new System.Drawing.Point(330, 17);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(52, 46);
            this.last.TabIndex = 32;
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            this.next.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.next.IconColor = System.Drawing.Color.Black;
            this.next.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.next.Location = new System.Drawing.Point(253, 17);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(47, 46);
            this.next.TabIndex = 31;
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.previous.IconColor = System.Drawing.Color.Black;
            this.previous.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.previous.Location = new System.Drawing.Point(169, 18);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(48, 45);
            this.previous.TabIndex = 30;
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // first
            // 
            this.first.IconChar = FontAwesome.Sharp.IconChar.FastBackward;
            this.first.IconColor = System.Drawing.Color.Black;
            this.first.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.first.Location = new System.Drawing.Point(84, 17);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(48, 46);
            this.first.TabIndex = 29;
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 29);
            this.label14.TabIndex = 28;
            this.label14.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(281, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Price :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 29);
            this.label12.TabIndex = 26;
            this.label12.Text = "label12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(30, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Species :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(278, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "RingRef :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(278, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ring :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 27);
            this.textBox1.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(368, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 24);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Ring";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 27);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // Genderlist
            // 
            this.Genderlist.FormattingEnabled = true;
            this.Genderlist.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Genderlist.Location = new System.Drawing.Point(368, 146);
            this.Genderlist.Name = "Genderlist";
            this.Genderlist.Size = new System.Drawing.Size(134, 28);
            this.Genderlist.TabIndex = 20;
            this.Genderlist.Tag = "";
            // 
            // specieslist
            // 
            this.specieslist.FormattingEnabled = true;
            this.specieslist.Location = new System.Drawing.Point(368, 98);
            this.specieslist.Name = "specieslist";
            this.specieslist.Size = new System.Drawing.Size(134, 28);
            this.specieslist.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(368, 436);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 27);
            this.textBox2.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(368, 371);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 27);
            this.numericUpDown1.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(248, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Name :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(248, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 30;
            this.label16.Text = "Species :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(248, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 31;
            this.label17.Text = "Gender :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(248, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "Birthday :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(248, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 20);
            this.label19.TabIndex = 33;
            this.label19.Text = "Ring :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(248, 324);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "Ring-Ref :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(248, 378);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "Price :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Add);
            this.groupBox2.Location = new System.Drawing.Point(29, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 428);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.Save.IconColor = System.Drawing.Color.Black;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.Location = new System.Drawing.Point(6, 295);
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
            this.Delete.IconColor = System.Drawing.Color.Black;
            this.Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Delete.Location = new System.Drawing.Point(6, 205);
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
            this.Update.IconColor = System.Drawing.Color.Black;
            this.Update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Update.Location = new System.Drawing.Point(6, 126);
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
            this.Add.IconColor = System.Drawing.Color.Black;
            this.Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Add.Location = new System.Drawing.Point(6, 43);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(143, 52);
            this.Add.TabIndex = 25;
            this.Add.Text = "Add";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Select.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.Select.IconColor = System.Drawing.Color.Black;
            this.Select.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Select.Location = new System.Drawing.Point(221, 488);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(121, 51);
            this.Select.TabIndex = 29;
            this.Select.Text = "Select...";
            this.Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Birds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 600);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Genderlist);
            this.Controls.Add(this.specieslist);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Birds";
            this.Text = "Birds";
            this.Load += new System.EventHandler(this.Birds_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox Genderlist;
        private ComboBox specieslist;
        private PictureBox pictureBox2;
        private Label label12;
        private Label label1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton Add;
        private FontAwesome.Sharp.IconButton Update;
        private FontAwesome.Sharp.IconButton Delete;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton Select;
        private FontAwesome.Sharp.IconButton last;
        private FontAwesome.Sharp.IconButton next;
        private FontAwesome.Sharp.IconButton previous;
        private FontAwesome.Sharp.IconButton first;
        private NotifyIcon notifyIcon1;
    }
}