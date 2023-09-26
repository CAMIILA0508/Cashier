namespace Cashier {
    public partial class QueuingForm : Form {
        private CashierClass cashier;
        public QueuingForm() {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            NowServingWindow nowServingWindow = new NowServingWindow();
            nowServingWindow.Show();
            cashierWindow.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e) {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}