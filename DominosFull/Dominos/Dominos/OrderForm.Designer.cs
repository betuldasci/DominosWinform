namespace Dominos
{
    partial class OrderForm
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
            this.PizzaBtn = new System.Windows.Forms.Button();
            this.ByProductsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SizePnl = new System.Windows.Forms.Panel();
            this.PizzaPnl = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pizzaLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLbl = new System.Windows.Forms.Label();
            this.PersonelLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.beverageBtn = new System.Windows.Forms.Button();
            this.sauceBtn = new System.Windows.Forms.Button();
            this.campaignBtn = new System.Windows.Forms.Button();
            this.dessertBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalPriceLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PizzaBtn
            // 
            this.PizzaBtn.Location = new System.Drawing.Point(1856, 98);
            this.PizzaBtn.Name = "PizzaBtn";
            this.PizzaBtn.Size = new System.Drawing.Size(94, 67);
            this.PizzaBtn.TabIndex = 0;
            this.PizzaBtn.Text = "Pizza";
            this.PizzaBtn.UseVisualStyleBackColor = true;
            this.PizzaBtn.Click += new System.EventHandler(this.PizzaBtn_Click);
            // 
            // ByProductsBtn
            // 
            this.ByProductsBtn.Location = new System.Drawing.Point(1856, 192);
            this.ByProductsBtn.Name = "ByProductsBtn";
            this.ByProductsBtn.Size = new System.Drawing.Size(94, 66);
            this.ByProductsBtn.TabIndex = 1;
            this.ByProductsBtn.Text = "Yan Ürünler";
            this.ByProductsBtn.UseVisualStyleBackColor = true;
            this.ByProductsBtn.Click += new System.EventHandler(this.ByProductsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(400, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 30);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // SizePnl
            // 
            this.SizePnl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SizePnl.Location = new System.Drawing.Point(400, 128);
            this.SizePnl.Name = "SizePnl";
            this.SizePnl.Size = new System.Drawing.Size(1450, 120);
            this.SizePnl.TabIndex = 4;
            // 
            // PizzaPnl
            // 
            this.PizzaPnl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PizzaPnl.Location = new System.Drawing.Point(400, 278);
            this.PizzaPnl.Name = "PizzaPnl";
            this.PizzaPnl.Size = new System.Drawing.Size(1450, 550);
            this.PizzaPnl.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.pizzaLbl);
            this.panel4.Location = new System.Drawing.Point(400, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1450, 30);
            this.panel4.TabIndex = 5;
            // 
            // pizzaLbl
            // 
            this.pizzaLbl.AutoSize = true;
            this.pizzaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pizzaLbl.ForeColor = System.Drawing.Color.White;
            this.pizzaLbl.Location = new System.Drawing.Point(3, 0);
            this.pizzaLbl.Name = "pizzaLbl";
            this.pizzaLbl.Size = new System.Drawing.Size(81, 29);
            this.pizzaLbl.TabIndex = 4;
            this.pizzaLbl.Text = "Pizza";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.dateLbl);
            this.panel2.Controls.Add(this.PersonelLbl);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2050, 95);
            this.panel2.TabIndex = 7;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLbl.Location = new System.Drawing.Point(1850, 50);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(60, 24);
            this.dateLbl.TabIndex = 8;
            this.dateLbl.Text = "label3";
            // 
            // PersonelLbl
            // 
            this.PersonelLbl.AutoSize = true;
            this.PersonelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PersonelLbl.Location = new System.Drawing.Point(1850, 24);
            this.PersonelLbl.Name = "PersonelLbl";
            this.PersonelLbl.Size = new System.Drawing.Size(159, 25);
            this.PersonelLbl.TabIndex = 1;
            this.PersonelLbl.Text = "Personel Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dominos.Properties.Resources.dominosLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // beverageBtn
            // 
            this.beverageBtn.Location = new System.Drawing.Point(1856, 278);
            this.beverageBtn.Name = "beverageBtn";
            this.beverageBtn.Size = new System.Drawing.Size(94, 66);
            this.beverageBtn.TabIndex = 8;
            this.beverageBtn.Text = "Beverages";
            this.beverageBtn.UseVisualStyleBackColor = true;
            this.beverageBtn.Click += new System.EventHandler(this.beverageBtn_Click);
            // 
            // sauceBtn
            // 
            this.sauceBtn.Location = new System.Drawing.Point(1856, 364);
            this.sauceBtn.Name = "sauceBtn";
            this.sauceBtn.Size = new System.Drawing.Size(94, 66);
            this.sauceBtn.TabIndex = 9;
            this.sauceBtn.Text = "Sauces";
            this.sauceBtn.UseVisualStyleBackColor = true;
            this.sauceBtn.Click += new System.EventHandler(this.sauceBtn_Click);
            // 
            // campaignBtn
            // 
            this.campaignBtn.Location = new System.Drawing.Point(1856, 447);
            this.campaignBtn.Name = "campaignBtn";
            this.campaignBtn.Size = new System.Drawing.Size(94, 66);
            this.campaignBtn.TabIndex = 10;
            this.campaignBtn.Text = "Campaigns";
            this.campaignBtn.UseVisualStyleBackColor = true;
            this.campaignBtn.Click += new System.EventHandler(this.campaignBtn_Click);
            // 
            // dessertBtn
            // 
            this.dessertBtn.Location = new System.Drawing.Point(1853, 530);
            this.dessertBtn.Name = "dessertBtn";
            this.dessertBtn.Size = new System.Drawing.Size(94, 66);
            this.dessertBtn.TabIndex = 11;
            this.dessertBtn.Text = "Desserts";
            this.dessertBtn.UseVisualStyleBackColor = true;
            this.dessertBtn.Click += new System.EventHandler(this.dessertBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(248, 585);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(135, 55);
            this.ConfirmBtn.TabIndex = 13;
            this.ConfirmBtn.Text = "Confirm Order";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "ORDER CONTENT";
            // 
            // TotalPriceLbl
            // 
            this.TotalPriceLbl.AutoSize = true;
            this.TotalPriceLbl.Location = new System.Drawing.Point(12, 595);
            this.TotalPriceLbl.Name = "TotalPriceLbl";
            this.TotalPriceLbl.Size = new System.Drawing.Size(72, 16);
            this.TotalPriceLbl.TabIndex = 16;
            this.TotalPriceLbl.Text = "Total Price";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 436);
            this.panel3.TabIndex = 17;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TotalPriceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.dessertBtn);
            this.Controls.Add(this.campaignBtn);
            this.Controls.Add(this.sauceBtn);
            this.Controls.Add(this.beverageBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PizzaPnl);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SizePnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ByProductsBtn);
            this.Controls.Add(this.PizzaBtn);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PizzaBtn;
        private System.Windows.Forms.Button ByProductsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SizePnl;
        private System.Windows.Forms.Panel PizzaPnl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label pizzaLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PersonelLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Button beverageBtn;
        private System.Windows.Forms.Button sauceBtn;
        private System.Windows.Forms.Button campaignBtn;
        private System.Windows.Forms.Button dessertBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalPriceLbl;
        private System.Windows.Forms.Panel panel3;
    }
}