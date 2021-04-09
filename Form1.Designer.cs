namespace Calculator
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
            this.SoA = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.Label();
            this.SoB = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SoA
            // 
            this.SoA.BackColor = System.Drawing.SystemColors.Info;
            this.SoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoA.Location = new System.Drawing.Point(95, 51);
            this.SoA.Name = "SoA";
            this.SoA.Size = new System.Drawing.Size(130, 23);
            this.SoA.TabIndex = 0;
            this.SoA.Click += new System.EventHandler(this.label1_Click);
            // 
            // KetQua
            // 
            this.KetQua.BackColor = System.Drawing.SystemColors.Info;
            this.KetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KetQua.Location = new System.Drawing.Point(95, 130);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(130, 23);
            this.KetQua.TabIndex = 1;
            // 
            // SoB
            // 
            this.SoB.BackColor = System.Drawing.SystemColors.Info;
            this.SoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoB.Location = new System.Drawing.Point(95, 88);
            this.SoB.Name = "SoB";
            this.SoB.Size = new System.Drawing.Size(130, 23);
            this.SoB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cộng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kết Quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SoB);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.SoA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoA;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.Label SoB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

