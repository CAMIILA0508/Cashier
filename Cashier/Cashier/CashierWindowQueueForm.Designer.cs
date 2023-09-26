namespace Cashier {
    partial class CashierWindowQueueForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            ListCashierQueue = new ListBox();
            btnRefresh = new Button();
            btnNext = new Button();
            SuspendLayout();
            // 
            // ListCashierQueue
            // 
            ListCashierQueue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListCashierQueue.FormattingEnabled = true;
            ListCashierQueue.ItemHeight = 28;
            ListCashierQueue.Location = new Point(109, 12);
            ListCashierQueue.Name = "ListCashierQueue";
            ListCashierQueue.Size = new Size(265, 396);
            ListCashierQueue.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(9, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(9, 47);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(386, 420);
            Controls.Add(btnNext);
            Controls.Add(btnRefresh);
            Controls.Add(ListCashierQueue);
            MaximizeBox = false;
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListCashierQueue;
        private Button btnRefresh;
        private Button btnNext;
    }
}