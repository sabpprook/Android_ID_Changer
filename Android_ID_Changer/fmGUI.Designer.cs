namespace Android_ID_Changer
{
    partial class fmGUI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_func1_write = new System.Windows.Forms.Button();
            this.btn_func1_read = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_func1_new = new System.Windows.Forms.TextBox();
            this.text_func1_old = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_func2_write = new System.Windows.Forms.Button();
            this.btn_func2_read = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_func2_new = new System.Windows.Forms.TextBox();
            this.text_func2_old = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_func3_save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_func3_new = new System.Windows.Forms.TextBox();
            this.btn_func3_write = new System.Windows.Forms.Button();
            this.btn_func3_read = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_func3_old = new System.Windows.Forms.TextBox();
            this.listBox_package = new System.Windows.Forms.ListBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_func1_write);
            this.groupBox1.Controls.Add(this.btn_func1_read);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_func1_new);
            this.groupBox1.Controls.Add(this.text_func1_old);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(320, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Android 4.0 - 4.4";
            // 
            // btn_func1_write
            // 
            this.btn_func1_write.Enabled = false;
            this.btn_func1_write.Location = new System.Drawing.Point(218, 28);
            this.btn_func1_write.Name = "btn_func1_write";
            this.btn_func1_write.Size = new System.Drawing.Size(75, 30);
            this.btn_func1_write.TabIndex = 5;
            this.btn_func1_write.Text = "Write";
            this.btn_func1_write.UseVisualStyleBackColor = true;
            this.btn_func1_write.Click += new System.EventHandler(this.btn_func1_write_Click);
            // 
            // btn_func1_read
            // 
            this.btn_func1_read.Location = new System.Drawing.Point(137, 28);
            this.btn_func1_read.Name = "btn_func1_read";
            this.btn_func1_read.Size = new System.Drawing.Size(75, 30);
            this.btn_func1_read.TabIndex = 4;
            this.btn_func1_read.Text = "Read";
            this.btn_func1_read.UseVisualStyleBackColor = true;
            this.btn_func1_read.Click += new System.EventHandler(this.btn_func1_read_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old:";
            // 
            // text_func1_new
            // 
            this.text_func1_new.Location = new System.Drawing.Point(63, 122);
            this.text_func1_new.MaxLength = 16;
            this.text_func1_new.Name = "text_func1_new";
            this.text_func1_new.Size = new System.Drawing.Size(230, 27);
            this.text_func1_new.TabIndex = 1;
            // 
            // text_func1_old
            // 
            this.text_func1_old.Location = new System.Drawing.Point(63, 72);
            this.text_func1_old.MaxLength = 16;
            this.text_func1_old.Name = "text_func1_old";
            this.text_func1_old.ReadOnly = true;
            this.text_func1_old.Size = new System.Drawing.Size(230, 27);
            this.text_func1_old.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_func2_write);
            this.groupBox2.Controls.Add(this.btn_func2_read);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.text_func2_new);
            this.groupBox2.Controls.Add(this.text_func2_old);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(13, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(320, 180);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Android 5.0 - 7.1";
            // 
            // btn_func2_write
            // 
            this.btn_func2_write.Enabled = false;
            this.btn_func2_write.Location = new System.Drawing.Point(218, 28);
            this.btn_func2_write.Name = "btn_func2_write";
            this.btn_func2_write.Size = new System.Drawing.Size(75, 30);
            this.btn_func2_write.TabIndex = 9;
            this.btn_func2_write.Text = "Write";
            this.btn_func2_write.UseVisualStyleBackColor = true;
            this.btn_func2_write.Click += new System.EventHandler(this.btn_func2_write_Click);
            // 
            // btn_func2_read
            // 
            this.btn_func2_read.Location = new System.Drawing.Point(137, 28);
            this.btn_func2_read.Name = "btn_func2_read";
            this.btn_func2_read.Size = new System.Drawing.Size(75, 30);
            this.btn_func2_read.TabIndex = 8;
            this.btn_func2_read.Text = "Read";
            this.btn_func2_read.UseVisualStyleBackColor = true;
            this.btn_func2_read.Click += new System.EventHandler(this.btn_func2_read_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "New:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Old:";
            // 
            // text_func2_new
            // 
            this.text_func2_new.Location = new System.Drawing.Point(63, 122);
            this.text_func2_new.MaxLength = 16;
            this.text_func2_new.Name = "text_func2_new";
            this.text_func2_new.Size = new System.Drawing.Size(230, 27);
            this.text_func2_new.TabIndex = 5;
            // 
            // text_func2_old
            // 
            this.text_func2_old.Location = new System.Drawing.Point(63, 72);
            this.text_func2_old.MaxLength = 16;
            this.text_func2_old.Name = "text_func2_old";
            this.text_func2_old.ReadOnly = true;
            this.text_func2_old.Size = new System.Drawing.Size(230, 27);
            this.text_func2_old.TabIndex = 4;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(13, 14);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(100, 40);
            this.btn_check.TabIndex = 2;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_func3_save);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.text_func3_new);
            this.groupBox3.Controls.Add(this.btn_func3_write);
            this.groupBox3.Controls.Add(this.btn_func3_read);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.text_func3_old);
            this.groupBox3.Controls.Add(this.listBox_package);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(341, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(380, 370);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Android 8.0 (ROOT)";
            // 
            // btn_func3_save
            // 
            this.btn_func3_save.Enabled = false;
            this.btn_func3_save.Location = new System.Drawing.Point(290, 120);
            this.btn_func3_save.Name = "btn_func3_save";
            this.btn_func3_save.Size = new System.Drawing.Size(75, 30);
            this.btn_func3_save.TabIndex = 14;
            this.btn_func3_save.Text = "Save";
            this.btn_func3_save.UseVisualStyleBackColor = true;
            this.btn_func3_save.Click += new System.EventHandler(this.btn_func3_save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "New:";
            // 
            // text_func3_new
            // 
            this.text_func3_new.Location = new System.Drawing.Point(63, 122);
            this.text_func3_new.MaxLength = 16;
            this.text_func3_new.Name = "text_func3_new";
            this.text_func3_new.Size = new System.Drawing.Size(221, 27);
            this.text_func3_new.TabIndex = 12;
            // 
            // btn_func3_write
            // 
            this.btn_func3_write.Enabled = false;
            this.btn_func3_write.Location = new System.Drawing.Point(290, 28);
            this.btn_func3_write.Name = "btn_func3_write";
            this.btn_func3_write.Size = new System.Drawing.Size(75, 30);
            this.btn_func3_write.TabIndex = 11;
            this.btn_func3_write.Text = "Write";
            this.btn_func3_write.UseVisualStyleBackColor = true;
            this.btn_func3_write.Click += new System.EventHandler(this.btn_func3_write_Click);
            // 
            // btn_func3_read
            // 
            this.btn_func3_read.Location = new System.Drawing.Point(209, 28);
            this.btn_func3_read.Name = "btn_func3_read";
            this.btn_func3_read.Size = new System.Drawing.Size(75, 30);
            this.btn_func3_read.TabIndex = 10;
            this.btn_func3_read.Text = "Read";
            this.btn_func3_read.UseVisualStyleBackColor = true;
            this.btn_func3_read.Click += new System.EventHandler(this.btn_func3_read_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Old:";
            // 
            // text_func3_old
            // 
            this.text_func3_old.Location = new System.Drawing.Point(63, 72);
            this.text_func3_old.MaxLength = 128;
            this.text_func3_old.Name = "text_func3_old";
            this.text_func3_old.ReadOnly = true;
            this.text_func3_old.Size = new System.Drawing.Size(221, 27);
            this.text_func3_old.TabIndex = 6;
            // 
            // listBox_package
            // 
            this.listBox_package.FormattingEnabled = true;
            this.listBox_package.ItemHeight = 20;
            this.listBox_package.Location = new System.Drawing.Point(15, 175);
            this.listBox_package.Name = "listBox_package";
            this.listBox_package.Size = new System.Drawing.Size(350, 164);
            this.listBox_package.TabIndex = 0;
            this.listBox_package.SelectedIndexChanged += new System.EventHandler(this.listBox_package_SelectedIndexChanged);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.Location = new System.Drawing.Point(128, 23);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(0, 21);
            this.label_Info.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(655, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HTCFZ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(612, 47);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(109, 20);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Author: 許宥彥";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // fmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "fmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Android ID Changer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox text_func1_new;
        private System.Windows.Forms.TextBox text_func1_old;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_func2_new;
        private System.Windows.Forms.TextBox text_func2_old;
        private System.Windows.Forms.Button btn_func1_read;
        private System.Windows.Forms.Button btn_func1_write;
        private System.Windows.Forms.Button btn_func2_read;
        private System.Windows.Forms.Button btn_func2_write;
        private System.Windows.Forms.ListBox listBox_package;
        private System.Windows.Forms.Button btn_func3_write;
        private System.Windows.Forms.Button btn_func3_read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_func3_old;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_func3_new;
        private System.Windows.Forms.Button btn_func3_save;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

