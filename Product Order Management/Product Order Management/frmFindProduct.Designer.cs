namespace Product_Order_Management
{
    partial class frmFindProduct
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
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtFindProductCode = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(44, 17);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(293, 27);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Please Enter the Product Code :";
            // 
            // txtFindProductCode
            // 
            this.txtFindProductCode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtFindProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindProductCode.Location = new System.Drawing.Point(44, 69);
            this.txtFindProductCode.Name = "txtFindProductCode";
            this.txtFindProductCode.Size = new System.Drawing.Size(293, 30);
            this.txtFindProductCode.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(44, 118);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 37);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Enter";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(164, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmFindProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(390, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFindProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Name = "frmFindProduct";
            this.Text = "frmFindProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtFindProductCode;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button button2;
    }
}