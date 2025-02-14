namespace bai3_winform
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
            this.txtpheptinhcoban = new System.Windows.Forms.TextBox();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpheptinhcoban
            // 
            this.txtpheptinhcoban.Location = new System.Drawing.Point(306, 40);
            this.txtpheptinhcoban.Name = "txtpheptinhcoban";
            this.txtpheptinhcoban.Size = new System.Drawing.Size(142, 20);
            this.txtpheptinhcoban.TabIndex = 0;
            this.txtpheptinhcoban.Text = "PHÉP TINH CƠ BAN";
            this.txtpheptinhcoban.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(165, 105);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 20);
            this.txtso1.TabIndex = 1;
            this.txtso1.Text = "Nhập số 1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(272, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(165, 131);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 20);
            this.txtso2.TabIndex = 1;
            this.txtso2.Text = "Nhập số 2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(272, 130);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(165, 156);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 20);
            this.txtKq.TabIndex = 1;
            this.txtKq.Text = "Kết Qủa";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(272, 155);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 2;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(53, 215);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(75, 23);
            this.btncong.TabIndex = 3;
            this.btncong.Text = "+";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(134, 215);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(75, 23);
            this.btntru.TabIndex = 3;
            this.btntru.Text = "-";
            this.btntru.UseVisualStyleBackColor = true;
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(215, 215);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(75, 23);
            this.btnnhan.TabIndex = 3;
            this.btnnhan.Text = "*";
            this.btnnhan.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(306, 215);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 3;
            this.btn.Text = "/";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.txtpheptinhcoban);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpheptinhcoban;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btn;
    }
}

