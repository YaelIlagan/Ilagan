namespace WordGuessApplication
{
    partial class frmGuessWord
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
            this.txtguess = new System.Windows.Forms.TextBox();
            this.btnguess = new System.Windows.Forms.Button();
            this.labelbox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lboxwrong = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtguess
            // 
            this.txtguess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguess.Location = new System.Drawing.Point(88, 135);
            this.txtguess.Name = "txtguess";
            this.txtguess.Size = new System.Drawing.Size(369, 29);
            this.txtguess.TabIndex = 0;
            // 
            // btnguess
            // 
            this.btnguess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnguess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguess.ForeColor = System.Drawing.Color.White;
            this.btnguess.Location = new System.Drawing.Point(202, 173);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(123, 37);
            this.btnguess.TabIndex = 1;
            this.btnguess.Text = "Guess";
            this.btnguess.UseVisualStyleBackColor = false;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // labelbox
            // 
            this.labelbox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbox.Location = new System.Drawing.Point(29, 53);
            this.labelbox.Name = "labelbox";
            this.labelbox.Size = new System.Drawing.Size(472, 74);
            this.labelbox.TabIndex = 2;
            this.labelbox.Text = "c??????r";
            this.labelbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wrong Guess";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboxwrong
            // 
            this.lboxwrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxwrong.FormattingEnabled = true;
            this.lboxwrong.ItemHeight = 20;
            this.lboxwrong.Location = new System.Drawing.Point(545, 104);
            this.lboxwrong.Name = "lboxwrong";
            this.lboxwrong.Size = new System.Drawing.Size(224, 184);
            this.lboxwrong.TabIndex = 5;
            // 
            // frmGuessWord
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.lboxwrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbox);
            this.Controls.Add(this.btnguess);
            this.Controls.Add(this.txtguess);
            this.Name = "frmGuessWord";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtguess;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Label labelbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lboxwrong;
    }
}

