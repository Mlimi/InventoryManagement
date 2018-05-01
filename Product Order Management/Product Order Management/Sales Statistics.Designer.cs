namespace Product_Order_Management
{
    partial class frmSalesStatistics
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
            this.dataGridViewSalesStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalesStatistics
            // 
            this.dataGridViewSalesStatistics.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSalesStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSalesStatistics.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSalesStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSalesStatistics.Name = "dataGridViewSalesStatistics";
            this.dataGridViewSalesStatistics.RowTemplate.Height = 28;
            this.dataGridViewSalesStatistics.Size = new System.Drawing.Size(980, 419);
            this.dataGridViewSalesStatistics.TabIndex = 0;
            this.dataGridViewSalesStatistics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesStatistics_CellContentClick);
            // 
            // frmSalesStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(980, 419);
            this.Controls.Add(this.dataGridViewSalesStatistics);
            this.Name = "frmSalesStatistics";
            this.Text = "Sales Statistics";
            this.Load += new System.EventHandler(this.frmSalesStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalesStatistics;
    }
}