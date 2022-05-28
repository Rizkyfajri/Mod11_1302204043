namespace Mod11_1302204043
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
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddData1 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(393, 80);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(147, 20);
            this.txtData1.TabIndex = 0;
            this.txtData1.TextChanged += new System.EventHandler(this.txtData1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Location = new System.Drawing.Point(393, 195);
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.Size = new System.Drawing.Size(147, 20);
            this.txtOutput1.TabIndex = 4;
            this.txtOutput1.TextChanged += new System.EventHandler(this.txtOutput1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // btnAddData1
            // 
            this.btnAddData1.Location = new System.Drawing.Point(604, 76);
            this.btnAddData1.Name = "btnAddData1";
            this.btnAddData1.Size = new System.Drawing.Size(75, 23);
            this.btnAddData1.TabIndex = 6;
            this.btnAddData1.Text = "Add Data1";
            this.btnAddData1.UseVisualStyleBackColor = true;
            this.btnAddData1.Click += new System.EventHandler(this.btnProcess1_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(604, 105);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus pertama";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(604, 134);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnAddData1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtData1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddData1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnCount;
    }
}

