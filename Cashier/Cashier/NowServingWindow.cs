namespace Cashier {
    public partial class NowServingWindow : Form {
        public NowServingWindow() {
            InitializeComponent();
        }

        private void NowServingWindow_Load(object sender, EventArgs e) {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = (1 * 100);
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (CashierClass.CashierQueue.Count > 0) {
                lblQueue.Text = CashierClass.CashierQueue.Peek();
            } else {
                lblQueue.Text = "Queue is empty.";
            }
        }
    }
}
