namespace QueuingForm
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
            btnCashier = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.BackColor = Color.White;
            btnCashier.FlatAppearance.BorderColor = Color.LightGray;
            btnCashier.FlatAppearance.BorderSize = 3;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashier.Location = new Point(22, 16);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(130, 120);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "CASHIER";
            btnCashier.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 37);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 1;
            label1.Text = "Position In Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 62);
            label2.Name = "label2";
            label2.Size = new Size(201, 54);
            label2.TabIndex = 2;
            label2.Text = "P - 10000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(19, 144);
            label3.Name = "label3";
            label3.Size = new Size(138, 17);
            label3.TabIndex = 3;
            label3.Text = "*Click To Get Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(456, 172);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Name = "Form1";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
