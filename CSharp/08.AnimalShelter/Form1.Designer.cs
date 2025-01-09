
namespace _08.AnimalShelter
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
            this.CreateCustomer = new System.Windows.Forms.Button();
            this.CusDetailPanel = new System.Windows.Forms.Panel();
            this.CusIsQualified = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CusAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CusAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CusFullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CusNewPanel = new System.Windows.Forms.Panel();
            this.CusNewDescription = new System.Windows.Forms.TextBox();
            this.CusNewAddress = new System.Windows.Forms.TextBox();
            this.CusNewBirthday = new System.Windows.Forms.TextBox();
            this.CusNewFirstName = new System.Windows.Forms.TextBox();
            this.CusNewLastName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CusListPanel = new System.Windows.Forms.Panel();
            this.CusList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label16 = new System.Windows.Forms.Label();
            this.CusPetInfo = new System.Windows.Forms.Label();
            this.CusDetailPanel.SuspendLayout();
            this.CusNewPanel.SuspendLayout();
            this.CusListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCustomer
            // 
            this.CreateCustomer.Location = new System.Drawing.Point(156, 319);
            this.CreateCustomer.Name = "CreateCustomer";
            this.CreateCustomer.Size = new System.Drawing.Size(100, 21);
            this.CreateCustomer.TabIndex = 0;
            this.CreateCustomer.Text = "입양자 생성";
            this.CreateCustomer.UseVisualStyleBackColor = true;
            this.CreateCustomer.Click += new System.EventHandler(this.CreateCustomer_Click);
            // 
            // CusDetailPanel
            // 
            this.CusDetailPanel.Controls.Add(this.CusPetInfo);
            this.CusDetailPanel.Controls.Add(this.label16);
            this.CusDetailPanel.Controls.Add(this.CusIsQualified);
            this.CusDetailPanel.Controls.Add(this.label2);
            this.CusDetailPanel.Controls.Add(this.CusDescription);
            this.CusDetailPanel.Controls.Add(this.label6);
            this.CusDetailPanel.Controls.Add(this.CusAddress);
            this.CusDetailPanel.Controls.Add(this.label5);
            this.CusDetailPanel.Controls.Add(this.CusAge);
            this.CusDetailPanel.Controls.Add(this.label4);
            this.CusDetailPanel.Controls.Add(this.CusFullName);
            this.CusDetailPanel.Controls.Add(this.label3);
            this.CusDetailPanel.Location = new System.Drawing.Point(248, 12);
            this.CusDetailPanel.Name = "CusDetailPanel";
            this.CusDetailPanel.Size = new System.Drawing.Size(304, 387);
            this.CusDetailPanel.TabIndex = 1;
            // 
            // CusIsQualified
            // 
            this.CusIsQualified.AutoSize = true;
            this.CusIsQualified.Location = new System.Drawing.Point(90, 68);
            this.CusIsQualified.Name = "CusIsQualified";
            this.CusIsQualified.Size = new System.Drawing.Size(39, 15);
            this.CusIsQualified.TabIndex = 11;
            this.CusIsQualified.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "입양가능:";
            // 
            // CusDescription
            // 
            this.CusDescription.AutoSize = true;
            this.CusDescription.Location = new System.Drawing.Point(90, 116);
            this.CusDescription.Name = "CusDescription";
            this.CusDescription.Size = new System.Drawing.Size(39, 15);
            this.CusDescription.TabIndex = 9;
            this.CusDescription.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "설명:";
            // 
            // CusAddress
            // 
            this.CusAddress.AutoSize = true;
            this.CusAddress.Location = new System.Drawing.Point(90, 92);
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.Size = new System.Drawing.Size(39, 15);
            this.CusAddress.TabIndex = 7;
            this.CusAddress.Text = "label2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "주소:";
            // 
            // CusAge
            // 
            this.CusAge.AutoSize = true;
            this.CusAge.Location = new System.Drawing.Point(90, 46);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(39, 15);
            this.CusAge.TabIndex = 5;
            this.CusAge.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이:";
            // 
            // CusFullName
            // 
            this.CusFullName.AutoSize = true;
            this.CusFullName.Location = new System.Drawing.Point(90, 20);
            this.CusFullName.Name = "CusFullName";
            this.CusFullName.Size = new System.Drawing.Size(39, 15);
            this.CusFullName.TabIndex = 3;
            this.CusFullName.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름:";
            // 
            // CusNewPanel
            // 
            this.CusNewPanel.Controls.Add(this.CusNewDescription);
            this.CusNewPanel.Controls.Add(this.CusNewAddress);
            this.CusNewPanel.Controls.Add(this.CreateCustomer);
            this.CusNewPanel.Controls.Add(this.CusNewBirthday);
            this.CusNewPanel.Controls.Add(this.CusNewFirstName);
            this.CusNewPanel.Controls.Add(this.CusNewLastName);
            this.CusNewPanel.Controls.Add(this.label15);
            this.CusNewPanel.Controls.Add(this.label14);
            this.CusNewPanel.Controls.Add(this.label13);
            this.CusNewPanel.Controls.Add(this.label12);
            this.CusNewPanel.Controls.Add(this.label11);
            this.CusNewPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CusNewPanel.Location = new System.Drawing.Point(475, 24);
            this.CusNewPanel.Name = "CusNewPanel";
            this.CusNewPanel.Size = new System.Drawing.Size(316, 533);
            this.CusNewPanel.TabIndex = 0;
            this.CusNewPanel.Visible = false;
            // 
            // CusNewDescription
            // 
            this.CusNewDescription.Location = new System.Drawing.Point(61, 132);
            this.CusNewDescription.Multiline = true;
            this.CusNewDescription.Name = "CusNewDescription";
            this.CusNewDescription.Size = new System.Drawing.Size(227, 162);
            this.CusNewDescription.TabIndex = 9;
            // 
            // CusNewAddress
            // 
            this.CusNewAddress.Location = new System.Drawing.Point(61, 104);
            this.CusNewAddress.Name = "CusNewAddress";
            this.CusNewAddress.Size = new System.Drawing.Size(227, 23);
            this.CusNewAddress.TabIndex = 8;
            // 
            // CusNewBirthday
            // 
            this.CusNewBirthday.Location = new System.Drawing.Point(61, 78);
            this.CusNewBirthday.Name = "CusNewBirthday";
            this.CusNewBirthday.Size = new System.Drawing.Size(73, 23);
            this.CusNewBirthday.TabIndex = 7;
            // 
            // CusNewFirstName
            // 
            this.CusNewFirstName.Location = new System.Drawing.Point(61, 52);
            this.CusNewFirstName.Name = "CusNewFirstName";
            this.CusNewFirstName.Size = new System.Drawing.Size(73, 23);
            this.CusNewFirstName.TabIndex = 6;
            // 
            // CusNewLastName
            // 
            this.CusNewLastName.Location = new System.Drawing.Point(61, 27);
            this.CusNewLastName.Name = "CusNewLastName";
            this.CusNewLastName.Size = new System.Drawing.Size(73, 23);
            this.CusNewLastName.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "설명:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "주소:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "생일:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 56);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "이름:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "성:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "label10";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(81, 114);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 23);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Location = new System.Drawing.Point(81, 151);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(226, 23);
            this.textBox5.TabIndex = 9;
            // 
            // CusListPanel
            // 
            this.CusListPanel.Controls.Add(this.CusList);
            this.CusListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CusListPanel.Location = new System.Drawing.Point(0, 172);
            this.CusListPanel.Name = "CusListPanel";
            this.CusListPanel.Size = new System.Drawing.Size(475, 385);
            this.CusListPanel.TabIndex = 2;
            // 
            // CusList
            // 
            this.CusList.AllowUserToAddRows = false;
            this.CusList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CusList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.CusList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CusList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CusList.Location = new System.Drawing.Point(0, 0);
            this.CusList.MultiSelect = false;
            this.CusList.Name = "CusList";
            this.CusList.RowTemplate.Height = 25;
            this.CusList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CusList.Size = new System.Drawing.Size(475, 385);
            this.CusList.TabIndex = 0;
            this.CusList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CusList_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "이름";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "나이";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "입양가능?";
            this.Column3.Name = "Column3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "새 입양자";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "펫:";
            // 
            // CusPetInfo
            // 
            this.CusPetInfo.AutoSize = true;
            this.CusPetInfo.Location = new System.Drawing.Point(90, 139);
            this.CusPetInfo.Name = "CusPetInfo";
            this.CusPetInfo.Size = new System.Drawing.Size(39, 15);
            this.CusPetInfo.TabIndex = 13;
            this.CusPetInfo.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 557);
            this.Controls.Add(this.CusListPanel);
            this.Controls.Add(this.CusNewPanel);
            this.Controls.Add(this.CusDetailPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CusDetailPanel.ResumeLayout(false);
            this.CusDetailPanel.PerformLayout();
            this.CusNewPanel.ResumeLayout(false);
            this.CusNewPanel.PerformLayout();
            this.CusListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CusList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCustomer;
        private System.Windows.Forms.Panel CusDetailPanel;
        private System.Windows.Forms.Label CusDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CusAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CusFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CusIsQualified;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CusNewPanel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CusNewDescription;
        private System.Windows.Forms.TextBox CusNewAddress;
        private System.Windows.Forms.TextBox CusNewBirthday;
        private System.Windows.Forms.TextBox CusNewFirstName;
        private System.Windows.Forms.TextBox CusNewLastName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel CusListPanel;
        private System.Windows.Forms.DataGridView CusList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label CusPetInfo;
        private System.Windows.Forms.Label label16;
    }
}

