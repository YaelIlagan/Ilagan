using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();

            timer1.Tick += new EventHandler(timer1_Tick); //every tick 1000ms will call timer1_Tick method
            timer1.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)//manual refresh of listBox
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //if may laman yung listBox then dequeue, refresh then display updated queue
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue); //auto refresh every 1 second
        }

        public void DisplayCashierQueue(IEnumerable CashierList)// foreach for Queue
        {
            lvListCashierQueue.Items.Clear();

            foreach (Object obj in CashierList)
            {
                lvListCashierQueue.Items.Add(obj.ToString());//inserting every number sa queue 1 by 1
            }
        }
    }
}
