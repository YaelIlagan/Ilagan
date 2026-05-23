namespace EmployeeApplication
{
    partial class frmEmployeeApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeApplication));
            this.dvgemployeelist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgemployeelist)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgemployeelist
            // 
            this.dvgemployeelist.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dvgemployeelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgemployeelist.Location = new System.Drawing.Point(356, 113);
            this.dvgemployeelist.Name = "dvgemployeelist";
            this.dvgemployeelist.Size = new System.Drawing.Size(450, 322);
            this.dvgemployeelist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Broadway", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD EMPLOYEE";
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.BackColor = System.Drawing.Color.White;
            this.txtemployeeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeid.Location = new System.Drawing.Point(23, 113);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(315, 29);
            this.txtemployeeid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(72)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(72)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(18, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name*";
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.Color.White;
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(23, 187);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(315, 29);
            this.txtfname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(72)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Last Name*";
            // 
            // txtlname
            // 
            this.txtlname.BackColor = System.Drawing.Color.White;
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(23, 261);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(315, 29);
            this.txtlname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(72)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(18, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Position*";
            // 
            // txtposition
            // 
            this.txtposition.BackColor = System.Drawing.Color.White;
            this.txtposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(23, 336);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(315, 29);
            this.txtposition.TabIndex = 8;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Beige;
            this.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnsubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(72)))), ((int)(((byte)(50)))));
            this.btnsubmit.Location = new System.Drawing.Point(83, 389);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(195, 46);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(72)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(351, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "EMPLOYEE LIST";
            // 
            // frmEmployeeApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtposition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemployeeid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgemployeelist);
            this.Name = "frmEmployeeApplication";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgemployeelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgemployeelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label6;
    }
}

