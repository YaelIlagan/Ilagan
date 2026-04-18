namespace Ilagan_StudentGradeAnalyzer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtstudentnum = new System.Windows.Forms.TextBox();
            this.btncompute = new System.Windows.Forms.Button();
            this.lboxshowgrade = new System.Windows.Forms.ListBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprelim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmidterm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number*";
            // 
            // txtstudentnum
            // 
            this.txtstudentnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentnum.Location = new System.Drawing.Point(16, 103);
            this.txtstudentnum.Name = "txtstudentnum";
            this.txtstudentnum.Size = new System.Drawing.Size(364, 26);
            this.txtstudentnum.TabIndex = 1;
            // 
            // btncompute
            // 
            this.btncompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btncompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompute.Location = new System.Drawing.Point(153, 323);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(146, 49);
            this.btncompute.TabIndex = 2;
            this.btncompute.Text = "Compute";
            this.btncompute.UseVisualStyleBackColor = false;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // lboxshowgrade
            // 
            this.lboxshowgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxshowgrade.FormattingEnabled = true;
            this.lboxshowgrade.ItemHeight = 20;
            this.lboxshowgrade.Location = new System.Drawing.Point(153, 189);
            this.lboxshowgrade.Name = "lboxshowgrade";
            this.lboxshowgrade.Size = new System.Drawing.Size(227, 124);
            this.lboxshowgrade.TabIndex = 3;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentname.Location = new System.Drawing.Point(16, 155);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(364, 26);
            this.txtstudentname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Name*";
            // 
            // txtprelim
            // 
            this.txtprelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprelim.Location = new System.Drawing.Point(16, 222);
            this.txtprelim.Name = "txtprelim";
            this.txtprelim.Size = new System.Drawing.Size(112, 26);
            this.txtprelim.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prelim Grade*";
            // 
            // txtmidterm
            // 
            this.txtmidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmidterm.Location = new System.Drawing.Point(16, 277);
            this.txtmidterm.Name = "txtmidterm";
            this.txtmidterm.Size = new System.Drawing.Size(112, 26);
            this.txtmidterm.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Midterm Grade*";
            // 
            // txtfinal
            // 
            this.txtfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinal.Location = new System.Drawing.Point(16, 332);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(112, 26);
            this.txtfinal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Final Grade*";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(305, 323);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 49);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student Grade Analyzer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 388);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmidterm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprelim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstudentname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxshowgrade);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.txtstudentnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudentnum;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.ListBox lboxshowgrade;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprelim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmidterm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label6;
    }
}

