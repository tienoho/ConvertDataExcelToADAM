namespace ConvertDataExcelToADAM.UserControlGui
{
    partial class UCConvertDataXML
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDataDemo = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseExcel = new System.Windows.Forms.Button();
            this.txtFileExcel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenDirectoryName = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_showDirectory = new System.Windows.Forms.ListBox();
            this.lb_tongfile = new System.Windows.Forms.Label();
            this.lbCountListExcel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPatron = new System.Windows.Forms.DataGridView();
            this.txtBrowserSaveFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowserSaveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatron)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBrowserSaveFile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBrowserSaveFile);
            this.groupBox1.Controls.Add(this.btnDataDemo);
            this.groupBox1.Controls.Add(this.btnConvert);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnChooseExcel);
            this.groupBox1.Controls.Add(this.txtFileExcel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenDirectoryName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 222);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyển đổi tên ảnh";
            // 
            // btnDataDemo
            // 
            this.btnDataDemo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataDemo.Location = new System.Drawing.Point(584, 162);
            this.btnDataDemo.Name = "btnDataDemo";
            this.btnDataDemo.Size = new System.Drawing.Size(156, 38);
            this.btnDataDemo.TabIndex = 115;
            this.btnDataDemo.Text = "Dữ liệu mẫu";
            this.btnDataDemo.UseVisualStyleBackColor = true;
            this.btnDataDemo.Click += new System.EventHandler(this.BtnDataDemo_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = true;
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(216)))));
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert.Location = new System.Drawing.Point(410, 163);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(158, 38);
            this.btnConvert.TabIndex = 106;
            this.btnConvert.Text = "Chuyển dữ liệu";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(131, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(436, 27);
            this.textBox2.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "Thư mục ảnh";
            // 
            // btnChooseExcel
            // 
            this.btnChooseExcel.Location = new System.Drawing.Point(584, 47);
            this.btnChooseExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseExcel.Name = "btnChooseExcel";
            this.btnChooseExcel.Size = new System.Drawing.Size(156, 33);
            this.btnChooseExcel.TabIndex = 90;
            this.btnChooseExcel.Text = "Browser...";
            this.btnChooseExcel.UseVisualStyleBackColor = true;
            this.btnChooseExcel.Click += new System.EventHandler(this.btnChooseExcel_Click);
            // 
            // txtFileExcel
            // 
            this.txtFileExcel.Enabled = false;
            this.txtFileExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileExcel.Location = new System.Drawing.Point(131, 49);
            this.txtFileExcel.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileExcel.Name = "txtFileExcel";
            this.txtFileExcel.Size = new System.Drawing.Size(436, 27);
            this.txtFileExcel.TabIndex = 89;
            this.txtFileExcel.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Chọn Danh Sách";
            // 
            // btnOpenDirectoryName
            // 
            this.btnOpenDirectoryName.Location = new System.Drawing.Point(584, 85);
            this.btnOpenDirectoryName.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenDirectoryName.Name = "btnOpenDirectoryName";
            this.btnOpenDirectoryName.Size = new System.Drawing.Size(156, 33);
            this.btnOpenDirectoryName.TabIndex = 87;
            this.btnOpenDirectoryName.Text = "Browser...";
            this.btnOpenDirectoryName.UseVisualStyleBackColor = true;
            this.btnOpenDirectoryName.Click += new System.EventHandler(this.btnOpenDirectoryName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_showDirectory);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(411, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 332);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH FILE";
            // 
            // lb_showDirectory
            // 
            this.lb_showDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_showDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_showDirectory.FormattingEnabled = true;
            this.lb_showDirectory.Location = new System.Drawing.Point(3, 18);
            this.lb_showDirectory.Name = "lb_showDirectory";
            this.lb_showDirectory.ScrollAlwaysVisible = true;
            this.lb_showDirectory.Size = new System.Drawing.Size(326, 311);
            this.lb_showDirectory.TabIndex = 49;
            // 
            // lb_tongfile
            // 
            this.lb_tongfile.AutoSize = true;
            this.lb_tongfile.Location = new System.Drawing.Point(631, 566);
            this.lb_tongfile.Name = "lb_tongfile";
            this.lb_tongfile.Size = new System.Drawing.Size(46, 16);
            this.lb_tongfile.TabIndex = 54;
            this.lb_tongfile.Text = "Tổng: ";
            // 
            // lbCountListExcel
            // 
            this.lbCountListExcel.AutoSize = true;
            this.lbCountListExcel.Location = new System.Drawing.Point(181, 566);
            this.lbCountListExcel.Name = "lbCountListExcel";
            this.lbCountListExcel.Size = new System.Drawing.Size(46, 16);
            this.lbCountListExcel.TabIndex = 53;
            this.lbCountListExcel.Text = "Tổng: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPatron);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 332);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH";
            // 
            // dgvPatron
            // 
            this.dgvPatron.AllowUserToAddRows = false;
            this.dgvPatron.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPatron.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPatron.Location = new System.Drawing.Point(3, 14);
            this.dgvPatron.Name = "dgvPatron";
            this.dgvPatron.ReadOnly = true;
            this.dgvPatron.RowHeadersWidth = 20;
            this.dgvPatron.Size = new System.Drawing.Size(392, 312);
            this.dgvPatron.TabIndex = 19;
            // 
            // txtBrowserSaveFile
            // 
            this.txtBrowserSaveFile.Enabled = false;
            this.txtBrowserSaveFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowserSaveFile.Location = new System.Drawing.Point(131, 121);
            this.txtBrowserSaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrowserSaveFile.Name = "txtBrowserSaveFile";
            this.txtBrowserSaveFile.Size = new System.Drawing.Size(436, 27);
            this.txtBrowserSaveFile.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Thư mục lưu";
            // 
            // btnBrowserSaveFile
            // 
            this.btnBrowserSaveFile.Location = new System.Drawing.Point(584, 120);
            this.btnBrowserSaveFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowserSaveFile.Name = "btnBrowserSaveFile";
            this.btnBrowserSaveFile.Size = new System.Drawing.Size(156, 33);
            this.btnBrowserSaveFile.TabIndex = 116;
            this.btnBrowserSaveFile.Text = "Browser...";
            this.btnBrowserSaveFile.UseVisualStyleBackColor = true;
            this.btnBrowserSaveFile.Click += new System.EventHandler(this.btnBrowserSaveFile_Click);
            // 
            // UCConvertDataXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lb_tongfile);
            this.Controls.Add(this.lbCountListExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCConvertDataXML";
            this.Size = new System.Drawing.Size(748, 615);
            this.Load += new System.EventHandler(this.UCConvertDataXML_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatron)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_showDirectory;
        private System.Windows.Forms.Button btnOpenDirectoryName;
        private System.Windows.Forms.Button btn_changeName;
        private System.Windows.Forms.Button btn_hd;
        private System.Windows.Forms.Label lb_tongfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseExcel;
        private System.Windows.Forms.Label lbCountListExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fbd_browse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileExcel;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDataDemo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPatron;
        private System.Windows.Forms.TextBox txtBrowserSaveFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowserSaveFile;
    }
}
