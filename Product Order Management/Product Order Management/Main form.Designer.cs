namespace Product_Order_Management
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.btnSalesStatistics = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadProducts.BackgroundImage")));
            this.btnLoadProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadProducts.ForeColor = System.Drawing.Color.Navy;
            this.btnLoadProducts.Location = new System.Drawing.Point(2, 58);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(217, 124);
            this.btnLoadProducts.TabIndex = 1;
            this.btnLoadProducts.Text = "Load Products Ordered By Quantity Sold\r\n";
            this.btnLoadProducts.UseVisualStyleBackColor = false;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            // 
            // btnSalesStatistics
            // 
            this.btnSalesStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalesStatistics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalesStatistics.BackgroundImage")));
            this.btnSalesStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalesStatistics.Location = new System.Drawing.Point(2, 188);
            this.btnSalesStatistics.Name = "btnSalesStatistics";
            this.btnSalesStatistics.Size = new System.Drawing.Size(231, 119);
            this.btnSalesStatistics.TabIndex = 2;
            this.btnSalesStatistics.Text = "Load Inventory Ordered by Earned Profit\r\n";
            this.btnSalesStatistics.UseVisualStyleBackColor = false;
            this.btnSalesStatistics.Click += new System.EventHandler(this.btnSalesStatistics_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Navy;
            this.btnAddProduct.Location = new System.Drawing.Point(239, 186);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(232, 119);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDelete.Location = new System.Drawing.Point(421, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(199, 126);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFindProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindProduct.BackgroundImage")));
            this.btnFindProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProduct.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFindProduct.Location = new System.Drawing.Point(225, 56);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(190, 124);
            this.btnFindProduct.TabIndex = 6;
            this.btnFindProduct.Text = "Find Product";
            this.btnFindProduct.UseVisualStyleBackColor = false;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(477, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 316);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(636, 35);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Navy;
            this.btnAbout.Location = new System.Drawing.Point(477, 186);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(148, 50);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory Management System";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFindProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSalesStatistics);
            this.Controls.Add(this.btnLoadProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Product Order Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.Button btnSalesStatistics;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
    }
}

