namespace Product_Order_Management
{
    partial class frmLoadProducts
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
            this.DataGridViewProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewProducts
            // 
            this.DataGridViewProducts.BackgroundColor = System.Drawing.Color.LightPink;
            this.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewProducts.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewProducts.Name = "DataGridViewProducts";
            this.DataGridViewProducts.RowTemplate.Height = 28;
            this.DataGridViewProducts.Size = new System.Drawing.Size(1493, 690);
            this.DataGridViewProducts.TabIndex = 0;
            this.DataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewProducts_CellContentClick);
            // 
            // frmLoadProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 690);
            this.Controls.Add(this.DataGridViewProducts);
            this.Name = "frmLoadProducts";
            this.Text = "frmLoadProducts";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewProducts;
    }
}