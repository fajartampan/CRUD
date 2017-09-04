namespace CRUD
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbblood = new System.Windows.Forms.ComboBox();
            this.tbman = new System.Windows.Forms.RadioButton();
            this.tbwoman = new System.Windows.Forms.RadioButton();
            this.btinsert = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(111, 12);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(100, 20);
            this.tbid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(111, 38);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(292, 20);
            this.tbname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Blood Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // tbblood
            // 
            this.tbblood.FormattingEnabled = true;
            this.tbblood.Location = new System.Drawing.Point(111, 90);
            this.tbblood.Name = "tbblood";
            this.tbblood.Size = new System.Drawing.Size(121, 21);
            this.tbblood.TabIndex = 9;
            // 
            // tbman
            // 
            this.tbman.AutoSize = true;
            this.tbman.Location = new System.Drawing.Point(111, 65);
            this.tbman.Name = "tbman";
            this.tbman.Size = new System.Drawing.Size(46, 17);
            this.tbman.TabIndex = 10;
            this.tbman.TabStop = true;
            this.tbman.Text = "Man";
            this.tbman.UseVisualStyleBackColor = true;
            // 
            // tbwoman
            // 
            this.tbwoman.AutoSize = true;
            this.tbwoman.Location = new System.Drawing.Point(163, 65);
            this.tbwoman.Name = "tbwoman";
            this.tbwoman.Size = new System.Drawing.Size(62, 17);
            this.tbwoman.TabIndex = 11;
            this.tbwoman.TabStop = true;
            this.tbwoman.Text = "Woman";
            this.tbwoman.UseVisualStyleBackColor = true;
            // 
            // btinsert
            // 
            this.btinsert.Location = new System.Drawing.Point(111, 312);
            this.btinsert.Name = "btinsert";
            this.btinsert.Size = new System.Drawing.Size(75, 23);
            this.btinsert.TabIndex = 13;
            this.btinsert.Text = "Insert";
            this.btinsert.UseVisualStyleBackColor = true;
            this.btinsert.Click += new System.EventHandler(this.btinsert_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(192, 312);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 14;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(273, 312);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 15;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btinsert);
            this.Controls.Add(this.tbwoman);
            this.Controls.Add(this.tbman);
            this.Controls.Add(this.tbblood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tbblood;
        private System.Windows.Forms.RadioButton tbman;
        private System.Windows.Forms.RadioButton tbwoman;
        private System.Windows.Forms.Button btinsert;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button button1;
    }
}

