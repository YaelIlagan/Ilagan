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
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                lblQueueServe.Text = CashierClass.CashierQueue.Peek();
            }
            catch (InvalidOperationException)
            {
                lblQueueServe.Text = "P - 00000"; 
            }
        }
    }
}
;