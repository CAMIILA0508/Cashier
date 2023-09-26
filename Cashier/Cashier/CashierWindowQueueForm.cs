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

namespace Cashier {
    public partial class CashierWindowQueueForm : Form {
        public CashierWindowQueueForm() {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }


        private void DisplayCashierQueue(IEnumerable CashierList) {
            ListCashierQueue.Items.Clear();
            foreach (var c in CashierList) {
                ListCashierQueue.Items.Add(c.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (CashierClass.CashierQueue.Count > 0)
                CashierClass.CashierQueue.Dequeue();
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e) {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = (1*100);
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

    }
}
