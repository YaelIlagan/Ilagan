namespace StudentRegisApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtmiddlename = new System.Windows.Forms.TextBox();
            this.rbtnmale = new System.Windows.Forms.RadioButton();
            this.rbtnfemale = new System.Windows.Forms.RadioButton();
            this.cboxday = new System.Windows.Forms.ComboBox();
            this.cboxmonth = new System.Windows.Forms.ComboBox();
            this.cboxyear = new System.Windows.Forms.ComboBox();
            this.cboxprogram = new System.Windows.Forms.ComboBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Registration Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name*";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Middle Name*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of Birth*";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Program*";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(23, 82);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(5);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(391, 26);
            this.txtlastname.TabIndex = 7;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(23, 147);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(5);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(391, 26);
            this.txtfirstname.TabIndex = 8;
            // 
            // txtmiddlename
            // 
            this.txtmiddlename.Location = new System.Drawing.Point(23, 213);
            this.txtmiddlename.Margin = new System.Windows.Forms.Padding(5);
            this.txtmiddlename.Name = "txtmiddlename";
            this.txtmiddlename.Size = new System.Drawing.Size(391, 26);
            this.txtmiddlename.TabIndex = 9;
            // 
            // rbtnmale
            // 
            this.rbtnmale.AutoSize = true;
            this.rbtnmale.Location = new System.Drawing.Point(100, 252);
            this.rbtnmale.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnmale.Name = "rbtnmale";
            this.rbtnmale.Size = new System.Drawing.Size(65, 24);
            this.rbtnmale.TabIndex = 10;
            this.rbtnmale.TabStop = true;
            this.rbtnmale.Text = "Male";
            this.rbtnmale.UseVisualStyleBackColor = true;
            // 
            // rbtnfemale
            // 
            this.rbtnfemale.AutoSize = true;
            this.rbtnfemale.Location = new System.Drawing.Point(175, 252);
            this.rbtnfemale.Margin = new System.Windows.Forms.Padding(5);
            this.rbtnfemale.Name = "rbtnfemale";
            this.rbtnfemale.Size = new System.Drawing.Size(86, 24);
            this.rbtnfemale.TabIndex = 11;
            this.rbtnfemale.TabStop = true;
            this.rbtnfemale.Text = "Female";
            this.rbtnfemale.UseVisualStyleBackColor = true;
            this.rbtnfemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cboxday
            // 
            this.cboxday.FormattingEnabled = true;
            this.cboxday.Location = new System.Drawing.Point(23, 310);
            this.cboxday.Margin = new System.Windows.Forms.Padding(5);
            this.cboxday.Name = "cboxday";
            this.cboxday.Size = new System.Drawing.Size(97, 28);
            this.cboxday.TabIndex = 12;
            this.cboxday.Text = "Day";
            // 
            // cboxmonth
            // 
            this.cboxmonth.FormattingEnabled = true;
            this.cboxmonth.Location = new System.Drawing.Point(130, 310);
            this.cboxmonth.Margin = new System.Windows.Forms.Padding(5);
            this.cboxmonth.Name = "cboxmonth";
            this.cboxmonth.Size = new System.Drawing.Size(146, 28);
            this.cboxmonth.TabIndex = 13;
            this.cboxmonth.Text = "Month";
            // 
            // cboxyear
            // 
            this.cboxyear.FormattingEnabled = true;
            this.cboxyear.Location = new System.Drawing.Point(286, 310);
            this.cboxyear.Margin = new System.Windows.Forms.Padding(5);
            this.cboxyear.Name = "cboxyear";
            this.cboxyear.Size = new System.Drawing.Size(128, 28);
            this.cboxyear.TabIndex = 14;
            this.cboxyear.Text = "Year";
            // 
            // cboxprogram
            // 
            this.cboxprogram.FormattingEnabled = true;
            this.cboxprogram.Location = new System.Drawing.Point(23, 368);
            this.cboxprogram.Margin = new System.Windows.Forms.Padding(5);
            this.cboxprogram.Name = "cboxprogram";
            this.cboxprogram.Size = new System.Drawing.Size(391, 28);
            this.cboxprogram.TabIndex = 15;
            this.cboxprogram.Text = "Program";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.IndianRed;
            this.btnsubmit.Location = new System.Drawing.Point(23, 404);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(391, 51);
            this.btnsubmit.TabIndex = 16;
            this.btnsubmit.Text = "Register Student";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 480);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.cboxprogram);
            this.Controls.Add(this.cboxyear);
            this.Controls.Add(this.cboxmonth);
            this.Controls.Add(this.cboxday);
            this.Controls.Add(this.rbtnfemale);
            this.Controls.Add(this.rbtnmale);
            this.Controls.Add(this.txtmiddlename);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmiddlename;
        private System.Windows.Forms.RadioButton rbtnmale;
        private System.Windows.Forms.RadioButton rbtnfemale;
        private System.Windows.Forms.ComboBox cboxday;
        private System.Windows.Forms.ComboBox cboxmonth;
        private System.Windows.Forms.ComboBox cboxyear;
        private System.Windows.Forms.ComboBox cboxprogram;
        private System.Windows.Forms.Button btnsubmit;
    }
}

