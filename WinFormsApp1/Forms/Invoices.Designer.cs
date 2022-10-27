namespace WinFormsApp1.Forms
{
    partial class Invoices
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
            this.typeop = new System.Windows.Forms.ComboBox();
            this.listbreeder = new System.Windows.Forms.ComboBox();
            this.dateop = new System.Windows.Forms.DateTimePicker();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnselectbird = new FontAwesome.Sharp.IconButton();
            this.bntcalculate = new FontAwesome.Sharp.IconButton();
            this.bntselectsupp = new FontAwesome.Sharp.IconButton();
            this.Save = new FontAwesome.Sharp.IconButton();
            this.printinv = new FontAwesome.Sharp.IconButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // typeop
            // 
            this.typeop.FormattingEnabled = true;
            this.typeop.Items.AddRange(new object[] {
            "Sale",
            "Purchase"});
            this.typeop.Location = new System.Drawing.Point(266, 32);
            this.typeop.Name = "typeop";
            this.typeop.Size = new System.Drawing.Size(151, 28);
            this.typeop.TabIndex = 0;
            // 
            // listbreeder
            // 
            this.listbreeder.FormattingEnabled = true;
            this.listbreeder.Location = new System.Drawing.Point(266, 103);
            this.listbreeder.Name = "listbreeder";
            this.listbreeder.Size = new System.Drawing.Size(151, 28);
            this.listbreeder.TabIndex = 1;
            // 
            // dateop
            // 
            this.dateop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateop.Location = new System.Drawing.Point(266, 320);
            this.dateop.Name = "dateop";
            this.dateop.Size = new System.Drawing.Size(151, 27);
            this.dateop.TabIndex = 3;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotal.Location = new System.Drawing.Point(482, 384);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(66, 27);
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Operation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Breeder :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(142, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bird :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(142, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Supplies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(142, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(142, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(482, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "zefzef";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(482, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "label9";
            // 
            // btnselectbird
            // 
            this.btnselectbird.IconChar = FontAwesome.Sharp.IconChar.Dove;
            this.btnselectbird.IconColor = System.Drawing.Color.Black;
            this.btnselectbird.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnselectbird.IconSize = 30;
            this.btnselectbird.Location = new System.Drawing.Point(266, 181);
            this.btnselectbird.Name = "btnselectbird";
            this.btnselectbird.Size = new System.Drawing.Size(136, 37);
            this.btnselectbird.TabIndex = 20;
            this.btnselectbird.Text = "selectbird";
            this.btnselectbird.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnselectbird.UseVisualStyleBackColor = true;
            this.btnselectbird.Click += new System.EventHandler(this.selecbird_Click);
            // 
            // bntcalculate
            // 
            this.bntcalculate.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.bntcalculate.IconColor = System.Drawing.Color.Black;
            this.bntcalculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntcalculate.IconSize = 30;
            this.bntcalculate.Location = new System.Drawing.Point(266, 376);
            this.bntcalculate.Name = "bntcalculate";
            this.bntcalculate.Size = new System.Drawing.Size(136, 38);
            this.bntcalculate.TabIndex = 21;
            this.bntcalculate.Text = "Calculate";
            this.bntcalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntcalculate.UseVisualStyleBackColor = true;
            this.bntcalculate.Click += new System.EventHandler(this.bntcalculate_Click);
            // 
            // bntselectsupp
            // 
            this.bntselectsupp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntselectsupp.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.bntselectsupp.IconColor = System.Drawing.Color.Black;
            this.bntselectsupp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntselectsupp.IconSize = 30;
            this.bntselectsupp.Location = new System.Drawing.Point(266, 245);
            this.bntselectsupp.Name = "bntselectsupp";
            this.bntselectsupp.Size = new System.Drawing.Size(136, 36);
            this.bntselectsupp.TabIndex = 31;
            this.bntselectsupp.Text = "Select...";
            this.bntselectsupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntselectsupp.UseVisualStyleBackColor = true;
            this.bntselectsupp.Click += new System.EventHandler(this.Select_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.Save.IconColor = System.Drawing.Color.Black;
            this.Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Save.IconSize = 30;
            this.Save.Location = new System.Drawing.Point(252, 458);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 43);
            this.Save.TabIndex = 30;
            this.Save.Text = "Save";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // printinv
            // 
            this.printinv.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printinv.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.printinv.IconColor = System.Drawing.Color.Black;
            this.printinv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.printinv.IconSize = 30;
            this.printinv.Location = new System.Drawing.Point(366, 458);
            this.printinv.Name = "printinv";
            this.printinv.Size = new System.Drawing.Size(94, 43);
            this.printinv.TabIndex = 33;
            this.printinv.Text = "Print";
            this.printinv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.printinv.UseVisualStyleBackColor = true;
            this.printinv.Click += new System.EventHandler(this.printinv_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 575);
            this.Controls.Add(this.printinv);
            this.Controls.Add(this.bntselectsupp);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.bntcalculate);
            this.Controls.Add(this.btnselectbird);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dateop);
            this.Controls.Add(this.listbreeder);
            this.Controls.Add(this.typeop);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox typeop;
        private ComboBox listbreeder;
        private DateTimePicker dateop;
        private Label lbTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnselectbird;
        private FontAwesome.Sharp.IconButton bntcalculate;
        private FontAwesome.Sharp.IconButton bntselectsupp;
        private FontAwesome.Sharp.IconButton Save;
        private FontAwesome.Sharp.IconButton printinv;
        private NotifyIcon notifyIcon1;
    }
}