namespace QueuingForm
{
    partial class CashierWindowQueueForm
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
            listView1 = new ListView();
            btnRefresh = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(159, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(282, 321);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.Black;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(10, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(140, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatAppearance.BorderColor = Color.Black;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(10, 56);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(140, 35);
            btnNext.TabIndex = 2;
            btnNext.Text = "NEXT";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(450, 345);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Controls.Add(listView1);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button btnRefresh;
        private Button btnNext;
    }
}