namespace Product_Order_Management
{
    partial class DeleteProduct
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
            this.lblEnterCode = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterCode
            // 
            this.lblEnterCode.AutoSize = true;
            this.lblEnterCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEnterCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnterCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCode.Location = new System.Drawing.Point(12, 25);
            this.lblEnterCode.Name = "lblEnterCode";
            this.lblEnterCode.Size = new System.Drawing.Size(288, 27);
            this.lblEnterCode.TabIndex = 0;
            this.lblEnterCode.Text = "Please Enter the Product Code:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(12, 68);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(279, 30);
            this.txtProductCode.TabIndex = 1;
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConfirmDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmDelete.Location = new System.Drawing.Point(12, 121);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(172, 42);
            this.btnConfirmDelete.TabIndex = 2;
            this.btnConfirmDelete.Text = "Confirm Delete";
            this.btnConfirmDelete.UseVisualStyleBackColor = false;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(290, 121);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 175);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirmDelete);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblEnterCode);
            this.Name = "DeleteProduct";
            this.Text = "frmDeleteProduct";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterCode;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Button btnExit;
    }
}