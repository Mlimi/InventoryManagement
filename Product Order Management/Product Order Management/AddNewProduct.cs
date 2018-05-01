using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Order_Management
{
    public partial class frmAddNewProduct : Form 
    {
        frmMain olderForm = new frmMain();
        ProductList prevList = new ProductList();
      //  frmMain prevform;
        public frmAddNewProduct(frmMain oldForm)
        {
            olderForm = oldForm;
            prevList = oldForm.mainList;
            InitializeComponent();
        
        }

      

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clearControl()
        {
            txtName.Text = "  ";
            txtCode.Text = "   ";
            txtQuantityOrdered.Text = "  ";
            txtQuantitySold.Text = "  ";
            txtSalesPrice.Text = " ";
            txtOrderPrice.Text = " ";
            txtOrderDate.Text = "  ";
 }




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                Product p = new Product();
                p.Code = Convert.ToString(txtCode.Text);
                p.Name = Convert.ToString(txtName.Text);
                p.QuantityOrdered = Convert.ToInt32(txtQuantityOrdered.Text);
                p.QuantitySold = Convert.ToInt32(txtQuantitySold.Text);
                p.OrderPrice = Convert.ToDecimal(txtOrderPrice.Text);
                p.SalesPrice = Convert.ToDecimal(txtSalesPrice.Text);
                p.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                prevList.AddProduct(p);
                olderForm.mainList = prevList;

                MessageBox.Show("The Product was successfully added the Inventory", "Confirmation");
                clearControl();
            }

 }
        //Validator
        private bool IsValidData()
        {
            return Validator.IsPresent(txtCode) &&
                   Validator.IsPresent(txtName) &&
                   Validator.IsPresent(txtOrderPrice) &&
                   Validator.IsDecimal(txtOrderPrice) &&
                   Validator.IsPresent(txtSalesPrice) &&
                   Validator.IsDecimal(txtSalesPrice) &&
                    Validator.IsPresent(txtQuantityOrdered) &&
                    Validator.IsInt32(txtQuantityOrdered) &&
                    Validator.IsPresent(txtOrderDate);
 }











    }
}
