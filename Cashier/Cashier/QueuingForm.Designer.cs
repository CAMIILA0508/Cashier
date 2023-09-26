namespace Cashier {
    partial class QueuingForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnCashier = new Button();
            label1 = new Label();
            lblQueue = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Location = new Point(30, 30);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(142, 122);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(229, 41);
            label1.Name = "label1";
            label1.Size = new Size(193, 31);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(242, 82);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(50, 38);
            lblQueue.TabIndex = 2;
            lblQueue.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(30, 166);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 3;
            label3.Text = "*Click to get a number";
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(512, 218);
            Controls.Add(label3);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            Controls.Add(btnCashier);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "QueuingForm";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label label1;
        private Label lblQueue;
        private Label label3;
    }
}