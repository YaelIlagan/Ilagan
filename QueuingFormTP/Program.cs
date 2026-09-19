using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();

            QueueView QueueLineView = new QueueView();
            QueueLineView.Show();

            Application.Run(new QueuingForm());
        }
    }
}
