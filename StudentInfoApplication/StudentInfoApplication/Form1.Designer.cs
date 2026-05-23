namespace StudentInfoApplication
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
            this.txtstudid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxstudid = new System.Windows.Forms.ListBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lboxfname = new System.Windows.Forms.ListBox();
            this.lboxlname = new System.Windows.Forms.ListBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtstudid
            // 
            this.txtstudid.BackColor = System.Drawing.Color.MediumPurple;
            this.txtstudid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstudid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudid.Location = new System.Drawing.Point(38, 65);
            this.txtstudid.Name = "txtstudid";
            this.txtstudid.Size = new System.Drawing.Size(176, 26);
            this.txtstudid.TabIndex = 0;
            this.txtstudid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // lboxstudid
            // 
            this.lboxstudid.BackColor = System.Drawing.Color.MediumPurple;
            this.lboxstudid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxstudid.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxstudid.ForeColor = System.Drawing.Color.Black;
            this.lboxstudid.FormattingEnabled = true;
            this.lboxstudid.ItemHeight = 21;
            this.lboxstudid.Location = new System.Drawing.Point(38, 131);
            this.lboxstudid.Name = "lboxstudid";
            this.lboxstudid.Size = new System.Drawing.Size(177, 191);
            this.lboxstudid.TabIndex = 2;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsubmit.BackgroundImage")));
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.Yellow;
            this.btnsubmit.Location = new System.Drawing.Point(128, 340);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(191, 60);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lboxfname
            // 
            this.lboxfname.BackColor = System.Drawing.Color.MediumPurple;
            this.lboxfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxfname.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxfname.ForeColor = System.Drawing.Color.Black;
            this.lboxfname.FormattingEnabled = true;
            this.lboxfname.ItemHeight = 21;
            this.lboxfname.Location = new System.Drawing.Point(241, 131);
            this.lboxfname.Name = "lboxfname";
            this.lboxfname.Size = new System.Drawing.Size(177, 191);
            this.lboxfname.TabIndex = 4;
            // 
            // lboxlname
            // 
            this.lboxlname.BackColor = System.Drawing.Color.MediumPurple;
            this.lboxlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxlname.Font = new System.Drawing.Font("Ravie", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxlname.ForeColor = System.Drawing.Color.Black;
            this.lboxlname.FormattingEnabled = true;
            this.lboxlname.ItemHeight = 21;
            this.lboxlname.Location = new System.Drawing.Point(443, 131);
            this.lboxlname.Name = "lboxlname";
            this.lboxlname.Size = new System.Drawing.Size(177, 191);
            this.lboxlname.TabIndex = 5;
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.MediumPurple;
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(241, 65);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(177, 26);
            this.txtfname.TabIndex = 6;
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.MediumPurple;
            this.txtlname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(443, 65);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(177, 26);
            this.txtlname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclear.BackgroundImage")));
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(357, 340);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(191, 60);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Student ID List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "First Name List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last Name List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.lboxlname);
            this.Controls.Add(this.lboxfname);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lboxstudid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstudid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstudid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxstudid;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ListBox lboxfname;
        private System.Windows.Forms.ListBox lboxlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

