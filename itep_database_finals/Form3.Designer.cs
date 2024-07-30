namespace itep_database_finals
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            Checkout = new Label();
            backtoform2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            backtoform1 = new Label();
            remove = new Label();
            cancel = new Label();
            txtCartIDToDelete = new TextBox();
            txtCartIDToCancel = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(143, 0);
            label1.Name = "label1";
            label1.Size = new Size(662, 77);
            label1.TabIndex = 1;
            label1.Text = "Online Delivery System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 78);
            panel1.TabIndex = 2;
            // 
            // Checkout
            // 
            Checkout.AutoSize = true;
            Checkout.BackColor = SystemColors.ActiveCaption;
            Checkout.FlatStyle = FlatStyle.Popup;
            Checkout.Font = new Font("Rockwell", 20F);
            Checkout.Location = new Point(92, 565);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(198, 46);
            Checkout.TabIndex = 3;
            Checkout.Text = "Checkout";
            Checkout.Click += checkout_Click;
            // 
            // backtoform2
            // 
            backtoform2.AutoSize = true;
            backtoform2.BackColor = SystemColors.ActiveCaption;
            backtoform2.FlatStyle = FlatStyle.Popup;
            backtoform2.Font = new Font("Rockwell", 20F);
            backtoform2.Location = new Point(634, 844);
            backtoform2.Name = "backtoform2";
            backtoform2.Size = new Size(340, 46);
            backtoform2.TabIndex = 4;
            backtoform2.Text = "Back to Shopping";
            backtoform2.Click += backtoform2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(789, 351);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 29F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(341, 131);
            label3.Name = "label3";
            label3.Size = new Size(235, 77);
            label3.TabIndex = 6;
            label3.Text = "Receipt";
            label3.Click += label3_Click;
            // 
            // backtoform1
            // 
            backtoform1.AutoSize = true;
            backtoform1.BackColor = SystemColors.ActiveCaption;
            backtoform1.FlatStyle = FlatStyle.Popup;
            backtoform1.Font = new Font("Rockwell", 20F);
            backtoform1.Location = new Point(0, 844);
            backtoform1.Name = "backtoform1";
            backtoform1.Size = new Size(129, 46);
            backtoform1.TabIndex = 7;
            backtoform1.Text = "Home";
            backtoform1.Click += backtoform1_Click;
            // 
            // remove
            // 
            remove.AutoSize = true;
            remove.BackColor = SystemColors.ActiveCaption;
            remove.FlatStyle = FlatStyle.Popup;
            remove.Font = new Font("Rockwell", 20F);
            remove.Location = new Point(313, 565);
            remove.Name = "remove";
            remove.Size = new Size(263, 46);
            remove.TabIndex = 8;
            remove.Text = "Remove Item";
            remove.Click += remove_Click;
            // 
            // cancel
            // 
            cancel.AutoSize = true;
            cancel.BackColor = SystemColors.ActiveCaption;
            cancel.FlatStyle = FlatStyle.Popup;
            cancel.Font = new Font("Rockwell", 20F);
            cancel.Location = new Point(607, 565);
            cancel.Name = "cancel";
            cancel.Size = new Size(274, 46);
            cancel.TabIndex = 9;
            cancel.Text = "Cancel Order";
            cancel.Click += cancel_Click;
            // 
            // txtCartIDToDelete
            // 
            txtCartIDToDelete.Location = new Point(375, 614);
            txtCartIDToDelete.Name = "txtCartIDToDelete";
            txtCartIDToDelete.Size = new Size(150, 31);
            txtCartIDToDelete.TabIndex = 10;
            // 
            // txtCartIDToCancel
            // 
            txtCartIDToCancel.Location = new Point(676, 614);
            txtCartIDToCancel.Name = "txtCartIDToCancel";
            txtCartIDToCancel.Size = new Size(150, 31);
            txtCartIDToCancel.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 889);
            Controls.Add(txtCartIDToCancel);
            Controls.Add(txtCartIDToDelete);
            Controls.Add(cancel);
            Controls.Add(remove);
            Controls.Add(backtoform1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(backtoform2);
            Controls.Add(Checkout);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            Load += checkout_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label Checkout;
        private Label backtoform2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label backtoform1;
        private Label remove;
        private Label cancel;
        private TextBox txtCartIDToDelete;
        private TextBox txtCartIDToCancel;
    }
}