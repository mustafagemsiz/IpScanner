namespace IpScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            firstSearchBox = new TextBox();
            scanBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            secondSearchBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            label5 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            exportBtn = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // firstSearchBox
            // 
            firstSearchBox.Location = new Point(136, 76);
            firstSearchBox.Name = "firstSearchBox";
            firstSearchBox.Size = new Size(100, 23);
            firstSearchBox.TabIndex = 0;
            // 
            // scanBtn
            // 
            scanBtn.BackColor = SystemColors.ButtonHighlight;
            scanBtn.FlatStyle = FlatStyle.Popup;
            scanBtn.Location = new Point(146, 164);
            scanBtn.Name = "scanBtn";
            scanBtn.Size = new Size(75, 23);
            scanBtn.TabIndex = 2;
            scanBtn.Text = "Scan";
            scanBtn.UseVisualStyleBackColor = false;
            scanBtn.Click += scanBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 84);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "first IP address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 22);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 4;
            label2.Text = "Available IP list";
            // 
            // secondSearchBox
            // 
            secondSearchBox.Location = new Point(136, 121);
            secondSearchBox.Name = "secondSearchBox";
            secondSearchBox.Size = new Size(100, 23);
            secondSearchBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 129);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "last IP address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 40);
            label4.Name = "label4";
            label4.Size = new Size(141, 15);
            label4.TabIndex = 7;
            label4.Text = "Please enter the IP ranges";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(37, 246);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(256, 29);
            progressBar1.TabIndex = 8;
            progressBar1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 223);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 9;
            label5.Text = "process status";
            label5.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(639, 17);
            label7.Name = "label7";
            label7.Size = new Size(0, 17);
            label7.TabIndex = 11;
            // 
            // listView1
            // 
            listView1.Location = new Point(319, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 376);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // exportBtn
            // 
            exportBtn.BackColor = SystemColors.ButtonHighlight;
            exportBtn.Enabled = false;
            exportBtn.FlatStyle = FlatStyle.Popup;
            exportBtn.Location = new Point(709, 422);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(75, 23);
            exportBtn.TabIndex = 13;
            exportBtn.Text = "Export List";
            exportBtn.UseVisualStyleBackColor = false;
            exportBtn.Click += exportBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-3, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 44);
            panel1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(332, 10);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 0;
            label6.Text = "All rights reserved.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 506);
            Controls.Add(panel1);
            Controls.Add(exportBtn);
            Controls.Add(listView1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(secondSearchBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(scanBtn);
            Controls.Add(firstSearchBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ip Scanner";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstSearchBox;
        private Button scanBtn;
        private Label label1;
        private Label label2;
        private TextBox secondSearchBox;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private Label label5;
        private Label label7;
        private ListView listView1;
        private Button exportBtn;
        private Panel panel1;
        private Label label6;
    }
}
