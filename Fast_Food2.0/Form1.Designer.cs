namespace Fast_Food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            chkHamburger = new CheckBox();
            chkCheese = new CheckBox();
            chkLettuce = new CheckBox();
            chkTomato = new CheckBox();
            btnOrderNow = new Button();
            txtOrderSummary = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 255, 128);
            label1.Font = new Font("Swis721 BlkCn BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(70, 141);
            label1.Name = "label1";
            label1.Size = new Size(208, 60);
            label1.TabIndex = 0;
            label1.Text = "Selecione o que deseja incluir no seu lanche";
            // 
            // chkHamburger
            // 
            chkHamburger.AutoSize = true;
            chkHamburger.Location = new Point(70, 204);
            chkHamburger.Name = "chkHamburger";
            chkHamburger.Size = new Size(87, 19);
            chkHamburger.TabIndex = 1;
            chkHamburger.Text = "Hamburger";
            chkHamburger.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(70, 229);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(61, 19);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "Queijo";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            chkLettuce.AutoSize = true;
            chkLettuce.Location = new Point(70, 254);
            chkLettuce.Name = "chkLettuce";
            chkLettuce.Size = new Size(62, 19);
            chkLettuce.TabIndex = 3;
            chkLettuce.Text = "Alface ";
            chkLettuce.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            chkTomato.AutoSize = true;
            chkTomato.Location = new Point(70, 279);
            chkTomato.Name = "chkTomato";
            chkTomato.Size = new Size(65, 19);
            chkTomato.TabIndex = 4;
            chkTomato.Text = "Tomate";
            chkTomato.UseVisualStyleBackColor = true;
            // 
            // btnOrderNow
            // 
            btnOrderNow.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderNow.Location = new Point(70, 316);
            btnOrderNow.Name = "btnOrderNow";
            btnOrderNow.Size = new Size(184, 42);
            btnOrderNow.TabIndex = 5;
            btnOrderNow.Text = "Confirmar Pedido";
            btnOrderNow.UseVisualStyleBackColor = true;
            btnOrderNow.Click += btnOrderNow_Click;
            // 
            // txtOrderSummary
            // 
            txtOrderSummary.BackColor = Color.FromArgb(255, 255, 128);
            txtOrderSummary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrderSummary.ForeColor = Color.FromArgb(0, 192, 0);
            txtOrderSummary.Location = new Point(354, 316);
            txtOrderSummary.Name = "txtOrderSummary";
            txtOrderSummary.Size = new Size(345, 29);
            txtOrderSummary.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Swis721 Blk BT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(142, 18);
            label2.Name = "label2";
            label2.Size = new Size(557, 72);
            label2.TabIndex = 7;
            label2.Text = "Metrô Lanches";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Location = new Point(744, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(56, 453);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(378, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 171);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.VisibleChanged += btnOrderNow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtOrderSummary);
            Controls.Add(btnOrderNow);
            Controls.Add(chkTomato);
            Controls.Add(chkLettuce);
            Controls.Add(chkCheese);
            Controls.Add(chkHamburger);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            VisibleChanged += pictureBox1_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chkHamburger;
        private CheckBox chkCheese;
        private CheckBox chkLettuce;
        private CheckBox chkTomato;
        private Button btnOrderNow;
        private TextBox txtOrderSummary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
