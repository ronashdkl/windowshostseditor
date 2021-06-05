namespace HostFileEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hostsBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hosts File Editor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(16, 176);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Success";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // hostsBox
            // 
            this.hostsBox.BackColor = System.Drawing.Color.Khaki;
            this.hostsBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hostsBox.ForeColor = System.Drawing.Color.Black;
            this.hostsBox.Location = new System.Drawing.Point(16, 214);
            this.hostsBox.Name = "hostsBox";
            this.hostsBox.ReadOnly = true;
            this.hostsBox.Size = new System.Drawing.Size(413, 185);
            this.hostsBox.TabIndex = 8;
            this.hostsBox.Text = "";
            this.hostsBox.SelectionChanged += new System.EventHandler(this.hostsBox_SelectionChanged);
            this.hostsBox.TextChanged += new System.EventHandler(this.hostsBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(330, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "By: Ronash Dhakal";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(290, 124);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(139, 31);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeBtn.Location = new System.Drawing.Point(398, 201);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(37, 31);
            this.removeBtn.TabIndex = 11;
            this.removeBtn.Text = "X";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(16, 138);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(242, 20);
            this.hostBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Host";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(16, 87);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(242, 20);
            this.ipBox.TabIndex = 2;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Green;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(290, 87);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(139, 31);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(22, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "To remove the host, select the IP address and domain and click on Remove button\r\n" +
    "";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(449, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hostsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hosts FIle Editor -- v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox hostsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label6;
    }
}

