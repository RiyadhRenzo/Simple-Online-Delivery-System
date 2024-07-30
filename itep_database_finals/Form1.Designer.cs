namespace itep_database_finals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            exit = new Button();
            checkorder = new Button();
            shop = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -93);
            panel1.Name = "panel1";
            panel1.Size = new Size(1615, 181);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(472, 90);
            label1.Name = "label1";
            label1.Size = new Size(662, 77);
            label1.TabIndex = 1;
            label1.Text = "Online Delivery System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(exit);
            panel2.Controls.Add(checkorder);
            panel2.Controls.Add(shop);
            panel2.Location = new Point(0, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(420, 823);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // exit
            // 
            exit.BackColor = Color.Silver;
            exit.FlatAppearance.BorderColor = Color.Black;
            exit.FlatAppearance.BorderSize = 3;
            exit.FlatStyle = FlatStyle.System;
            exit.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            exit.Location = new Point(42, 555);
            exit.Name = "exit";
            exit.Size = new Size(349, 161);
            exit.TabIndex = 4;
            exit.Text = "QUIT";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // checkorder
            // 
            checkorder.BackColor = SystemColors.ActiveCaption;
            checkorder.FlatAppearance.BorderColor = Color.Black;
            checkorder.FlatAppearance.BorderSize = 3;
            checkorder.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            checkorder.Location = new Point(42, 350);
            checkorder.Name = "checkorder";
            checkorder.Size = new Size(349, 154);
            checkorder.TabIndex = 3;
            checkorder.Text = "Check Order/s";
            checkorder.UseVisualStyleBackColor = false;
            checkorder.Click += button2_Click;
            // 
            // shop
            // 
            shop.BackColor = SystemColors.ActiveCaption;
            shop.FlatAppearance.BorderColor = Color.Black;
            shop.FlatAppearance.BorderSize = 3;
            shop.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            shop.Location = new Point(42, 153);
            shop.Name = "shop";
            shop.Size = new Size(349, 165);
            shop.TabIndex = 2;
            shop.Text = "Lets SHOP!";
            shop.UseVisualStyleBackColor = false;
            shop.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(105, -194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1584, 1194);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1565, 898);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Employee Database";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button exit;
        private Button checkorder;
        private Button shop;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}
