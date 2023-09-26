namespace Cashier {
    partial class NowServingWindow {
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
            lblQueue = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(67, 77);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(50, 38);
            lblQueue.TabIndex = 4;
            lblQueue.Text = "---";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(148, 31);
            label1.TabIndex = 3;
            label1.Text = "Now Serving:";
            // 
            // NowServingWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 157);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "NowServingWindow";
            Text = "NowServingWindow";
            Load += NowServingWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQueue;
        private Label label1;
    }
}