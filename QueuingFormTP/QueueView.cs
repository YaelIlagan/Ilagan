using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueueView : Form
    {
        public QueueView()
        {
            InitializeComponent();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                lblQueueServe.Text = CashierClass.CashierQueue.Peek().ToString();
            }
        }
    }
}
