namespace StudentGradeApp
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
            this.Title = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Englishlabel = new System.Windows.Forms.Label();
            this.Mathlabel = new System.Windows.Forms.Label();
            this.Sciencelabel = new System.Windows.Forms.Label();
            this.Filipinolabel = new System.Windows.Forms.Label();
            this.Historylabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.txtscience = new System.Windows.Forms.TextBox();
            this.txtfil = new System.Windows.Forms.TextBox();
            this.txthistory = new System.Windows.Forms.TextBox();
            this.Gradeprompt = new System.Windows.Forms.Label();
            this.Gradepromtbl = new System.Windows.Forms.Label();
            this.genbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(239, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(303, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Grade Average Application";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(40, 102);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(66, 22);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Name:";
            this.Namelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Englishlabel
            // 
            this.Englishlabel.AutoSize = true;
            this.Englishlabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Englishlabel.Location = new System.Drawing.Point(41, 197);
            this.Englishlabel.Name = "Englishlabel";
            this.Englishlabel.Size = new System.Drawing.Size(93, 22);
            this.Englishlabel.TabIndex = 2;
            this.Englishlabel.Text = "English: ";
            // 
            // Mathlabel
            // 
            this.Mathlabel.AutoSize = true;
            this.Mathlabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mathlabel.Location = new System.Drawing.Point(40, 235);
            this.Mathlabel.Name = "Mathlabel";
            this.Mathlabel.Size = new System.Drawing.Size(63, 22);
            this.Mathlabel.TabIndex = 3;
            this.Mathlabel.Text = "Math:";
            // 
            // Sciencelabel
            // 
            this.Sciencelabel.AutoSize = true;
            this.Sciencelabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sciencelabel.Location = new System.Drawing.Point(41, 273);
            this.Sciencelabel.Name = "Sciencelabel";
            this.Sciencelabel.Size = new System.Drawing.Size(89, 22);
            this.Sciencelabel.TabIndex = 4;
            this.Sciencelabel.Text = "Science: ";
            // 
            // Filipinolabel
            // 
            this.Filipinolabel.AutoSize = true;
            this.Filipinolabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filipinolabel.Location = new System.Drawing.Point(40, 308);
            this.Filipinolabel.Name = "Filipinolabel";
            this.Filipinolabel.Size = new System.Drawing.Size(90, 22);
            this.Filipinolabel.TabIndex = 5;
            this.Filipinolabel.Text = "Filipino:";
            // 
            // Historylabel
            // 
            this.Historylabel.AutoSize = true;
            this.Historylabel.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historylabel.Location = new System.Drawing.Point(44, 341);
            this.Historylabel.Name = "Historylabel";
            this.Historylabel.Size = new System.Drawing.Size(90, 22);
            this.Historylabel.TabIndex = 6;
            this.Historylabel.Text = "History: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(112, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(316, 29);
            this.txtname.TabIndex = 8;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtenglish
            // 
            this.txtenglish.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtenglish.Location = new System.Drawing.Point(134, 194);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(127, 29);
            this.txtenglish.TabIndex = 9;
            // 
            // txtmath
            // 
            this.txtmath.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmath.Location = new System.Drawing.Point(134, 232);
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(127, 29);
            this.txtmath.TabIndex = 10;
            // 
            // txtscience
            // 
            this.txtscience.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscience.Location = new System.Drawing.Point(134, 270);
            this.txtscience.Name = "txtscience";
            this.txtscience.Size = new System.Drawing.Size(127, 29);
            this.txtscience.TabIndex = 11;
            // 
            // txtfil
            // 
            this.txtfil.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfil.Location = new System.Drawing.Point(134, 305);
            this.txtfil.Name = "txtfil";
            this.txtfil.Size = new System.Drawing.Size(127, 29);
            this.txtfil.TabIndex = 12;
            // 
            // txthistory
            // 
            this.txthistory.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistory.Location = new System.Drawing.Point(134, 338);
            this.txthistory.Name = "txthistory";
            this.txthistory.Size = new System.Drawing.Size(127, 29);
            this.txthistory.TabIndex = 13;
            // 
            // Gradeprompt
            // 
            this.Gradeprompt.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gradeprompt.Location = new System.Drawing.Point(414, 204);
            this.Gradeprompt.Name = "Gradeprompt";
            this.Gradeprompt.Size = new System.Drawing.Size(294, 35);
            this.Gradeprompt.TabIndex = 14;
            this.Gradeprompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gradeprompt.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Gradepromtbl
            // 
            this.Gradepromtbl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gradepromtbl.Location = new System.Drawing.Point(414, 242);
            this.Gradepromtbl.Name = "Gradepromtbl";
            this.Gradepromtbl.Size = new System.Drawing.Size(294, 80);
            this.Gradepromtbl.TabIndex = 15;
            this.Gradepromtbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // genbtn
            // 
            this.genbtn.BackColor = System.Drawing.Color.White;
            this.genbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genbtn.Font = new System.Drawing.Font("Elephant", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genbtn.Location = new System.Drawing.Point(44, 383);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(217, 66);
            this.genbtn.TabIndex = 16;
            this.genbtn.Text = "Generate Average";
            this.genbtn.UseVisualStyleBackColor = false;
            this.genbtn.Click += new System.EventHandler(this.genbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.genbtn);
            this.Controls.Add(this.Gradepromtbl);
            this.Controls.Add(this.Gradeprompt);
            this.Controls.Add(this.txthistory);
            this.Controls.Add(this.txtfil);
            this.Controls.Add(this.txtscience);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txtenglish);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Historylabel);
            this.Controls.Add(this.Filipinolabel);
            this.Controls.Add(this.Sciencelabel);
            this.Controls.Add(this.Mathlabel);
            this.Controls.Add(this.Englishlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Englishlabel;
        private System.Windows.Forms.Label Mathlabel;
        private System.Windows.Forms.Label Sciencelabel;
        private System.Windows.Forms.Label Filipinolabel;
        private System.Windows.Forms.Label Historylabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtenglish;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.TextBox txtscience;
        private System.Windows.Forms.TextBox txtfil;
        private System.Windows.Forms.TextBox txthistory;
        private System.Windows.Forms.Label Gradeprompt;
        private System.Windows.Forms.Label Gradepromtbl;
        private System.Windows.Forms.Button genbtn;
    }
}

